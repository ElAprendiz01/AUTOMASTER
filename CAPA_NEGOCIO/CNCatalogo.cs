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
    public class CNCatalogo
    {
        CD_CATALOGO _cdCata = new CD_CATALOGO();
       public List<CE_CATALOGO> CNMOSTRARCAT()
       {
            return _cdCata.MostrarCatalogos();

       }
        public void insertar_catalogo(CE_CATALOGO _CeCatalog )
        {
             _cdCata.InsertarCatalogo(_CeCatalog);
        }
        public DataTable CNListarIdtipodecatalogoYSuNombre()
        {
            return _cdCata.ListarIdtipodecatalogoYSuNombreDataTable();
        }
        public void ActualizarCatalogo(CE_CATALOGO _ceCatalog)
        {
             _cdCata.ActualizarCatalogo(_ceCatalog);
        }
    }
}
