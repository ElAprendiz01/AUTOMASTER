using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace AutoMaster.frmContactoProveedor
{
    public partial class frmPrinContactoProveedor : frm_base
    {
        CN_ContactoProveedores _contPro = new CN_ContactoProveedores();
        CE_ContactoProveedor _ceContPro = new CE_ContactoProveedor();

        public frmPrinContactoProveedor()
        {
            InitializeComponent();
        }

        private void frmPrinContactoProveedor_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void ActualizarContactoProveedor()
        {
            if (dataGridViewListarContactoProvvedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un contacto para actualizar");
            }
            else
            {
                try
                {
                    frmActualizarContactoProveedor ventActualizar = new frmActualizarContactoProveedor();

                    ventActualizar.txbIdContacto.Text = dataGridViewListarContactoProvvedor.CurrentRow.Cells["Id_Contacto"].Value.ToString();
                    ventActualizar.txbIdContactoProveedor.Text = dataGridViewListarContactoProvvedor.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
                    ventActualizar.checkContactoProveedorPrincipal.Checked = Convert.ToBoolean(dataGridViewListarContactoProvvedor.CurrentRow.Cells["ContactoPrincipal"].Value);

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el contacto:  {ex.Message}, ", "Editar Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listar()
        {
            dataGridViewListarContactoProvvedor.DataSource = _contPro.ListarContactoProveedor();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarContactoProvvedor);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarContactoProveedor();
            listar();


        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarContactoProveedor ventnuevocontacto = new FrmInsertarContactoProveedor();
            ventnuevocontacto.ShowDialog();
            listar();
        }
    }
}
