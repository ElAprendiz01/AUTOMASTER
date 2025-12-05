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
    public partial class frmInsertarVentas : frm_base
    {

        CN_Ventas _cnVentas = new CN_Ventas();
        CE_Ventas _ceVentas = new CE_Ventas();
        public frmInsertarVentas()
        {
            InitializeComponent();
        }

        private void frmInsertarVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarNuevaVenta();
        }
        private void GuardarNuevaVenta()
        {
            try
            {
                if (txbIDVehiculo.Text == string.Empty || txbIdCliente.Text == string.Empty ||
                    txbIdEmpleado.Text == string.Empty || txbPrecioDeVenta.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos requeridos", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceVentas.Id_Vehiculo = Convert.ToInt32(txbIDVehiculo.Text);
                    _ceVentas.Id_Cliente = Convert.ToInt32(txbIdCliente.Text);
                    _ceVentas.Id_Empleado = Convert.ToInt32(txbIdEmpleado.Text);
                    _ceVentas.Precio_Venta = Convert.ToDecimal(txbPrecioDeVenta.Text);
                    _ceVentas.Observaciones = txbObservacion.Text;

                    // El SP genera la Fecha automáticamente.
                    _cnVentas.InsertarVenta(_ceVentas);

                    MessageBox.Show("Venta guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
