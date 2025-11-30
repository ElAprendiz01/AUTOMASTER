using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Factura
    {
        public int Id_Factura { get; set; }
        public int Id_Venta { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public int Id_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string DNI_Cliente { get; set; }
        public int? Id_Pago { get; set; }
        public string Metodo_Pago { get; set; }
        public DateTime? Fecha_Pago { get; set; }
        public int? Id_Financiamiento { get; set; }
        public int? Plazo_Meses { get; set; }
        public string Numero_Factura { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? IVA { get; set; }
        public decimal? Total { get; set; }
    }
}
