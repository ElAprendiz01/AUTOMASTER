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
    public class CD_Financiamiento
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR FINANCIAMIENTOS
        public List<CE_Financiamiento> ListarFinanciamientos()
        {
            var lista = new List<CE_Financiamiento>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarFinanciamientos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Financiamiento()
                                {
                                    Id_Financiamiento = Convert.ToInt32(dt["Id_Financiamiento"]),
                                    Id_Venta = Convert.ToInt32(dt["Id_Venta"]),
                                    Id_Cliente = Convert.ToInt32(dt["Id_Cliente"]),
                                    Cliente = dt["Cliente"].ToString(),
                                    Monto = Convert.ToDecimal(dt["Monto"]),
                                    Plazo_Meses = Convert.ToInt32(dt["Plazo_Meses"]),
                                    // Validación estricta de Nulos para tipos valor
                                    Tasa_Interes = dt["Tasa_Interes"] != DBNull.Value ? Convert.ToDecimal(dt["Tasa_Interes"]) : (decimal?)null,
                                    Fecha_Inicio = Convert.ToDateTime(dt["Fecha_Inicio"]),
                                    Fecha_Cancelacion = dt["Fecha_Cancelacion"] != DBNull.Value ? Convert.ToDateTime(dt["Fecha_Cancelacion"]) : (DateTime?)null,
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los financiamientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Financiamiento
        public void InsertarFinanciamiento(CE_Financiamiento _ceFin)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarFinanciamiento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _ceFin.Id_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Id_Cliente", _ceFin.Id_Cliente));
                        cmd.Parameters.Add(new SqlParameter("@Monto", _ceFin.Monto));
                        cmd.Parameters.Add(new SqlParameter("@Plazo_Meses", _ceFin.Plazo_Meses));
                        // Inyección condicional de DBNull
                        cmd.Parameters.Add(new SqlParameter("@Tasa_Interes", _ceFin.Tasa_Interes ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Inicio", _ceFin.Fecha_Inicio));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Cancelacion", _ceFin.Fecha_Cancelacion ?? (object)DBNull.Value));

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

        #region Actualizar Financiamiento
        public void ActualizarFinanciamiento(CE_Financiamiento _ceFin)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarFinanciamiento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Financiamiento", _ceFin.Id_Financiamiento));
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _ceFin.Id_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Id_Cliente", _ceFin.Id_Cliente));
                        cmd.Parameters.Add(new SqlParameter("@Monto", _ceFin.Monto));
                        cmd.Parameters.Add(new SqlParameter("@Plazo_Meses", _ceFin.Plazo_Meses));
                        cmd.Parameters.Add(new SqlParameter("@Tasa_Interes", _ceFin.Tasa_Interes ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Inicio", _ceFin.Fecha_Inicio));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Cancelacion", _ceFin.Fecha_Cancelacion ?? (object)DBNull.Value));

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

        #region Eliminar Financiamiento
        public void EliminarFinanciamiento(CE_Financiamiento _ceFin)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPEliminarFinanciamiento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Financiamiento", _ceFin.Id_Financiamiento));
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