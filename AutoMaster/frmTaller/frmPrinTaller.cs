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

namespace AutoMaster.frmTaller
{
    public partial class frmPrinTaller : frm_base
    {
        CN_TALLER _cnTaller = new CN_TALLER();
        CE_Taller _ceTaller = new CE_Taller();
        public frmPrinTaller()
        {
            InitializeComponent();
        }

        private void frmPrinTaller_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            dataGridViewListarTALLER.DataSource = _cnTaller.ListarTaller();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarTALLER);
        }
        private void btNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarTaller ventInsertar = new FrmInsertarTaller();
            ventInsertar.ShowDialog();
            listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarTaller();
            listar();
        }
        private void ActualizarTaller()
        {
            if (dataGridViewListarTALLER.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para actualizar");
            }
            else
            {
                try
                {
                    frmActualizarTaller ventActualizar = new frmActualizarTaller();

                    ventActualizar.txbIdTaller.Text = dataGridViewListarTALLER.CurrentRow.Cells["Id_Taller"].Value.ToString();
                    ventActualizar.TXBIdVehiculo.Text = dataGridViewListarTALLER.CurrentRow.Cells["Id_Vehiculo"].Value.ToString();
                    ventActualizar.txbDescripcionDelTrabjo.Text = dataGridViewListarTALLER.CurrentRow.Cells["Descripcion_Trabajo"].Value.ToString();
                    ventActualizar.dateTimePickerFechaDeIngreso.Value = Convert.ToDateTime(dataGridViewListarTALLER.CurrentRow.Cells["Fecha_Ingreso"].Value);

                    // Manejo seguro para Fecha Salida (Puede ser null)
                    if (dataGridViewListarTALLER.CurrentRow.Cells["Fecha_Salida"].Value != DBNull.Value)
                    {
                        ventActualizar.dateTimePickerFechaDeSalida.Value = Convert.ToDateTime(dataGridViewListarTALLER.CurrentRow.Cells["Fecha_Salida"].Value);
                    }

                    ventActualizar.TxbCosto.Text = dataGridViewListarTALLER.CurrentRow.Cells["Costo"].Value.ToString();
                    ventActualizar.IDTRabajador.Text = dataGridViewListarTALLER.CurrentRow.Cells["Id_Responsable"].Value.ToString();

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar Taller: {ex.Message}", "Editar Taller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
