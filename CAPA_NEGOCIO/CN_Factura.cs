using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Factura
    {
        CD_Factura _cdFactura = new CD_Factura();

        public List<CE_Factura> CNListarFacturas()
        {
            return _cdFactura.ListarFacturas();
        }

        public void InsertarFactura(CE_Factura _ceFactura)
        {
            _cdFactura.InsertarFactura(_ceFactura);
        }

        public void ActualizarFactura(CE_Factura _ceFactura)
        {
            _cdFactura.ActualizarFactura(_ceFactura);
        }

        public void EliminarFactura(CE_Factura _ceFactura)
        {
            _cdFactura.EliminarFactura(_ceFactura);
        }
    }
}
