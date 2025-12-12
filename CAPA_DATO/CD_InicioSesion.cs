using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATO
{
    public class CD_InicioSesion
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        // Método para buscar al usuario y traer su HASH
        public DataTable D_User(CE_InicioSesion objs)
        {
            
            using (SqlConnection con = _CONEXION.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Logueo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Usuario", objs.Usuario);

                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    return dt;
                }
            }
        }
    }
}