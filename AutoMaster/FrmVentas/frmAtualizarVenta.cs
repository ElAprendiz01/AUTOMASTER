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

namespace AutoMaster.FrmVentas
{
    public partial class frmAtualizarVenta : frm_base
    {

        CN_Ventas _cnVentas = new CN_Ventas();
        CE_Ventas _ceVentas = new CE_Ventas();

        public frmAtualizarVenta()
        {
            InitializeComponent();
        }

        private void frmAtualizarVenta_Load(object sender, EventArgs e)
        {

        }
        private void Actualizar()
        {
            try
            {
                if (txbIdVentas.Text == string.Empty || txbIDVehiculo.Text == string.Empty ||
                    txbIdCliente.Text == string.Empty || txbIdEmpleado.Text == string.Empty ||
                    txbPrecioDeVenta.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos requeridos", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceVentas.Id_Venta = Convert.ToInt32(txbIdVentas.Text);
                    _ceVentas.Id_Vehiculo = Convert.ToInt32(txbIDVehiculo.Text);
                    _ceVentas.Id_Cliente = Convert.ToInt32(txbIdCliente.Text);
                    _ceVentas.Id_Empleado = Convert.ToInt32(txbIdEmpleado.Text);
                    _ceVentas.Fecha_Venta = dateTimePickerFechadeVenta.Value;
                    _ceVentas.Precio_Venta = Convert.ToDecimal(txbPrecioDeVenta.Text);
                    _ceVentas.Observaciones = txbObservacion.Text;

                    _cnVentas.ActualizarVenta(_ceVentas);

                    MessageBox.Show("Venta actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
