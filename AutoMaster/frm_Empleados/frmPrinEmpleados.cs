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
        private void ActualizarEmpleado()
        {
            if (dataGridViewListarEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para actualizar");
            }
            else
            {
                try
                {
                    frmActualizarEmpelados ventActualizar = new frmActualizarEmpelados();

                    ventActualizar.txbIdEmpleado.Text = dataGridViewListarEmpleados.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                    ventActualizar.txbIdPersona.Text = dataGridViewListarEmpleados.CurrentRow.Cells["Id_Persona"].Value.ToString();
                    ventActualizar.txbIDCargo.Text = dataGridViewListarEmpleados.CurrentRow.Cells["Id_Cargo"].Value.ToString();
                    ventActualizar.TxbIDArea.Text = dataGridViewListarEmpleados.CurrentRow.Cells["Id_Area"].Value.ToString();
                    ventActualizar.checkBoxactivoEmpleado.Checked = Convert.ToBoolean(dataGridViewListarEmpleados.CurrentRow.Cells["Activo"].Value);

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el empleado:  {ex.Message}, ", "Editar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
            listar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarEmpleados ventnuevoempleado = new frmInsertarEmpleados();
            ventnuevoempleado.ShowDialog();
            listar();
        }
    }
}
