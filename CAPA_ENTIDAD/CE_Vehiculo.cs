using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Vehiculo
    {
        public int Id_Vehiculo { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Estado { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Año { get; set; }
        public string Serie_Chasis { get; set; }
        public string Serie_Motor { get; set; }
        public decimal Precio { get; set; }
        public DateTime? Fecha_Ingreso_Pais { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Proveedor { get; set; }
        public string Nombre_Estado { get; set; }
    }
}
