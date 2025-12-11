using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;
namespace CAPA_NEGOCIO
{
    public class CN_TALLER
    {
        CD_Taller _cdTaller = new CD_Taller();

        public List<CE_Taller> ListarTaller()
        {
            return _cdTaller.ListarTaller();
        }

        public void InsertarTaller(CE_Taller _ceTaller)
        {
            _cdTaller.InsertarTaller(_ceTaller);
        }

        public void ActualizarTaller(CE_Taller _ceTaller)
        {
            _cdTaller.ActualizarTaller(_ceTaller);
        }

        public void EliminarTaller(CE_Taller _ceTaller)
        {
            _cdTaller.EliminarTaller(_ceTaller);
        }
    }
}
