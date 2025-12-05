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
    public class CD_Taller
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR TALLER
        public List<CE_Taller> ListarTaller()
        {
            var lista = new List<CE_Taller>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarTaller", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Taller()
                                {
                                    Id_Taller = Convert.ToInt32(dt["Id_Taller"]),
                                    Id_Vehiculo = Convert.ToInt32(dt["Id_Vehiculo"]),
                                    Vehiculo_Descripcion = dt["Vehiculo_Descripcion"].ToString(),
                                    Serie_Chasis = dt["Serie_Chasis"].ToString(),
                                    Descripcion_Trabajo = dt["Descripcion_Trabajo"].ToString(),
                                    Fecha_Ingreso = Convert.ToDateTime(dt["Fecha_Ingreso"]),

                                    // Mapeo de columnas nullable
                                    Fecha_Salida = dt["Fecha_Salida"] != DBNull.Value ? Convert.ToDateTime(dt["Fecha_Salida"]) : (DateTime?)null,
                                    Costo = dt["Costo"] != DBNull.Value ? Convert.ToDecimal(dt["Costo"]) : (decimal?)null,
                                    Id_Responsable = dt["Id_Responsable"] != DBNull.Value ? Convert.ToInt32(dt["Id_Responsable"]) : (int?)null,

                                    Nombre_Responsable = dt["Nombre_Responsable"] != DBNull.Value ? dt["Nombre_Responsable"].ToString() : null,
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Taller: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Taller
        public void InsertarTaller(CE_Taller _ceTaller)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarTaller", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ceTaller.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion_Trabajo", _ceTaller.Descripcion_Trabajo));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", _ceTaller.Fecha_Ingreso));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Salida", _ceTaller.Fecha_Salida ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Costo", _ceTaller.Costo ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Responsable", _ceTaller.Id_Responsable ?? (object)DBNull.Value));

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

        #region Actualizar Taller
        public void ActualizarTaller(CE_Taller _ceTaller)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarTaller", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Id_Taller", _ceTaller.Id_Taller));
                        cmd.Parameters.Add(new SqlParameter("@Id_Vehiculo", _ceTaller.Id_Vehiculo));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion_Trabajo", _ceTaller.Descripcion_Trabajo));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", _ceTaller.Fecha_Ingreso));
                        cmd.Parameters.Add(new SqlParameter("@Fecha_Salida", _ceTaller.Fecha_Salida ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Costo", _ceTaller.Costo ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@Responsable", _ceTaller.Id_Responsable ?? (object)DBNull.Value));

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

        #region Eliminar Taller
        public void EliminarTaller(CE_Taller _ceTaller)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPEliminarTaller", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Taller", _ceTaller.Id_Taller));
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
