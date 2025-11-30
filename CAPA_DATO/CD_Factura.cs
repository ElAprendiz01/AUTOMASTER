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
    public class CD_Factura
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR FACTURAS
        public List<CE_Factura> ListarFacturas()
        {
            var lista = new List<CE_Factura>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarFacturas", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Factura()
                                {
                                    Id_Factura = Convert.ToInt32(dt["Id_Factura"]),
                                    Id_Venta = Convert.ToInt32(dt["Id_Venta"]),
                                    Fecha_Venta = Convert.ToDateTime(dt["Fecha_Venta"]),
                                    Id_Cliente = Convert.ToInt32(dt["Id_Cliente"]),
                                    Nombre_Cliente = dt["Nombre_Cliente"].ToString(),
                                    DNI_Cliente = dt["DNI_Cliente"].ToString(),

                                    // Mapeo de columnas nullable (Left Joins y campos opcionales)
                                    Id_Pago = dt["Id_Pago"] != DBNull.Value ? Convert.ToInt32(dt["Id_Pago"]) : (int?)null,
                                    Metodo_Pago = dt["Metodo_Pago"] != DBNull.Value ? dt["Metodo_Pago"].ToString() : null,
                                    Fecha_Pago = dt["Fecha_Pago"] != DBNull.Value ? Convert.ToDateTime(dt["Fecha_Pago"]) : (DateTime?)null,

                                    Id_Financiamiento = dt["Id_Financiamiento"] != DBNull.Value ? Convert.ToInt32(dt["Id_Financiamiento"]) : (int?)null,
                                    Plazo_Meses = dt["Plazo_Meses"] != DBNull.Value ? Convert.ToInt32(dt["Plazo_Meses"]) : (int?)null,

                                    Numero_Factura = dt["Numero_Factura"].ToString(),
                                    Fecha_Emision = Convert.ToDateTime(dt["Fecha_Emision"]),

                                    Subtotal = dt["Subtotal"] != DBNull.Value ? Convert.ToDecimal(dt["Subtotal"]) : (decimal?)null,
                                    IVA = dt["IVA"] != DBNull.Value ? Convert.ToDecimal(dt["IVA"]) : (decimal?)null,
                                    Total = dt["Total"] != DBNull.Value ? Convert.ToDecimal(dt["Total"]) : (decimal?)null
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Factura
        public void InsertarFactura(CE_Factura _ceFactura)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarFactura", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _ceFactura.Id_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Id_Pago", _ceFactura.Id_Pago ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Id_Financiamiento", _ceFactura.Id_Financiamiento ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Numero_Factura", _ceFactura.Numero_Factura));
                        cmd.Parameters.Add(new SqlParameter("@Subtotal", _ceFactura.Subtotal ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@IVA", _ceFactura.IVA ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Total", _ceFactura.Total ?? (object)DBNull.Value));

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

        #region Actualizar Factura
        public void ActualizarFactura(CE_Factura _ceFactura)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarFactura", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Id_Factura", _ceFactura.Id_Factura));
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _ceFactura.Id_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Id_Pago", _ceFactura.Id_Pago ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Id_Financiamiento", _ceFactura.Id_Financiamiento ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Numero_Factura", _ceFactura.Numero_Factura));
                        cmd.Parameters.Add(new SqlParameter("@Subtotal", _ceFactura.Subtotal ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@IVA", _ceFactura.IVA ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Total", _ceFactura.Total ?? (object)DBNull.Value));

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

        #region Eliminar Factura
        public void EliminarFactura(CE_Factura _ceFactura)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPEliminarFactura", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Factura", _ceFactura.Id_Factura));
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
