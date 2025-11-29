using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Financiamiento
    {
        public int Id_Financiamiento { get; set; }
        public int Id_Venta { get; set; }
        public int Id_Cliente { get; set; }
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public int Plazo_Meses { get; set; }
        public decimal? Tasa_Interes { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime? Fecha_Cancelacion { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
