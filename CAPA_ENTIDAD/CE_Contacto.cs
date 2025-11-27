using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Contacto
    {
        public int Id_Contacto { get; set; }
        public int Id_Persona { get; set; }
        public int Id_Tipo_Contacto { get; set; }
        public int Id_Estado { get; set; }
        public string Contacto { get; set; }
        public bool Principal { get; set; } 
        public DateTime Fecha_Creacion { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }

        public string Primer_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string TIPO_CONTACTO { get; set; }
        public string Estado { get; set; }
    }
}
