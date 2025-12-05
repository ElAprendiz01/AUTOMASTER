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

namespace AutoMaster.frmFactura
{
    public partial class frmPrinFactura : frm_base
    {   CN_Factura _cnFactura = new CN_Factura();
         CE_Factura _ceFactura = new CE_Factura();
        public frmPrinFactura()
        {
            InitializeComponent();
        }

        private void frmPrinFactura_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarFactura ventInsertar = new frmInsertarFactura();
            ventInsertar.ShowDialog();
            listar();
        }
        private void listar()
        {
            dataGridViewListarfACTURAS.DataSource = _cnFactura.CNListarFacturas();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarfACTURAS);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarFactura();
            listar();
        }
        private void ActualizarFactura()
        {
            if (dataGridViewListarfACTURAS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Instancia del formulario de edición
                    frmActualizarFactura ventActualizar = new frmActualizarFactura();

                    // Captura de la fila seleccionada
                    DataGridViewRow fila = dataGridViewListarfACTURAS.CurrentRow;

                   
                    ventActualizar.txbIdFactura.Text = fila.Cells["Id_Factura"].Value.ToString();
                    ventActualizar.txbIDVenta.Text = fila.Cells["Id_Venta"].Value.ToString();
                    ventActualizar.txbNumeroFactura.Text = fila.Cells["Numero_Factura"].Value.ToString();

                    object valPago = fila.Cells["Id_Pago"].Value;
                    if (valPago != DBNull.Value && valPago != null)
                    {
                        ventActualizar.txbIDPago.Text = valPago.ToString();
                    }
                    else
                    {
                        ventActualizar.txbIDPago.Text = "";
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

                    object valSubtotal = fila.Cells["Subtotal"].Value;
                    ventActualizar.txbsubTotal.Text = (valSubtotal != DBNull.Value && valSubtotal != null) ? valSubtotal.ToString() : "0.00";

                    object valIVA = fila.Cells["IVA"].Value;
                    ventActualizar.txbIVA.Text = (valIVA != DBNull.Value && valIVA != null) ? valIVA.ToString() : "0.00";

                    object valTotal = fila.Cells["Total"].Value;
                    ventActualizar.txbTotal.Text = (valTotal != DBNull.Value && valTotal != null) ? valTotal.ToString() : "0.00";

                   
                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos para actualizar: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnElimianar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewListarfACTURAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
