using System.Data;
using CAPA_DATO;
using BCrypt.Net; // Asegúrate de tener el using

namespace CAPA_NEGOCIO
{
    public class CN_Usuarios
    {
        private CD_Usuarios objDato = new CD_Usuarios();

        public DataTable ObtenerRoles()
        {
            return objDato.ListarRoles();
        }

        public void InsertarUsuario(string usuario, string clavePlana, int idRol, int idPersona)
        {
            //  GENERA HASH 
            string hashSeguro = BCrypt.Net.BCrypt.HashPassword(clavePlana);

            //  ENVIA A CAPA DE DATOS
            objDato.RegistrarUsuario(usuario, hashSeguro, idRol, idPersona);
        }
    }
}