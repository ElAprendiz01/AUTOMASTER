using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CEestado
    {
          public int  Id_Estado {get; set; }
        public string  Estado { get; set; }
        public DateTime  Fecha_Creacion { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
        public bool Activo { get; set; }
    }
}
