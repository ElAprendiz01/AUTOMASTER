using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Taller
    {
        public int Id_Taller { get; set; }
        public int Id_Vehiculo { get; set; }
        public string Vehiculo_Descripcion { get; set; }
        public string Serie_Chasis { get; set; }
        public string Descripcion_Trabajo { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        public DateTime? Fecha_Salida { get; set; }
        public decimal? Costo { get; set; }
        public int? Id_Responsable { get; set; }
        
        public string Nombre_Responsable { get; set; }
       public DateTime Fecha_Registro { get; set; } 
    }
}
