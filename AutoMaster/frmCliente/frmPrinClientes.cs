using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;

namespace AutoMaster.frmCliente
{
    public partial class frmPrinClientes : frm_base
    { 
        CN_Cliente _CNContacto = new CN_Cliente();
        CE_clientes _CEContacto = new CE_clientes();

        public frmPrinClientes()
        {
            InitializeComponent();
        }

        private void frmPrinClientes_Load(object sender, EventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertaCliente ventnuevocliente = new    FrmInsertaCliente();
            ventnuevocliente.ShowDialog();
            listar();

        }
        private void listar()
        {
            dataGridViewListarCliente.DataSource = _CNContacto.ListarClientes();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarCliente);
        }
       
        private void ActualizarCliente()
        {
 
            if (dataGridViewListarCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para actualizar", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    frmActualizarCliente ventActualizar = new   frmActualizarCliente();

                    
                    ventActualizar.txbIDEmpleado.Text = dataGridViewListarCliente.CurrentRow.Cells["Id_Cliente"].Value.ToString();

                    ventActualizar.txbIdPersona.Text = dataGridViewListarCliente.CurrentRow.Cells["Id_Persona"].Value.ToString();

                    ventActualizar.checkBoxactivoEmpleado.Checked = Convert.ToBoolean(dataGridViewListarCliente.CurrentRow.Cells["Activo"].Value);

                    ventActualizar.ShowDialog();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error crítico al intentar editar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
            listar();
        }

        private void dataGridViewListarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
