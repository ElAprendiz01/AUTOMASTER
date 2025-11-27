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

namespace AutoMaster.fmrContacto
{
    public partial class frmPrinContacto : frm_base
    {
        CN_Contactos _CNContacto = new CN_Contactos();
        public frmPrinContacto()
        {
            InitializeComponent();
        }

        private void frmPrinContacto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void dataGridViewListarContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listar()
        {
            dataGridViewListarContacto.DataSource = _CNContacto.CNListarContactos();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarContacto);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarCONTACTO ventnuevocontacto = new   frmInsertarCONTACTO();
            ventnuevocontacto.ShowDialog();
            listar();
        }
        private void ActualizarContacto()
        {
            if (dataGridViewListarContacto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto para actualizar");
            }
            else
            {
                try
                {
                    frmActualizarCONTACTO ventActualizar = new frmActualizarCONTACTO();

                    ventActualizar.txbIdContacto.Text = dataGridViewListarContacto.CurrentRow.Cells["Id_Contacto"].Value.ToString();
                    ventActualizar.txbIdPersona.Text = dataGridViewListarContacto.CurrentRow.Cells["Id_Persona"].Value.ToString();
                    ventActualizar.txbIDTipoDeContacto.Text = dataGridViewListarContacto.CurrentRow.Cells["Id_Tipo_Contacto"].Value.ToString();
                    ventActualizar.txbContacto.Text = dataGridViewListarContacto.CurrentRow.Cells["Contacto"].Value.ToString();
                    ventActualizar.checkBoxactivoContactocheckBoxactivoContacto.Checked = Convert.ToBoolean(dataGridViewListarContacto.CurrentRow.Cells["Principal"].Value);
                    ventActualizar.TxbIDEstado.Text = dataGridViewListarContacto.CurrentRow.Cells["Id_Estado"].Value.ToString();

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el contacto:  {ex.Message}, ", "Editar Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarContacto();
             listar();
        }

    }
}
