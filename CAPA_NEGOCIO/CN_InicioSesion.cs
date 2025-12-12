using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Data;
// Importamos la librería que acabas de instalar
using BCrypt.Net;

namespace CAPA_NEGOCIO
{
    public class CN_InicioSesion
    {
        private CD_InicioSesion objDato = new CD_InicioSesion();

        // Este método devuelve el OBJETO usuario completo si el login es correcto,
        // o devuelve NULL si falló.
        public CE_InicioSesion ValidarUsuario(string usuario, string clavePlana)
        {
            // 1. Preparamos el objeto para enviar a la Capa de Datos
            CE_InicioSesion objEnvio = new CE_InicioSesion()
            {
                Usuario = usuario
            };

            // 2. Llamamos a la BD para buscar ese usuario
            // Nota: Aquí la BD nos devuelve el HASH, no sabemos si la clave es correcta aún.
            DataTable dt = objDato.D_User(objEnvio);

            // 3. Verificamos si encontramos al usuario
            if (dt.Rows.Count > 0)
            {
                // Obtenemos el Hash que estaba guardado en la BD
                string hashGuardado = dt.Rows[0]["Contrasena_Hash"].ToString();

                // 4. EL MOMENTO DE LA VERDAD:
                // Usamos Bcrypt para comparar la clave escrita (clavePlana) con el Hash de la BD.
                // Verify devuelve TRUE si coinciden, FALSE si no.
                bool esPasswordCorrecto = BCrypt.Net.BCrypt.Verify(clavePlana, hashGuardado);

                if (esPasswordCorrecto)
                {
                    // ¡LOGIN EXITOSO!
                    // Llenamos el objeto entidad con los datos reales de la BD para retornarlo
                    CE_InicioSesion usuarioValidado = new CE_InicioSesion()
                    {
                        Id_Usuario = Convert.ToInt32(dt.Rows[0]["Id_Usuario"]),
                        Usuario = dt.Rows[0]["Usuario"].ToString(),
                        Nombre_Rol = dt.Rows[0]["Nombre_Rol"].ToString(),
                        Id_Tipo_de_Usuario = Convert.ToInt32(dt.Rows[0]["Id_Tipo_de_Usuario"]),
                        // Por seguridad, NO devolvemos el Hash ni la clave a la capa de presentación
                        Contrasena_Hash = ""
                    };

                    return usuarioValidado;
                }
            }

            // Si llegamos aquí, es porque el usuario no existe O la contraseña estaba mal
            return null;
        }
    }
}