using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATO;
using CAPA_ENTIDAD;


namespace CAPA_NEGOCIO
{
    public class CN_Usuario
    {
        CD_Usuarios usuarios = new CD_Usuarios();

        public DataTable CN_user(CE_Usuarios obj)
        {
            return usuarios.D_User(obj);
           
        }
    }
}
