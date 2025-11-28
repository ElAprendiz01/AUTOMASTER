using CAPA_DATO;
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
    public class CD_Ventas
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR VENTAS
        public List<CE_Ventas> ListarVentas()
        {
            var lista = new List<CE_Ventas>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarVentas", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Ventas()
                                {
                                    Id_Venta = Convert.ToInt32(dt["Id_Venta"]),
                                    Id_Vehiculo = Convert.ToInt32(dt["Id_Vehiculo"]),
                                    Vehiculo = dt["Vehiculo"].ToString(),
                                    Id_Cliente = Convert.ToInt32(dt["Id_Cliente"]),
                                    Nombre_Cliente = dt["Nombre_Cliente"].ToString(),
                                    Id_Empleado = Convert.ToInt32(dt["Id_Empleado"]),
                                    Nombre_Empleado = dt["Nombre_Empleado"].ToString(),
                                    Fecha_Venta = Convert.ToDateTime(dt["Fecha_Venta"]),
                                    Precio_Venta = Convert.ToDecimal(dt["Precio_Venta"]),
                                    Observaciones = dt["Observaciones"].ToString(),
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Venta
        public void InsertarVenta(CE_Ventas _ce)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarVentas", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ce.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Cliente", _ce.Id_Cliente));
                        cmd.Parameters.Add(new SqlParameter("@Id_Empleado", _ce.Id_Empleado));
                        cmd.Parameters.Add(new SqlParameter("@Precio_Venta", _ce.Precio_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Observaciones", _ce.Observaciones));
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

        #region Actualizar Venta
        public void ActualizarVenta(CE_Ventas _ce)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarVenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _ce.Id_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ce.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Cliente", _ce.Id_Cliente));
                        cmd.Parameters.Add(new SqlParameter("@Id_Empleado", _ce.Id_Empleado));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", _ce.Fecha_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Precio_Venta", _ce.Precio_Venta));
                        cmd.Parameters.Add(new SqlParameter("@Observaciones", _ce.Observaciones));
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

        #region Eliminar Venta
        public void EliminarVenta(CE_Ventas _ce)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPEliminarVenta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Venta", _ce.Id_Venta));
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
