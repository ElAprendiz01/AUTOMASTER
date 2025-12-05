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
    public class cd_servicioDeVehiculos
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR SERVICIOS
        public List<CE_ServicioDeVehiculosr> ListarServiciosVehiculos()
        {
            var lista = new List<CE_ServicioDeVehiculosr>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarServiciosVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_ServicioDeVehiculosr()
                                {
                                    Id_Servicio = Convert.ToInt32(dt["Id_Servicio"]),
                                    Id_Vehiculo = Convert.ToInt32(dt["Id_Vehiculo"]),
                                    Vehiculo_Info = dt["Vehiculo_Info"].ToString(),
                                    Id_Tipo_Servicio = Convert.ToInt32(dt["Id_Tipo_Servicio"]),
                                    Tipo_Servicio = dt["Tipo_Servicio"].ToString(),
                                    Fecha_Servicio = Convert.ToDateTime(dt["Fecha_Servicio"]),
                                    Costo = Convert.ToDecimal(dt["Costo"]),
                                    Id_Empleado = dt["Id_Empleado"] != DBNull.Value ? Convert.ToInt32(dt["Id_Empleado"]) : 0,
                                    Nombre_Mecanico = dt["Nombre_Mecanico"].ToString(),
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
                MessageBox.Show("Error al listar los servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Servicio
        public void InsertarServicio(CE_ServicioDeVehiculosr _ceServ)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarServiciosVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ceServ.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Servicio", _ceServ.Id_Tipo_Servicio));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Servicio", _ceServ.Fecha_Servicio));
                        cmd.Parameters.Add(new SqlParameter("@Costo", _ceServ.Costo));
                        cmd.Parameters.Add(new SqlParameter("@Realizado_por", _ceServ.Id_Empleado));
                        cmd.Parameters.Add(new SqlParameter("@Observaciones", _ceServ.Observaciones));
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

        #region Actualizar Servicio
        public void ActualizarServicio(CE_ServicioDeVehiculosr _ceServ)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarServiciosVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Servicio", _ceServ.Id_Servicio));
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ceServ.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Servicio", _ceServ.Id_Tipo_Servicio));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Servicio", _ceServ.Fecha_Servicio));
                        cmd.Parameters.Add(new SqlParameter("@Costo", _ceServ.Costo));
                        cmd.Parameters.Add(new SqlParameter("@Realizado_por", _ceServ.Id_Empleado));
                        cmd.Parameters.Add(new SqlParameter("@Observaciones", _ceServ.Observaciones));
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

        #region Eliminar Servicio
        public void EliminarServicio(CE_ServicioDeVehiculosr _ceServ)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPEliminarServiciosVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Servicio", _ceServ.Id_Servicio));
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
