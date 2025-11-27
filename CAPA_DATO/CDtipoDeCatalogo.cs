using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDAD;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CAPA_DATO
{
    public class CDtipoDeCatalogo
    {
        CD_CONEXION _conexion = new CD_CONEXION();

        #region Mostrar TipoDeCatalogo
        //Metodo para mostrar TipoDeCatalogo
        public List<CEtipoDeCatalogo> MostrarTipoDeCatalogo()
        {
            // creo una variable para la list
           var lista = new List<CEtipoDeCatalogo>();
            // hago uso de try  catch
            try
            {
                // hago uso de un using para la conexion
                using(SqlConnection con = _conexion.AbrirConexion())
                {
                    // hago uso de otro using para el comando
                    using(SqlCommand cmd = new SqlCommand("SP_Cls_Tipo_Catalogos_Listar", con))
                    {
                        // le digo que va a ser un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        // ejecuto el reader
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            // recorro el datareader
                            while (dr.Read())
                            {
                                // lleno la lista con el objeto CEtipoDeCatalogo
                                lista.Add(new CEtipoDeCatalogo()
                                {
                                    Id_Tipo_Catalogo = Convert.ToInt32(dr["Id_Tipo_Catalogo"]),
                                    Codigo = dr["Codigo"].ToString(),
                                    Tipo_Catalogo = dr["Tipo_Catalogo"].ToString(),
                                    Fecha_Creacion = Convert.ToDateTime(dr["Fecha_Creacion"]),
                                    Fecha_Modificacion = dr.IsDBNull(dr.GetOrdinal("Fecha_Modificacion")) ? (DateTime?)null : Convert.ToDateTime(dr["Fecha_Modificacion"]),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                });
                            }
                        }
                    }

                }
                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar tipo de  Catálogos: " + ex.Message, ex);
            }

        }

        #endregion

        #region Insertar TipoDeCatalogo
        //Metodo para insertar TipoDeCatalogo
        public void InsertarTipoDeCatalogo(CEtipoDeCatalogo _ceTipoDeCatalogo)
        {
            // hago uso del try catch
            try
            {
                // hago uso del using para la conexion
                using(SqlConnection con = _conexion.AbrirConexion())
                {
                    // hago uso de otro using para el comando
                    using(SqlCommand cmd = new SqlCommand("SP_Cls_Tipo_Catalogos_Insertar", con))
                    {
                        // le digo que va a ser un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        // paso los parametros que va a recibir el sp
                        cmd.Parameters.Add(new SqlParameter("@Codigo", _ceTipoDeCatalogo.Codigo));
                        cmd.Parameters.Add(new SqlParameter("@Tipo_Catalogo", _ceTipoDeCatalogo.Tipo_Catalogo));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceTipoDeCatalogo.Activo));
                        // ejecuto el comando
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Tipo de Catálogo: " + ex.Message, ex);
            }
        }

        #endregion

        #region Actualizar TipoDeCatalogo 
        // Metodo para actualizar TipoDeCatalogo
        public void ActualizarTipoDeCatalogo(CEtipoDeCatalogo _ceTipoDeCatalogo)
        {
            // hago uso del try catch
            try
            {
                // hago uso del using para la conexion
                using(SqlConnection con = _conexion.AbrirConexion())
                {
                    // hago uso de otro using para el comando
                    using(SqlCommand cmd = new SqlCommand("SP_Cls_Tipo_Catalogos_Editar", con))
                    {
                        // le digo que va a ser un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        // paso los parametros que va a recibir el sp
                        cmd.Parameters.Add(new SqlParameter("@Id_Tipo_Catalogo", _ceTipoDeCatalogo.Id_Tipo_Catalogo));
                        cmd.Parameters.Add(new SqlParameter("@Codigo", _ceTipoDeCatalogo.Codigo));
                        cmd.Parameters.Add(new SqlParameter("@Tipo_Catalogo", _ceTipoDeCatalogo.Tipo_Catalogo));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceTipoDeCatalogo.Activo));
                        // ejecuto el comando
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Tipo de Catálogo: " + ex.Message, ex);
            }
        }

        #endregion

    }
}
