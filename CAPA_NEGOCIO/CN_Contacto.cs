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
    public class CN_Contactos
    {
        CD_Contactos _cdContactos = new CD_Contactos();

        public List<CE_Contacto> CNListarContactos()
        {
            return _cdContactos.ListarContactos();
        }

        public void insertar_contacto(CE_Contacto _CeCto)
        {
            _cdContactos.InsertarContacto(_CeCto);
        }



        public void ActualizarContacto(CE_Contacto _ceCto)
        {
            _cdContactos.ActualizarContacto(_ceCto);
        }
    }
}