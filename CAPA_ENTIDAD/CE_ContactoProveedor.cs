using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class CE_ContactoProveedor
    {
        public int Id_Proveedor { get; set; }

        public string Nombre_Empresa { get; set; }

        public string RUC_Empresa { get; set; }

        public int Id_Contacto { get; set; }

        public string Contacto { get; set; }

        // Mapeado desde el alias 'ContactoPrincipal' (Campo original: Principal)
        public bool ContactoPrincipal { get; set; }

        // Mapeado desde el alias 'ID_Representante' (Campo original: Id_Persona)
        // Nullable (?) debido al LEFT JOIN en el SP
        public int? ID_Representante { get; set; }

        public string Primer_Nombre { get; set; }

        public string Segundo_Nombre { get; set; }

        public string Primer_Apellido { get; set; }

        public string Segundo_Apellido { get; set; }
    }
}
