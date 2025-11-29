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

namespace AutoMaster.frm_Financiamiento
{
    public partial class frmActualizarFinanciamiento : frm_base
    {  
      CN_Financiamiento _cnFinanciamiento = new CN_Financiamiento();
        CE_Financiamiento _crfin = new CE_Financiamiento();

        public frmActualizarFinanciamiento()
        {
            InitializeComponent();
        }

        private void frmActualizarFinanciamiento_Load(object sender, EventArgs e)
        {

        }

        private void txbIDVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickcFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();

        }
        private void Actualizar()
        {
            try
            {
                if (txbIdFinanciamiento.Text == string.Empty ||
                    txbIDVenta.Text == string.Empty ||
                    txbIDClinte.Text == string.Empty ||
                    TXBMonto.Text == string.Empty ||
                    txbplazoEnElMes.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _crfin.Id_Financiamiento = Convert.ToInt32(txbIdFinanciamiento.Text);
                    _crfin.Id_Venta = Convert.ToInt32(txbIDVenta.Text);
                    _crfin.Id_Cliente = Convert.ToInt32(txbIDClinte.Text);
                    _crfin.Monto = Convert.ToDecimal(TXBMonto.Text);
                    _crfin.Plazo_Meses = Convert.ToInt32(txbplazoEnElMes.Text);
                    _crfin.Fecha_Inicio = dateTimePickcFechaInicio.Value;

                    if (string.IsNullOrWhiteSpace(txbTasaDeInteres.Text))
                    {
                        _crfin.Tasa_Interes = null;
                    }
                    else
                    {
                        _crfin.Tasa_Interes = Convert.ToDecimal(txbTasaDeInteres.Text);
                    }

                    _crfin.Fecha_Cancelacion = dateTimePickerFechadeCanselacion.Value;

                    _cnFinanciamiento.ActualizarFinanciamiento(_crfin);

                    MessageBox.Show("Financiamiento actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el financiamiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbelCodigoCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_IdTipoCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void txbTasaDeInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbplazoEnElMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXBMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIDClinte_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechadeCanselacion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
