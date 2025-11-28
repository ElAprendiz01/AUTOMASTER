using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Ventas
    {
        public int Id_Venta { get; set; }
        public int Id_Vehiculo { get; set; }
        public string Vehiculo { get; set; }
        public int Id_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public int Id_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public decimal Precio_Venta { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
