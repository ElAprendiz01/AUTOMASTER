using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_InicioSesion
    {// Datos de entrada 
        public string Usuario { get; set; }
        public string Clave { get; set; } 

        // Datos de salida 
        public int Id_Usuario { get; set; }
        public string Contrasena_Hash { get; set; } 
        public string Nombre_Rol { get; set; }
        public int Id_Estado { get; set; }
        public int Id_Tipo_de_Usuario { get; set; }
    }

}
