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

namespace AutoMaster.frmProveedores
{
    public partial class frmPrinProveedores : frm_base
    {
        CN_Proveedores _cnProvee = new CN_Proveedores();
        CE_Proveedores _ceProvee = new CE_Proveedores();

        public frmPrinProveedores()
        {
            InitializeComponent();
        }

        private void frmPrinProveedores_Load(object sender, EventArgs e)
        {
            listar();

        }

        private void listar()
        {
            dataGridViewListarProveedor.DataSource = _cnProvee.ListarProveedores();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarProveedor);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarProveedores Vinsert = new frmInsertarProveedores();
            Vinsert.ShowDialog();
            listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarProveedor();
            listar();
        }
        private void ActualizarProveedor()
        {
            if (dataGridViewListarProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    frmActualizarProveedores ventActualizar = new frmActualizarProveedores();

                    ventActualizar.txbId_Proveedor.Text = dataGridViewListarProveedor.CurrentRow.Cells["Id_Proveedor"].Value.ToString();

                    var valRep = dataGridViewListarProveedor.CurrentRow.Cells["Id_Representante"].Value;
                    ventActualizar.txbIdRepresentante.Text = valRep != null ? valRep.ToString() : "";

                    ventActualizar.txbNomEmpresa.Text = dataGridViewListarProveedor.CurrentRow.Cells["Nombre_Empresa"].Value.ToString();
                    ventActualizar.txbRUC.Text = dataGridViewListarProveedor.CurrentRow.Cells["RUC_Empresa"].Value.ToString();
                    ventActualizar.TxbIDEstado.Text = dataGridViewListarProveedor.CurrentRow.Cells["Id_Estado"].Value.ToString();

                    ventActualizar.ShowDialog();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar actualizar: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
