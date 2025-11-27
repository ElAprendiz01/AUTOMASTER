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

namespace AutoMaster.frmDirecciones
{
    public partial class frmPrinDirecciones : frm_base
    {
        CN_Direcciones _cnDirecciones = new CN_Direcciones();
        CE_Direcciones _ceDirecciones = new CE_Direcciones();
        public frmPrinDirecciones()
        {
            InitializeComponent();
        }

        private void frmPrinDirecciones_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            dataGridViewListarDirecciones.DataSource = _cnDirecciones.ListarDirecciones();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarDirecciones);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarDirecciones Vinsert = new frmInsertarDirecciones();
            Vinsert.ShowDialog();
            listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarDirecciones();
            listar();

        }
        private void ActualizarDirecciones()
        {
            if (dataGridViewListarDirecciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una dirección para actualizar");
            }
            else
            {
                try
                {
                    frmActualizarDirecciones ventActualizar = new frmActualizarDirecciones();

                    ventActualizar.txbIdDireccion.Text = dataGridViewListarDirecciones.CurrentRow.Cells["Id_Direccion"].Value.ToString();
                    ventActualizar.txbIdPersona.Text = dataGridViewListarDirecciones.CurrentRow.Cells["Id_Persona"].Value.ToString();
                    ventActualizar.txbDireccion.Text = dataGridViewListarDirecciones.CurrentRow.Cells["Direccion"].Value.ToString();
                    ventActualizar.txbCiudad.Text = dataGridViewListarDirecciones.CurrentRow.Cells["Ciudad"].Value.ToString();
                    ventActualizar.txbDepartamento.Text = dataGridViewListarDirecciones.CurrentRow.Cells["Departamento"].Value.ToString();
                    ventActualizar.checkBoxactivoDirecciones.Checked = Convert.ToBoolean(dataGridViewListarDirecciones.CurrentRow.Cells["Principal"].Value);
                    ventActualizar.TxbIDEstado.Text = dataGridViewListarDirecciones.CurrentRow.Cells["Id_Estado"].Value.ToString();

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la dirección: {ex.Message}", "Editar Dirección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
