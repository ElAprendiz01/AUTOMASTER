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
    public class CD_Vehiculos
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR VEHICULOS
        public List<CE_Vehiculo> ListarVehiculos()
        {
            var lista = new List<CE_Vehiculo>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Vehiculo()
                                {
                                    Id_Vehiculo = Convert.ToInt32(dt["Id_Vehiculo"]),
                                    Id_Proveedor = Convert.ToInt32(dt["Id_Proveedor"]),
                                    Marca = dt["Marca"].ToString(),
                                    Modelo = dt["Modelo"].ToString(),
                                    Año = Convert.ToInt32(dt["Año"]),
                                    Serie_Chasis = dt["Serie_Chasis"].ToString(),
                                    Serie_Motor = dt["Serie_Motor"].ToString(),
                                    Precio = Convert.ToDecimal(dt["Precio"]),
                                    Id_Estado = Convert.ToInt32(dt["Id_Estado"]),
                                    Nombre_Estado = dt["Nombre_Estado"].ToString(),
                                    Fecha_Ingreso_Pais = dt["Fecha_Ingreso_Pais"] != DBNull.Value ? Convert.ToDateTime(dt["Fecha_Ingreso_Pais"]) : (DateTime?)null,
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"]),
                                    Proveedor = dt["Proveedor"].ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Vehiculo
        public void InsertarVehiculo(CE_Vehiculo _ceVeh)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPinsertarVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", _ceVeh.Id_Proveedor));
                        cmd.Parameters.Add(new SqlParameter("@Marca", _ceVeh.Marca));
                        cmd.Parameters.Add(new SqlParameter("@Modelo", _ceVeh.Modelo));
                        cmd.Parameters.Add(new SqlParameter("@Anio", _ceVeh.Anio));
                        cmd.Parameters.Add(new SqlParameter("@Serie_Chasis", _ceVeh.Serie_Chasis));
                        cmd.Parameters.Add(new SqlParameter("@Serie_Motor", _ceVeh.Serie_Motor));
                        cmd.Parameters.Add(new SqlParameter("@Precio", _ceVeh.Precio));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceVeh.Id_Estado));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso_Pais", _ceVeh.Fecha_Ingreso_Pais));
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

        #region Actualizar Vehiculo
        public void ActualizarVehiculo(CE_Vehiculo _ceVeh)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ceVeh.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", _ceVeh.Id_Proveedor));
                        cmd.Parameters.Add(new SqlParameter("@Marca", _ceVeh.Marca));
                        cmd.Parameters.Add(new SqlParameter("@Modelo", _ceVeh.Modelo));
                        cmd.Parameters.Add(new SqlParameter("@Anio", _ceVeh.Anio));
                        cmd.Parameters.Add(new SqlParameter("@Serie_Chasis", _ceVeh.Serie_Chasis));
                        cmd.Parameters.Add(new SqlParameter("@Serie_Motor", _ceVeh.Serie_Motor));
                        cmd.Parameters.Add(new SqlParameter("@Precio", _ceVeh.Precio));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceVeh.Id_Estado));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso_Pais", _ceVeh.Fecha_Ingreso_Pais));
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

        #region Eliminar Vehiculo
        public void EliminarVehiculo(CE_Vehiculo _ceVeh)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPeliminarVehiculos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ceVeh.Id_Vehiculo));
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
