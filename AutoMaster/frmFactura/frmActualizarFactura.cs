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
    public partial class frmActualizarFactura : frm_base
    {
        CN_Factura _cnFactura = new CN_Factura();
        CE_Factura _ceFactura = new CE_Factura();
        public frmActualizarFactura()
        {
            InitializeComponent();
        }

        private void frmActualizarFactura_Load(object sender, EventArgs e)
        {

        }

        private void txbIDClinte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTasaDeInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIDVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar ();
        }
        private void Actualizar()
        {
            try
            {
                if (txbIdFactura.Text == string.Empty ||
                    txbIDVenta.Text == string.Empty ||
                    txbNumeroFactura.Text == string.Empty ||
                    txbsubTotal.Text == string.Empty ||
                    txbIVA.Text == string.Empty ||
                    txbTotal.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   _ceFactura.Id_Factura = Convert.ToInt32(txbIdFactura.Text);

                   _ceFactura.Id_Venta = Convert.ToInt32(txbIDVenta.Text);
                    _ceFactura.Numero_Factura = txbNumeroFactura.Text;
                    _ceFactura.Subtotal = Convert.ToDecimal(txbsubTotal.Text);
                    _ceFactura.IVA = Convert.ToDecimal(txbIVA.Text);
                    _ceFactura.Total = Convert.ToDecimal(txbTotal.Text);

                   if (string.IsNullOrWhiteSpace(txbIDPago.Text))
                    {
                        _ceFactura.Id_Pago = null;
                    }
                    else
                    {
                        _ceFactura.Id_Pago = Convert.ToInt32(txbIDPago.Text);
                    }
                    if (string.IsNullOrWhiteSpace(txbIDFinanciamiento.Text))
                    {
                        _ceFactura.Id_Financiamiento = null;
                    }
                    else
                    {
                        _ceFactura.Id_Financiamiento = Convert.ToInt32(txbIDFinanciamiento.Text);
                    }

                    _cnFactura.ActualizarFactura(_ceFactura);

                    MessageBox.Show("Factura actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
