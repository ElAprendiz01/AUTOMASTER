using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CAPA_DATO.CD_ContactoProveedor;

namespace CAPA_DATO
{
    public class CD_ContactoProveedor
    {
       
            CD_CONEXION _CONEXION = new CD_CONEXION();

            public List<CE_ContactoProveedor> ListarContactoProveedor()
            {
                var lista = new List<CE_ContactoProveedor>();
                try
                {
                    using (SqlConnection con = _CONEXION.AbrirConexion())
                    {
                        using (SqlCommand cmd = new SqlCommand("SPlistarContactoProveedor", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            using (SqlDataReader dt = cmd.ExecuteReader())
                            {
                                while (dt.Read())
                                {
                                    lista.Add(new CE_ContactoProveedor()
                                    {
                                        Id_Proveedor = Convert.ToInt32(dt["Id_Proveedor"]),
                                        Nombre_Empresa = dt["Nombre_Empresa"].ToString(),
                                        RUC_Empresa = dt["RUC_Empresa"].ToString(),
                                        Id_Contacto = Convert.ToInt32(dt["Id_Contacto"]),
                                        Contacto = dt["Contacto"].ToString(),
                                        ContactoPrincipal = Convert.ToBoolean(dt["ContactoPrincipal"]),
                                        ID_Representante = dt["ID_Representante"] != DBNull.Value ? (int?)Convert.ToInt32(dt["ID_Representante"]) : null,
                                        Primer_Nombre = dt["Primer_Nombre"].ToString(),
                                        Segundo_Nombre = dt["Segundo_Nombre"].ToString(),
                                        Primer_Apellido = dt["Primer_Apellido"].ToString(),
                                        Segundo_Apellido = dt["Segundo_Apellido"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar Contacto-Proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return lista;
            }

            public void InsertarContactoProveedor(CE_ContactoProveedor _ce)
            {
                try
                {
                    using (SqlConnection con = _CONEXION.AbrirConexion())
                    {
                        using (SqlCommand cmd = new SqlCommand("SPinsertarProveedorContactos", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", _ce.Id_Proveedor));
                            cmd.Parameters.Add(new SqlParameter("@Id_Contacto", _ce.Id_Contacto));
                            cmd.Parameters.Add(new SqlParameter("@Principal", _ce.ContactoPrincipal));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void ActualizarContactoProveedor(CE_ContactoProveedor _ce)
            {
                try
                {
                    using (SqlConnection con = _CONEXION.AbrirConexion())
                    {
                        using (SqlCommand cmd = new SqlCommand("SPActualizarProveedorContactos", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@Id_Proveedor", _ce.Id_Proveedor));
                            cmd.Parameters.Add(new SqlParameter("@Id_Contacto", _ce.Id_Contacto));
                            cmd.Parameters.Add(new SqlParameter("@Principal", _ce.ContactoPrincipal));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }
}
