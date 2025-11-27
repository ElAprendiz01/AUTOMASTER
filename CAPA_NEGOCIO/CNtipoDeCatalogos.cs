using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTIDAD;
using CAPA_DATO;

namespace CAPA_NEGOCIO
{
    public class CNtipoDeCatalogos
    {
        CDtipoDeCatalogo _tipoDeCatalogo = new CDtipoDeCatalogo();
        //Metodo para mostrar TipoDeCatalogo
        public List<CEtipoDeCatalogo> MostrarTipoDeCatalogo()
        {
            return _tipoDeCatalogo.MostrarTipoDeCatalogo();
        }
        // METODO PARA INSETAR TIPO DE CATALOGO
        public void InsertarTipoDeCatalogo(CEtipoDeCatalogo tipoDeCatalogo)
        {
            _tipoDeCatalogo.InsertarTipoDeCatalogo(tipoDeCatalogo);
        }
        // METODO PARA ACTUALIZAR TIPO DE CATALOGO
        public void ActualizarTipoDeCatalogo(CEtipoDeCatalogo tipoDeCatalogo)
        {
            _tipoDeCatalogo.ActualizarTipoDeCatalogo(tipoDeCatalogo);
        }
    }
}
