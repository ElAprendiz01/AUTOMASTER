using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Pagos
    {
        public int Id_Pago { get; set; }
        public int? Id_Venta { get; set; }
        public DateTime? Fecha_Venta { get; set; }
        public int? Id_Financiamiento { get; set; }
        public DateTime? Fecha_Inicio_Financiamiento { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public decimal Monto { get; set; }
        public string Metodo_Pago { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
