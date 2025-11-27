using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
namespace CAPA_DATO
{
    public class CD_Direcciones
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR DIRECCIONES
        public List<CE_Direcciones> ListarDirecciones()
        {
            var lista = new List<CE_Direcciones>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPlistarDireccioens", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Direcciones()
                                {
                                    Id_Persona = Convert.ToInt32(dt["Id_Persona"]),
                                    Primer_Nombre = dt["Primer_Nombre"].ToString(),
                                    Primer_Apellido = dt["Primer_Apellido"].ToString(),
                                    Id_Direccion = Convert.ToInt32(dt["Id_Direccion"]),
                                    Direccion = dt["Direccion"].ToString(),
                                    Ciudad = dt["Ciudad"].ToString(),
                                    Departamento = dt["Departamento"].ToString(),
                                    Principal = Convert.ToBoolean(dt["Principal"]),
                                    Id_Estado = Convert.ToInt32(dt["Id_Estado"]),
                                    Estado = dt["Estado"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las direcciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return lista;
        }
        #endregion

        #region Insertar Direcciones
        public void InsertarDirecciones(CE_Direcciones _ceDir)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPinsertarDirecciones", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceDir.Id_Persona)); 
                        cmd.Parameters.Add(new SqlParameter("@Direccion", _ceDir.Direccion));
                        cmd.Parameters.Add(new SqlParameter("@Ciudad", _ceDir.Ciudad));
                        cmd.Parameters.Add(new SqlParameter("@Departamento", _ceDir.Departamento));
                        cmd.Parameters.Add(new SqlParameter("@Principal", _ceDir.Principal));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceDir.Id_Estado));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Actualizar Direcciones
        public void ActualizarDirecciones(CE_Direcciones _ceDir)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPactualizarDirecciones", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Direccion", _ceDir.Id_Direccion));
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceDir.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Direccion", _ceDir.Direccion));
                        cmd.Parameters.Add(new SqlParameter("@Ciudad", _ceDir.Ciudad));
                        cmd.Parameters.Add(new SqlParameter("@Departamento", _ceDir.Departamento));
                        cmd.Parameters.Add(new SqlParameter("@Principal", _ceDir.Principal));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceDir.Id_Estado));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
