using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATO;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class CN_Cliente
    {
        CD_Clientes _cdCli = new CD_Clientes();

        #region METODO LISTAR
        public List<CE_clientes> ListarClientes()
        {
            return _cdCli.ListarClientes();
        }
        #endregion

        #region METODO INSERTAR
        public void InsertarCliente(CE_clientes _ceCli)
        {
            _cdCli.InsertarCliente(_ceCli);
        }
        #endregion

        #region METODO ACTUALIZAR
        public void ActualizarCliente(CE_clientes _ceCli)
        {
            _cdCli.ActualizarCliente(_ceCli);
        }
        #endregion

        #region METODO ELIMINAR
        // Agregado por Protocolo de Integridad Pennywise
        public void EliminarCliente(CE_clientes _ceCli)
        {
            _cdCli.EliminarCliente(_ceCli);
        }
        #endregion
    }
}
