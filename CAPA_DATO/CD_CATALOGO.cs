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
    public class CD_CATALOGO
    {
        CD_CONEXION gestorConexion = new CD_CONEXION();

        #region MetodoListarCatalogo
        public List<CE_CATALOGO> MostrarCatalogos()
        {
            var lista = new List<CE_CATALOGO>();

            try 
            {
                 using(SqlConnection con = gestorConexion.AbrirConexion())  
                 { 
                    using (SqlCommand cmd = new SqlCommand("SP_Cls_Catalogos_Listar", con))
                     {
                        // Le decimos que va a ser un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Ejecutamos el reader
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            // Recorremos el datareader
                            while (dr.Read())
                            {
                                // Llenamos la lista con el objeto CE_CATALOGO
                                lista.Add(new CE_CATALOGO()
                                {
                                    Id_Catalogo = Convert.ToInt32(dr["Id_Catalogo"]),

                                    // Aquí capturamos el campo del JOIN que viene del SP
                                    Tipo_Catalogo = dr["Tipo_Catalogo"].ToString(),
                                    Id_Tipo_Catalogo = Convert.ToInt32(dr["Id_Tipo_Catalogo"]),

                                    Codigo = dr["Codigo"].ToString(),
                                    Catalogo = dr["Catalogo"].ToString(),

                                    Fecha_Creacion = Convert.ToDateTime(dr["Fecha_Creacion"]),

                                    Fecha_Modificacion = dr.IsDBNull(dr.GetOrdinal("Fecha_Modificacion")) ? (DateTime?)null : Convert.ToDateTime(dr["Fecha_Modificacion"]),
                                    // Convertimos el BIT de SQL a Booleano de C#
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                });
                            }
                        }
                     }
                 }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al listar los Catálogos: " + ex.Message, ex);
            }
            // aqui quiero hacer enfasis que no use el finaly para cerrar la conexion 
            // por la razon que use un using especialmente para la concexion lo que hace que cuando termine el using entonces 
            // me la cierre automaticamente lo queme permite hacer mas peticiones al mismo tiempo 

         

            // Retornamos la lista
            return lista;
        }
        #endregion

        #region ListarIdtipodecatalogoYSuNombre
        public DataTable ListarIdtipodecatalogoYSuNombreDataTable()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = gestorConexion.AbrirConexion()) // Usamos 'using' para la conexión
                {

                    using (SqlCommand cmd = new SqlCommand("SP_idyTipoCat", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Tipos de Catálogo en DataTable: " + ex.Message);
            }
          

            return dt;
        }
        #endregion


        #region InsertarCatalogo
        public void InsertarCatalogo(CE_CATALOGO _ceCatalogo)
        {
           
            try
            {
                using (SqlConnection con = gestorConexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Cls_Catalogos_Insertar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros para el SP_Cls_Catalogos_Insertar
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Catalogo", _ceCatalogo.Id_Tipo_Catalogo));

                        cmd.Parameters.Add(new SqlParameter("@Codigo", string.IsNullOrEmpty(_ceCatalogo.Codigo) ? (object)DBNull.Value : _ceCatalogo.Codigo));

                        cmd.Parameters.Add(new SqlParameter("@Catalogo", _ceCatalogo.Catalogo));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceCatalogo.Activo));

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostramos el mensaje detallado de la excepción
                MessageBox.Show($"No se ha insertado el Catálogo. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
          


        }
        #endregion
        #region Metodo de Actualizar Catalogo 

        public void ActualizarCatalogo(CE_CATALOGO _ceCatalogo)
        {

            try
            {
                using (SqlConnection con = gestorConexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Cls_Catalogos_Editar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros para el 
                        cmd.Parameters.Add(new SqlParameter("Id_Catalogo", _ceCatalogo.Id_Catalogo));
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Catalogo", _ceCatalogo.Id_Tipo_Catalogo));

                        cmd.Parameters.Add(new SqlParameter("@Codigo", string.IsNullOrEmpty(_ceCatalogo.Codigo) ? (object)DBNull.Value : _ceCatalogo.Codigo));

                        cmd.Parameters.Add(new SqlParameter("@Catalogo", _ceCatalogo.Catalogo));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceCatalogo.Activo));

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, mostramos el mensaje detallado de la excepción
                MessageBox.Show($"No se ha insertado el Catálogo. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        #endregion

    }
}