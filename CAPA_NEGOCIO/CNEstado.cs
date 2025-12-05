using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDAD;
using CAPA_DATO;
namespace CAPA_NEGOCIO
{
    public class CNEstado
    {
        // llamamos los metodos de la capa de datos
        CDEsatado objEstado = new CDEsatado();
        // metodo para listar estado
        public List<CEestado> ListarEstado()
        {
            return objEstado.ListarEstado();
        }
       // metodo para registrar estado
        public void InsertarEstado(CEestado _ceEsatdo)
        {
             objEstado.InsertarEstado(_ceEsatdo);
        }
        // metodo para editar estado
        public void EditarEstado(CEestado _CeEstado)
        {
             objEstado.ActualizarEstodo(_CeEstado);
        }
        // metodo para eliminar estado
        public void EliminarEstado(CEestado _CeEstado)
        {
            objEstado.EliminareSTADO(_CeEstado);
        }

    }
}
