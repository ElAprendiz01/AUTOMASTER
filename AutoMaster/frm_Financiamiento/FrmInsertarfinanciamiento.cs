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
    public partial class FrmInsertarfinanciamiento : frm_base
    {
         
      CN_Financiamiento _cnFinanciamiento = new CN_Financiamiento();
        CE_Financiamiento _crfin = new CE_Financiamiento();

        public FrmInsertarfinanciamiento()
        {
            InitializeComponent();
        }

        private void FrmInsertarfinanciamiento_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            GuardarNuevoFinanciamiento();
        }
        private void GuardarNuevoFinanciamiento()
        {
            try
            {
                if (txbIDVenta.Text == string.Empty ||
                    txbIDClinte.Text == string.Empty ||
                    TXBMonto.Text == string.Empty ||
                    txbplazoEnElMes.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
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

                    _cnFinanciamiento.InsertarFinanciamiento(_crfin);

                    MessageBox.Show("Financiamiento guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el financiamiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
