using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DATO
{
    public class CD_Proveedores
    {
        // instanciamos la capa de conexion
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR PROVEEDORES
        // creo el metodo de listar proveedores
        public List<CE_Proveedores> ListarProveedores()
        {
            var lista = new List<CE_Proveedores>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPlistarProveedores", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Proveedores()
                                {
                                    ID_Representante = Convert.ToInt32(dt["ID_Representante"]),
                                    Primer_Nombre = dt["Primer_Nombre"].ToString(),
                                    Primer_Apellido = dt["Primer_Apellido"].ToString(),
                                    Id_Proveedor = Convert.ToInt32(dt["Id_Proveedor"]),
                                    Nombre_Empresa = dt["Nombre_Empresa"].ToString(),
                                    RUC_Empresa = dt["RUC_Empresa"].ToString(),
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"]),
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
                MessageBox.Show("Error al listar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return lista;
        }

        #endregion

        #region Insertar Proveedor 
        // creo el void para insertat 
        public void InsertarProveedor(CE_Proveedores _ceProv)
        {
            //hag uso del try 
            try
            {
                // hago uso del using para la conexio 
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para el nombre sp 
                    using (SqlCommand cmd = new SqlCommand("SPInsertarProveedores", con))
                    {
                        // le indico que es un storeprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // los parametros de mi sp 
                        // Nota: El SP pide @Representante, la entidad tiene Id_Representante
                        cmd.Parameters.Add(new SqlParameter("@Representante", _ceProv.Representante ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Nombre_Empresa", _ceProv.Nombre_Empresa));
                        cmd.Parameters.Add(new SqlParameter("@RUC_Empresa", _ceProv.RUC_Empresa));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceProv.Id_Estado));

                        // el boton de enviar el ExecuteNonQuery
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                //messagebox de error
                MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        #endregion

        #region Actualizar Proveedor 
        public void ActualizarProveedor(CE_Proveedores _ceProv)
        {
            //hag uso del try 
            try
            {
                // hago uso del using para la conexio 
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para el nombre sp 
                    using (SqlCommand cmd = new SqlCommand("SPActualizarProveedores", con))
                    {
                        // le indico que es un storeprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // los parametros de mi sp 
                        cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", _ceProv.Id_Proveedor));
                        cmd.Parameters.Add(new SqlParameter("@Representante", _ceProv.Representante ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Nombre_Empresa", _ceProv.Nombre_Empresa));
                        cmd.Parameters.Add(new SqlParameter("@RUC_Empresa", _ceProv.RUC_Empresa));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceProv.Id_Estado));

                        // el boton 'no es que sea un boton litealmente es solo un decir jajaj' de enviar el ExecuteNonQuery
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                //messagebox de error
                MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

    }
}
