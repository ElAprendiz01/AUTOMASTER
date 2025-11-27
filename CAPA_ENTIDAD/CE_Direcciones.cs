using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public  class CE_Direcciones
    {
        public int Id_Persona { get; set; }
        public string Primer_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public int Id_Direccion { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public bool Principal { get; set; }
        public int Id_Estado { get; set; }
        public string Estado { get; set; }
    }
}
