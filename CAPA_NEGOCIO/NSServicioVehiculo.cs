using CAPA_DATO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class NSServicioVehiculo
    {
        cd_servicioDeVehiculos _cdServicio = new cd_servicioDeVehiculos();

        public List<CE_ServicioDeVehiculosr> CNListarServiciosVehiculos()
        {
            return _cdServicio.ListarServiciosVehiculos();
        }

        public void InsertarServicio(CE_ServicioDeVehiculosr _ceServ)
        {
            _cdServicio.InsertarServicio(_ceServ);
        }

        public void ActualizarServicio(CE_ServicioDeVehiculosr _ceServ)
        {
            _cdServicio.ActualizarServicio(_ceServ);
        }

        public void EliminarServicio(CE_ServicioDeVehiculosr _ceServ)
        {
            _cdServicio.EliminarServicio(_ceServ);
        }
    }
}
