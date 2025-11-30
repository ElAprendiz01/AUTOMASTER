using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;


namespace CAPA_NEGOCIO
{
    public class CN_Pagos
    {
        CD_Pagos _cdPagos = new CD_Pagos();

        public List<CE_Pagos> CNListarPagos()
        {
            return _cdPagos.ListarPagos();
        }

        public void InsertarPago(CE_Pagos _cePagos)
        {
            _cdPagos.InsertarPago(_cePagos);
        }

        public void ActualizarPago(CE_Pagos _cePagos)
        {
            _cdPagos.ActualizarPago(_cePagos);
        }

        public void EliminarPago(CE_Pagos _cePagos)
        {
            _cdPagos.EliminarPago(_cePagos);
        }
    }
}
