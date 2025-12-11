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
