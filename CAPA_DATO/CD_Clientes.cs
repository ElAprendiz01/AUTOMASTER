using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CAPA_DATO
{
    public class CD_Clientes
    {
        // Instanciamos la capa de conexion
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR CLIENTES
        public List<CE_clientes> ListarClientes()
        {
            var lista = new List<CE_clientes>();
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPListarClientes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            while (dt.Read())
                            {
                                lista.Add(new CE_clientes()
                                {
                                    // Mapeo ID y Datos propios de la tabla Clientes
                                    Id_Cliente = Convert.ToInt32(dt["Id_Cliente"]),
                                    Id_Persona = Convert.ToInt32(dt["Id_Persona"]),
                                    Fecha_Registro = Convert.ToDateTime(dt["Fecha_Registro"]),
                                    Activo = Convert.ToBoolean(dt["Activo"]),

                                    // Mapeo Datos Extendidos (Vienen del INNER JOIN con Datos Personales)
                                    Primer_Nombre = dt["Primer_Nombre"].ToString(),
                                    Segundo_Nombre = dt["Segundo_Nombre"].ToString(),
                                    Primer_Apellido = dt["Primer_Apellido"].ToString(),
                                    Segundo_Apellido = dt["Segundo_Apellido"].ToString(),
                                    DNI = dt["DNI"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return lista;
        }
        #endregion

        #region Insertar Cliente
        public void InsertarCliente(CE_clientes _ceCli)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPInsertarClientes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametros del SP
                        // Nota: Fecha_Registro y Activo tienen defaults en BD, solo enviamos Id_Persona
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceCli.Id_Persona));

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

        #region Actualizar Cliente
        public void ActualizarCliente(CE_clientes _ceCli)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPActualizarClientes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametros del SP
                        cmd.Parameters.Add(new SqlParameter("@Id_Cliente", _ceCli.Id_Cliente));
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceCli.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceCli.Activo));

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

        #region Eliminar Cliente
        // Agregado por Pennywise para completar el ciclo de vida del SP generado
        public void EliminarCliente(CE_clientes _ceCli)
        {
            try
            {
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SPEliminarClientes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Id_Cliente", _ceCli.Id_Cliente));

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