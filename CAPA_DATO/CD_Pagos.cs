using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CAPA_DATO
{
    public class CD_Pagos
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR PAGOS
        public List<CE_Pagos> ListarPagos()
        {
            var lista = new List<CE_Pagos>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarPagos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Pagos()
                                {
                                    Id_Pago = Convert.ToInt32(dt["Id_Pago"]),
                                    // Validacion estricta de nulos para claves foraneas
                                    Id_Venta = dt["Id_Venta"] != DBNull.Value ? Convert.ToInt32(dt["Id_Venta"]) : (int?)null,
                                    Fecha_Venta = dt["Fecha_Venta"] != DBNull.Value ? Convert.ToDateTime(dt["Fecha_Venta"]) : (DateTime?)null,
                                    Id_Financiamiento = dt["Id_Financiamiento"] != DBNull.Value ? Convert.ToInt32(dt["Id_Financiamiento"]) : (int?)null,
                                    Fecha_Inicio_Financiamiento = dt["Fecha_Inicio_Financiamiento"] != DBNull.Value ? Convert.ToDateTime(dt["Fecha_Inicio_Financiamiento"]) : (DateTime?)null,

                                    Fecha_Pago = Convert.ToDateTime(dt["Fecha_Pago"]),
                                    Monto = Convert.ToDecimal(dt["Monto"]),
                                    Metodo_Pago = dt["Metodo_Pago"].ToString(),
                                    Observaciones = dt["Observaciones"] != DBNull.Value ? dt["Observaciones"].ToString() : null,
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Pago
        public void InsertarPago(CE_Pagos _cePagos)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarPago", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Uso de (object)?? DBNull.Value para manejar enteros nuleables correctamente
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _cePagos.Id_Venta ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Id_Financiamiento", _cePagos.Id_Financiamiento ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Pago", _cePagos.Fecha_Pago));
                        cmd.Parameters.Add(new SqlParameter("@Monto", _cePagos.Monto));
                        cmd.Parameters.Add(new SqlParameter("@Metodo_Pago", _cePagos.Metodo_Pago));
                        cmd.Parameters.Add(new SqlParameter("@Observaciones", _cePagos.Observaciones ?? (object)DBNull.Value));

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

        #region Actualizar Pago
        public void ActualizarPago(CE_Pagos _cePagos)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarPago", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Pago", _cePagos.Id_Pago));
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _cePagos.Id_Venta ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Id_Financiamiento", _cePagos.Id_Financiamiento ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Pago", _cePagos.Fecha_Pago));
                        cmd.Parameters.Add(new SqlParameter("@Monto", _cePagos.Monto));
                        cmd.Parameters.Add(new SqlParameter("@Metodo_Pago", _cePagos.Metodo_Pago));
                        cmd.Parameters.Add(new SqlParameter("@Observaciones", _cePagos.Observaciones ?? (object)DBNull.Value));

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

        #region Eliminar Pago
        public void EliminarPago(CE_Pagos _cePagos)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // Asumo SPEliminarPago (singular) basado en el patron de Insertar/Actualizar
                    using (SqlCommand cmd = new SqlCommand("SPEliminarPago", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Pago", _cePagos.Id_Pago));
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