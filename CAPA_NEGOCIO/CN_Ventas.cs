using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Ventas
    {
        CD_Ventas _cdVentas = new CD_Ventas();

        public List<CE_Ventas> CNListarVentas()
        {
            return _cdVentas.ListarVentas();
        }

        public void InsertarVenta(CE_Ventas _ce)
        {
            _cdVentas.InsertarVenta(_ce);
        }

        public void ActualizarVenta(CE_Ventas _ce)
        {
            _cdVentas.ActualizarVenta(_ce);
        }

        public void EliminarVenta(CE_Ventas _ce)
        {
            _cdVentas.EliminarVenta(_ce);
        }
    }
}
