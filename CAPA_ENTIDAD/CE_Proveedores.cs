using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Proveedores
    {
        public int? ID_Representante { get; set; }
        public int? Representante { get; set; }

        public string Primer_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public int Id_Proveedor { get; set; }
        public string Nombre_Empresa { get; set; }
        public string RUC_Empresa { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public int Id_Estado { get; set; }
        public string Estado { get; set; }
    }
}
