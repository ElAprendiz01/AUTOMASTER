using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_ContactoProveedores
    {
        CD_ContactoProveedor _cdContProv = new CD_ContactoProveedor();

        public List<CE_ContactoProveedor> ListarContactoProveedor()
        {
            return _cdContProv.ListarContactoProveedor();
        }

        public void InsertarContactoProveedor(CE_ContactoProveedor _ce)
        {
            _cdContProv.InsertarContactoProveedor(_ce);
        }

        public void ActualizarContactoProveedor(CE_ContactoProveedor _ce)
        {
            _cdContProv.ActualizarContactoProveedor(_ce);
        }
    }
}
