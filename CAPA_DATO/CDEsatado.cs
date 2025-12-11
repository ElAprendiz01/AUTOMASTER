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
    public class CDEsatado
    {
         CD_CONEXION gestordeconexion = new CD_CONEXION();

       #region Listar Estado

        public List<CEestado> ListarEstado()
        {
            // creo la variable var 
            var lista = new List<CEestado>();
            // hago uso del try 
            try
            {
                    // hago uso del primer using que me gestiona la conexiio 
                using(SqlConnection con = gestordeconexion.AbrirConexion())
                {
                    // nuevamente hago uso de un using para el sp 
                    using(SqlCommand cmd = new SqlCommand("SP_ListarEstados", con) )
                    {
                        // le hago saber al sistema que es storedprocedure 
                        cmd.CommandType = CommandType.StoredProcedure;
                        // hago uso del using nuevamente para el sqlDataReader y el dr = ExecuteReader 
                        using( SqlDataReader dt= cmd.ExecuteReader())
                        {
                            // utilizo un ciclo While pare recorrer la lista 
                            while (dt.Read())
                            {
                                // me encargo de llenar la varibale que cree para la lista 
                                lista.Add(new CEestado()
                                {  /// mando a llamr mis entiddes 
                                    Id_Estado = Convert.ToInt32(dt["Id_Estado"]),
                                    Estado = dt["Estado"].ToString(),
                                    Fecha_Creacion = Convert.ToDateTime(dt["Fecha_Creacion"]),
                                    // aqui para recibir datos nulos se hace e la siguiente manera 
                                    Fecha_Modificacion = dt.IsDBNull(dt.GetOrdinal("Fecha_Modificacion"))? (DateTime?)null : Convert.ToDateTime(dt["Fecha_Modificacion"]),
                                    // para el activo de tipo bool+
                                    Activo= Convert.ToBoolean(dt["Activo"])
                                 
                                });

                            }
                           
                        }
                    }
                }
            }
            catch (Exception ex )
            {

                throw new Exception("Error al listar los Catálogos: " + ex.Message, ex);

            }
            return lista;

        }
        #endregion

        #region Insertar Estado 
        public void InsertarEstado(CEestado _CeEstado)
        {
            // hago uso del try cacth 
            try
            {
                // hago uso del using nuevamente para abir la concexion sql
                using (SqlConnection con = gestordeconexion.AbrirConexion())
                {
                    // hago uso del using nuevaemnte para  indicar el nombre del sp 
                    using (SqlCommand cmd = new SqlCommand("SP_Cls_Estados_Insertar", con))
                    {
                        // le indico que que es un commandType.StoredProcedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        // ahora le paso los parametros que va a recibir el sp  
                        cmd.Parameters.Add(new SqlParameter("@Estado", _CeEstado.Estado));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _CeEstado.Activo));
                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se ha insertado el Estado . Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        #region Actualizar Estado
        // creamos un piblico void para actualizar el estado llamando dentro de el la clase CEestado

        public void ActualizarEstodo( CEestado _ceEstado)
        {
            // hacemos lo mismos de insertar pero agregadno el id del estado
            try
            {
                // hago uso del using nuevamente para abir la concexion sql
                using (SqlConnection con = gestordeconexion.AbrirConexion())
                {
                    // hago uso del using nuevaemnte para  indicar el nombre del sp 
                    using (SqlCommand cmd = new SqlCommand("SP_Cls_Estados_Editar", con))
                    {
                        // le indico que que es un commandType.StoredProcedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        // ahora le paso los parametros que va a recibir el sp  
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceEstado.Id_Estado));
                        cmd.Parameters.Add(new SqlParameter("@Estado", _ceEstado.Estado));
                        cmd.Parameters.Add(new SqlParameter("@Activo", _ceEstado.Activo));
                        cmd.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se ha Actualizado el Estado . Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #region Eliminar eSTADO
        public void EliminareSTADO(CEestado _ceeSTADO)
        {
            try
            {
                using (SqlConnection con = gestordeconexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Cls_Estados_Eliminar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Id_Estado", _ceeSTADO.Id_Estado));
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
