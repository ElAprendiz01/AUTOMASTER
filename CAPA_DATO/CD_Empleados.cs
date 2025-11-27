using CAPA_ENTIDAD;
using Microsoft.Data;
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
    public class CD_Empleados
    {
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR EMPLEADOS
        public List<CE_Empelados> ListarEmpleados()
        {
            var lista = new List<CE_Empelados>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarEmpleados", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_Empelados()
                                {
                                    Id_Empleado = Convert.ToInt32(dt["Id_Empleado"]),
                                    Id_Persona = Convert.ToInt32(dt["Id_Persona"]),
                                    Nombre_Completo = dt["Nombre_Completo"].ToString(),
                                    DNI = dt["DNI"].ToString(),
                                    Id_Cargo = Convert.ToInt32(dt["Id_Cargo"]),
                                    Cargo = dt["Cargo"].ToString(),
                                    Id_Area = Convert.ToInt32(dt["Id_Area"]),
                                    Area = dt["Area"].ToString(),
                                    Activo = Convert.ToBoolean(dt["Activo"]),
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return lista;
        }
        #endregion

        #region Insertar Empleado
        public void InsertarEmpleado(CE_Empelados _ceEmp)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPinsertarEmpleados", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceEmp.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Id_Cargo", _ceEmp.Id_Cargo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Area", _ceEmp.Id_Area));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceEmp.Activo));
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

        #region Actualizar Empleado
        public void ActualizarEmpleado(CE_Empelados _ceEmp)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarEmpleados", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Empleado", _ceEmp.Id_Empleado));
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceEmp.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Id_Cargo", _ceEmp.Id_Cargo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Area", _ceEmp.Id_Area));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceEmp.Activo));
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
