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

namespace AutoMaster.frmPagos
{
    public partial class frmPrinPagos : frm_base
    {
        CN_Pagos _cnPago = new CN_Pagos();
        CE_Pagos CE_Pagos = new CE_Pagos();
        public frmPrinPagos()
        {
            InitializeComponent();
        }

        private void frmPrinPagos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            dataGridViewListarpagos.DataSource = _cnPago.CNListarPagos();


            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarpagos);
        }
        private void ActualizarPago()
        {
            if (dataGridViewListarpagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    FrmActualizarPagos ventActualizar = new FrmActualizarPagos();
                    DataGridViewRow fila = dataGridViewListarpagos.CurrentRow;

                    ventActualizar.txbIdPagos.Text = fila.Cells["Id_Pago"].Value.ToString();

                    object valVenta = fila.Cells["Id_Venta"].Value;
                    if (valVenta != DBNull.Value && valVenta != null)
                    {
                        ventActualizar.txbIDVenta.Text = valVenta.ToString();
                    }
                    else
                    {
                        ventActualizar.txbIDVenta.Text = "";
                    }

                    object valFinanciamiento = fila.Cells["Id_Financiamiento"].Value;
                    if (valFinanciamiento != DBNull.Value && valFinanciamiento != null)
                    {
                        ventActualizar.txbIDFinanciamiento.Text = valFinanciamiento.ToString();
                    }
                    else
                    {
                        ventActualizar.txbIDFinanciamiento.Text = "";
                    }

                    ventActualizar.TXBMonto.Text = fila.Cells["Monto"].Value.ToString();
                    ventActualizar.txbMetodoDePAgo.Text = fila.Cells["Metodo_Pago"].Value.ToString();

                    object valObs = fila.Cells["Observaciones"].Value;
                    if (valObs != DBNull.Value && valObs != null)
                    {
                        ventActualizar.txbObservacion.Text = valObs.ToString();
                    }
                    else
                    {
                        ventActualizar.txbObservacion.Text = "";
                    }

                    ventActualizar.dateTimePickcFechaPago.Value = Convert.ToDateTime(fila.Cells["Fecha_Pago"].Value);

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos para actualizar: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarPago();
            Listar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarPagos ventInsertar = new frmInsertarPagos();
            ventInsertar.ShowDialog();
            Listar();

        }

        private void btnElimianar_Click(object sender, EventArgs e)
        {

        }
    }
}
