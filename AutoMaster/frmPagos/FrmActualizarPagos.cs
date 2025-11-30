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
    public partial class FrmActualizarPagos : frm_base
    {
        CN_Pagos _cnPago = new CN_Pagos();
        CE_Pagos CE_Pagos = new CE_Pagos();
        public FrmActualizarPagos()
        {
            InitializeComponent();
        }

        private void FrmActualizarPagos_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            GuardarEdicionPago();
        }
        private void GuardarEdicionPago()
        {
            try
            {
                if (txbIdPagos.Text == string.Empty ||
                    txbIDVenta.Text == string.Empty ||
                    txbIDFinanciamiento.Text == string.Empty ||
                    TXBMonto.Text == string.Empty ||
                    txbMetodoDePAgo.Text == string.Empty ||
                    txbObservacion.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CE_Pagos.Id_Pago = Convert.ToInt32(txbIdPagos.Text);
                    CE_Pagos.Id_Venta = Convert.ToInt32(txbIDVenta.Text);
                    CE_Pagos.Id_Financiamiento = Convert.ToInt32(txbIDFinanciamiento.Text);
                    CE_Pagos.Monto = Convert.ToDecimal(TXBMonto.Text);
                    CE_Pagos.Metodo_Pago = txbMetodoDePAgo.Text;
                    CE_Pagos.Observaciones = txbObservacion.Text;
                    CE_Pagos.Fecha_Pago = dateTimePickcFechaPago.Value;

                    _cnPago.ActualizarPago(CE_Pagos);

                    MessageBox.Show("Pago actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txbMetodoDePAgo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
