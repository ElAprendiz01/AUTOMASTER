using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Vehiculos
    {
        CD_Vehiculos _cdVehiculo = new CD_Vehiculos();

        public List<CE_Vehiculo> CNListarVehiculos()
        {
            return _cdVehiculo.ListarVehiculos();
        }

        public void insertar_vehiculo(CE_Vehiculo _ceVeh)
        {
            _cdVehiculo.InsertarVehiculo(_ceVeh);
        }

        public void ActualizarVehiculo(CE_Vehiculo _ceVeh)
        {
            _cdVehiculo.ActualizarVehiculo(_ceVeh);
        }

        public void EliminarVehiculo(CE_Vehiculo _ceVeh)
        {
            _cdVehiculo.EliminarVehiculo(_ceVeh);
        }

    }
}
