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
    public class CN_Direcciones
    {
        CD_Direcciones _cdDir = new CD_Direcciones();

        public List<CE_Direcciones> ListarDirecciones()
        {
            return _cdDir.ListarDirecciones();
        }

        public void InsertarDirecciones(CE_Direcciones _ceDir)
        {
            _cdDir.InsertarDirecciones(_ceDir);
        }

        public void ActualizarDirecciones(CE_Direcciones _ceDir)
        {
            _cdDir.ActualizarDirecciones(_ceDir);
        }
    }
}