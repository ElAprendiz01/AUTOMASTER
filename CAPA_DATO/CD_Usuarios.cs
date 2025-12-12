
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

using Microsoft.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATO
{
    public class CD_Usuarios
    {

        CD_CONEXION _CONEXION = new CD_CONEXION();

        // Método para Registrar
        public void RegistrarUsuario(string usuario, string hash, int idRol, int idPersona)
        {
            using (SqlConnection con = _CONEXION.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena_Hash", hash); 
                    cmd.Parameters.AddWithValue("@Id_Rol", idRol);

                    // Enviamos el ID de la persona seleccionada
                    cmd.Parameters.AddWithValue("@Id_Persona", idPersona);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. Método para llenar el ComboBox de roles
        public DataTable ListarRoles()
        {
            using (SqlConnection con = _CONEXION.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SP_ListarRoles", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}

        // instanciamos la capa de conexion
        CD_CONEXION _CONEXION = new CD_CONEXION();

        public DataTable D_User(CE_Usuarios objU)
        {

            // hago uso del usin par ala conexio 
            using (SqlConnection con = _CONEXION.AbrirConexion())
            {
                // hago uso de otro using para lo del sp
                using (SqlCommand cmd = new SqlCommand("falta sp", con))
                {
                   cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(@"Usuario", objU.User);
                    cmd.Parameters.AddWithValue(@"Contrasena_Hash", objU.Pass);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    return dt;

                }

            }

        }

    }

   
}
