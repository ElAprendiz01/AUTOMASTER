using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CEtipoDeCatalogo
    {
        public int Id_Tipo_Catalogo { get; set; }
        public string Codigo { get; set; }
        public string Tipo_Catalogo { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
        public bool Activo { get; set; }

    }
}
