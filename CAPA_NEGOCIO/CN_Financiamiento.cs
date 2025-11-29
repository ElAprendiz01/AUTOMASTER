using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Financiamiento
    {
        CD_Financiamiento _cdFinanciamiento = new CD_Financiamiento();

        public List<CE_Financiamiento> ListarFinanciamientos()
        {
            return _cdFinanciamiento.ListarFinanciamientos();
        }

        public void InsertarFinanciamiento(CE_Financiamiento _ceFin)
        {
            _cdFinanciamiento.InsertarFinanciamiento(_ceFin);
        }

        public void ActualizarFinanciamiento(CE_Financiamiento _ceFin)
        {
            _cdFinanciamiento.ActualizarFinanciamiento(_ceFin);
        }

        public void EliminarFinanciamiento(CE_Financiamiento _ceFin)
        {
            _cdFinanciamiento.EliminarFinanciamiento(_ceFin);
        }
    }
}