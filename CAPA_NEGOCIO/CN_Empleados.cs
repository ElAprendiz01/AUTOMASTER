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
    public class CN_Empleados
    {
        CD_Empleados _cdEmpleados = new CD_Empleados();

        public List<CE_Empelados> CNListarEmpleados()
        {
            return _cdEmpleados.ListarEmpleados();
        }

        public void insertar_empleado(CE_Empelados _ceEmp)
        {
            _cdEmpleados.InsertarEmpleado(_ceEmp);
        }

        public void ActualizarEmpleado(CE_Empelados _ceEmp)
        {
            _cdEmpleados.ActualizarEmpleado(_ceEmp);
        }
    }
}