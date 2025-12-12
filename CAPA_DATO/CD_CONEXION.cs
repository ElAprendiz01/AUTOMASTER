using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CAPA_DATO
{
    public class CD_CONEXION
    {

        /*/La cadena de conexión es lo que debe ser 'readonly'  o estático, no la SqlConnection.
            La conexión en sí se creará nueva cada vez que se necesite.
            implementacion de nuevo metodo de conexion para que me permita tener mas conexiones abiertas simultaneamente
            la docuentacion dice que coneste metodo se hace lo siguiente : 
           - Se guarda solo la cadena de conexión como readonl y No se crea
        ninguna instancia fija de SqlConnection, lo cual permite mayor flexibilidad
        */
         private readonly string _connectionString = "Data Source=.;Initial Catalog=AUTOMASTER;Integrated Security=True;Encrypt=False";

      private readonly SqlConnection _cone = new SqlConnection();

        public SqlConnection AbrirConexion()
        {
            // Creamos una NUEVA INSTANCIA de SqlConnection cada vez que se solicita abrir una conexión.
            // Esto es mucho más robusto para el connection pooling, dice google kjaja
            SqlConnection conexion = new SqlConnection(_connectionString);

            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        // El método CerrarConexion() ahora se vuelve un poco menos útil directamente aquí,
        // porque el 'using' en el código cliente se encargará de cerrar la conexión que fue abierta.
        // Si quiero mantenerlo, podría ser así, pero no se usará directamente con el patrón 'using'.
        // Sin embargo, si pasa la conexión fuera del 'using', sigue siendo relevante.
        public void CerrarConexion(SqlConnection conexion) // Recibe la conexión a cerrar
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
