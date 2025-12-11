using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_ServicioDeVehiculosr
    {
        public int Id_Servicio { get; set; }
        public int Id_Vehiculo { get; set; }
        public string Vehiculo_Info { get; set; }
        public int Id_Tipo_Servicio { get; set; }
        public string Tipo_Servicio { get; set; }
        public DateTime Fecha_Servicio { get; set; }
        public decimal Costo { get; set; }
        public int Id_Empleado { get; set; }
        public string Nombre_Mecanico { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
