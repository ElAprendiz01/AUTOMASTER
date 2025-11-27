using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_Empelados
    {
        public int Id_Empleado { get; set; }
        public int Id_Persona { get; set; }
        public string Nombre_Completo { get; set; }
        public string DNI { get; set; }
        public int Id_Cargo { get; set; }
        public string Cargo { get; set; }
        public int Id_Area { get; set; }
        public string Area { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
