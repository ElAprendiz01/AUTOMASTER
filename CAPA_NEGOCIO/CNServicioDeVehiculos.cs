using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CNServicioDeVehiculos
    {
        CDServiocioDeVehiculos _cdServicio = new CDServiocioDeVehiculos();

        public List<CEServicioDeVehiculos> CNListarServiciosVehiculos()
        {
            return _cdServicio.ListarServiciosVehiculos();
        }

        public void InsertarServicio(CEServicioDeVehiculos _ceServ)
        {
            _cdServicio.InsertarServicio(_ceServ);
        }

        public void ActualizarServicio(CEServicioDeVehiculos _ceServ)
        {
            _cdServicio.ActualizarServicio(_ceServ);
        }

        public void EliminarServicio(CEServicioDeVehiculos _ceServ)
        {
            _cdServicio.EliminarServicio(_ceServ);
        }
    }
}
