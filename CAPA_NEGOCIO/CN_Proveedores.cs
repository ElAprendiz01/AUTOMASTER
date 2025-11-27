using CAPA_DATO;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_Proveedores
    {
        // Instanciamos la lógica de acceso a datos clonada anteriormente
        CD_Proveedores _cdProv = new CD_Proveedores();

        public List<CE_Proveedores> ListarProveedores()
        {
            return _cdProv.ListarProveedores();
        }

        public void InsertarProveedor(CE_Proveedores _ceProv)
        {
            _cdProv.InsertarProveedor(_ceProv);
        }

        public void ActualizarProveedor(CE_Proveedores _ceProv)
        {
            _cdProv.ActualizarProveedor(_ceProv);
        }
    }
}