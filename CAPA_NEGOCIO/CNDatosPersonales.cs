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
    public class CNDatosPersonales
    {
        //instancia cd 
        CDDatosPersonales _cdDtp = new CDDatosPersonales();
        // metodo para listar 
        public List<CEDatosPersonales > cnListarDatosPersonales()
        {
            return _cdDtp.ListarDatosPersonales();
        }
        // metodo para insertar 
        public void cnInsertarDatosPersoneles(CEDatosPersonales _ceDtp)
        {
            _cdDtp.insertarDatosPersonales(_ceDtp);
        }
        //actuliar 
        public void CnActualizar( CEDatosPersonales _dtp)
        {
            _cdDtp.ActualizarDatosPersonales(_dtp);
        }
        // para listar genro tipo dni y estado
        public DataSet ListarOpciones()
        {
            return _cdDtp.cdListarOpcionesParaPersonas();
        }

    }
}
