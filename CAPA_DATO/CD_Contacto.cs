using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_DATO
{
    public class CD_Contactos
    {
        // instanciamos la capa de conexion
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR CONTACTOS
        // creo el metod de listar contactos
        public List<CE_Contacto> ListarContactos()
        {
            var lista = new List<CE_Contacto>();
            // hago uso del try  catch
            try
            {
                // hago uso del usin par ala conexio 
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para lo del sp
                    using (SqlCommand cmd = new SqlCommand("SPlistarContacto", con))
                    {
                        // le indico que es un storedprocedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        // hago uso de otro using para el sqldatareader
                        using (SqlDataReader dt = cmd.ExecuteReader())
                        {
                            // utilizo un ciclo while para recorrer la lista 
                            while (dt.Read())
                            {
                                // me encargo de llenar la variable que cree para la lista 
                                lista.Add(new CE_Contacto()
                                {
                                    Id_Persona = Convert.ToInt32(dt["Id_Persona"]),
                                    Primer_Nombre = dt["Primer_Nombre"].ToString(),
                                    Primer_Apellido = dt["Primer_Apellido"].ToString(),
                                    Id_Contacto = Convert.ToInt32(dt["Id_Contacto"]),
                                    Id_Tipo_Contacto = Convert.ToInt32(dt["Id_Tipo_Contacto"]),
                                    Id_Estado = Convert.ToInt32(dt["Id_Estado"]),
                                    Contacto = dt["Contacto"].ToString(),
                                    TIPO_CONTACTO = dt["TIPO_CONTACTO"].ToString(), // Mapeado del alias en el SP
                                    Principal = Convert.ToBoolean(dt["Principal"]),
                                    Fecha_Creacion = Convert.ToDateTime(dt["Fecha_Creacion"]),
                                    Fecha_Modificacion = dt.IsDBNull(dt.GetOrdinal("Fecha_Modificacion")) ? (DateTime?)null : Convert.ToDateTime(dt["Fecha_Modificacion"]),
                                    Estado = dt["Estado"].ToString()
                                    // NOTA: Id_Tipo_Contacto y Id_Estado no se mapean aquí porque su SP Listar no los retorna.
                                });
                            }
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                //le mando un messagebox warning para el error 
                MessageBox.Show("Error al listar los contactos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            return lista;
        }

        #endregion
        #region Insertar Contacto 
        // creo el void para insertat 
        public void InsertarContacto(CE_Contacto _ceCto)
        {
            //hag uso del try 
            try
            {
                // hago uso del using para la conexio 
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para el nombre sp 
                    using (SqlCommand cmd = new SqlCommand("SPinsertarContacto", con))
                    {
                        // le indico que es un storeprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // los parametros de mi sp 
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceCto.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Contacto", _ceCto.Id_Tipo_Contacto));
                        cmd.Parameters.Add(new SqlParameter("@Contacto", _ceCto.Contacto));
                        cmd.Parameters.Add(new SqlParameter("@Principal", _ceCto.Principal));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceCto.Id_Estado));
                        // el boton de enviar el ExecuteNonQuery
                        cmd.ExecuteNonQuery();


                    }

                }

            }
            catch (Exception ex)
            {
                //messagebox de error
                MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        #endregion

        #region Actualizar Contacto 
        public void ActualizarContacto(CE_Contacto _ceCto)
        {
            //hag uso del try 
            try
            {
                // hago uso del using para la conexio 
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para el nombre sp 
                    using (SqlCommand cmd = new SqlCommand("SPactualizarContacto", con))
                    {
                        // le indico que es un storeprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // los parametros de mi sp 
                        cmd.Parameters.Add(new SqlParameter("@Id_Contacto", _ceCto.Id_Contacto));
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceCto.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Contacto", _ceCto.Id_Tipo_Contacto));
                        cmd.Parameters.Add(new SqlParameter("@Contacto", _ceCto.Contacto));
                        cmd.Parameters.Add(new SqlParameter("@Principal", _ceCto.Principal));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceCto.Id_Estado));
                        // el boton 'no es que sea un boton litealmente es solo un decir jajaj' de enviar el ExecuteNonQuery
                        cmd.ExecuteNonQuery();


                    }

                }

            }
            catch (Exception ex)
            {
                //messagebox de error
                MessageBox.Show($"El sistema detecta {ex.Message}", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion 

       

    }
}