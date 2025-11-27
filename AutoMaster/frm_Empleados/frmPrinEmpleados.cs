using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMaster.frm_Empleados
{
    public partial class frmPrinEmpleados : frm_base
    {
        CN_Empleados _cnEmpleados = new CN_Empleados();
        CE_Empelados E_Empelados = new CE_Empelados();
        public frmPrinEmpleados()
        {
            InitializeComponent();
        }

        private void frmPrinEmpleados_Load(object sender, EventArgs e)
        {
            listar();

        }

        private void dataGridViewListarContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listar()
        {
            dataGridViewListarEmpleados.DataSource = _cnEmpleados.CNListarEmpleados();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarEmpleados);
        }

    }
}
