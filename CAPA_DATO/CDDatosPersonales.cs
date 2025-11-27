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
    public class CDDatosPersonales
    {
        // instanciamos la capa de conexion}
        CD_CONEXION _CONEXION = new CD_CONEXION();

        #region METODO LISTAR DATOS PERSONALES
        // creo el metod de listar datos personales
        public List<CEDatosPersonales> ListarDatosPersonales()
        {
            var lista = new List<CEDatosPersonales>();
            // hago uso del try  catch
            try
            {
                // hago uso del usin par ala conexio 
                using( SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para lo del sp
                    using( SqlCommand cmd = new SqlCommand("SPListarDatosPersonales", con))
                    {
                        // le indico que es un storedprocedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        // hago uso de otro using para el sqldatareader
                        using( SqlDataReader dt = cmd.ExecuteReader())
                        {
                            // utilizo un ciclo while para recorrer la lista 
                            while (dt.Read())
                            {
                                // me encargo de llenar la variable que cree para la lista 
                                lista.Add(new CEDatosPersonales()
                                {
                                    Id_Persona = Convert.ToInt32(dt["Id_Persona"]),
                                    Primer_Nombre = dt["Primer_Nombre"].ToString(),
                                    Segundo_Nombre = dt["Segundo_Nombre"].ToString(),
                                    Primer_Apellido = dt["Primer_Apellido"].ToString(),
                                    Segundo_Apellido = dt["Segundo_Apellido"].ToString(),
                                    Id_Genero = Convert.ToInt32(dt["Id_Genero"]),
                                    Genero = dt["Genero"].ToString(),
                                    Id_Tipo_DNI = Convert.ToInt32(dt["Id_Tipo_DNI"]),
                                    TipoDNI = dt["TipoDNI"].ToString(),
                                    DNI = dt["DNI"].ToString(),
                                    Fecha_Creacion = Convert.ToDateTime(dt["Fecha_Creacion"]),
                                    Fecha_Modificacion = dt.IsDBNull(dt.GetOrdinal("Fecha_Modificacion")) ? (DateTime?)null : Convert.ToDateTime(dt["Fecha_Modificacion"]),
                                    Id_Estado = Convert.ToInt32(dt["Id_Estado"]),
                                    Estado = dt["Estado"].ToString()
                                });
                            }
                        }
                    }
                }
               
            }

            catch (Exception ex)
            {
                //le mando un messagebox warning para el error 
                MessageBox.Show("Error al listar los datos personales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            return lista;
        }

        #endregion
        #region Insertar Datos personales 
        // creo el void para insertat 
        public void insertarDatosPersonales( CEDatosPersonales _ceDtp)
        {
            //hag uso del try 
            try
            {
                // hago uso del using para la conexio 
                using(SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para el nombre sp 
                    using (SqlCommand cmd = new SqlCommand("SPinsertarDatosPersonales ", con))
                    {
                        // le indico que es un storeprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // los parametros de mi sp 
                        cmd.Parameters.Add(new SqlParameter("@Primer_Nombre", _ceDtp.Primer_Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Segundo_Nombre", _ceDtp.Segundo_Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Primer_Apellido", _ceDtp.Primer_Apellido));
                        cmd.Parameters.Add(new SqlParameter("@Segundo_Apellido", _ceDtp.Segundo_Apellido));
                        cmd.Parameters.Add(new SqlParameter("@Id_Genero", _ceDtp.Id_Genero));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_DNI", _ceDtp.Id_Tipo_DNI));
                        cmd.Parameters.Add(new SqlParameter("@DNI", _ceDtp.DNI));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceDtp.Id_Estado));
                        // el boton de enviar el ExecuteNonQuery
                        cmd.ExecuteNonQuery();


                    }
                  
                }

            }
            catch (Exception  ex)
            {
                //messagebox de error
                MessageBox.Show($"El sistema detecta {ex.Message}","Error ",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        #endregion

        #region actualizar Datos personales 
        public void ActualizarDatosPersonales(CEDatosPersonales _ceDtp)
        {
            //hag uso del try 
            try
            {
                // hago uso del using para la conexio 
                using (SqlConnection con = _CONEXION.AbrirConexion())
                {
                    // hago uso de otro using para el nombre sp 
                    using (SqlCommand cmd = new SqlCommand("SPActualizarDatosPersonales ", con))
                    {
                        // le indico que es un storeprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // los parametros de mi sp 
                        cmd.Parameters.Add(new SqlParameter("@Id_Persona", _ceDtp.Id_Persona));
                        cmd.Parameters.Add(new SqlParameter("@Primer_Nombre", _ceDtp.Primer_Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Segundo_Nombre", _ceDtp.Segundo_Nombre));
                        cmd.Parameters.Add(new SqlParameter("@Primer_Apellido", _ceDtp.Primer_Apellido));
                        cmd.Parameters.Add(new SqlParameter("@Segundo_Apellido", _ceDtp.Segundo_Apellido));
                        cmd.Parameters.Add(new SqlParameter("@Id_Genero", _ceDtp.Id_Genero));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_DNI", _ceDtp.Id_Tipo_DNI));
                        cmd.Parameters.Add(new SqlParameter("@DNI", _ceDtp.DNI));
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceDtp.Id_Estado));
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

        // mstrar genero, estado y tipo de dni
        public DataSet cdListarOpcionesParaPersonas()
        {
            using (SqlConnection cn =  _CONEXION.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("SPListarOpcionesParaPersonas", cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds); // ds.Tables[0] => Géneros, ds.Tables[1] => Tipos DNI, ds.Tables[2] => Estados
                return ds;
            }
        }

    }
}
