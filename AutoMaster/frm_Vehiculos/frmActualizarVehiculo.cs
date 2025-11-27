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

namespace AutoMaster.frm_Vehiculos
{
    public partial class frmActualizarVehiculo : frm_base
    {

        CN_Vehiculos _cnVehiculos = new CN_Vehiculos();
        CE_Vehiculo _ceVehiculos = new CE_Vehiculo();
        public frmActualizarVehiculo()
        {
            InitializeComponent();
        }

        private void frmActualizarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void Actualizar()
        {
            try
            {
                if (txbIdVehiculos.Text == string.Empty || txbIDPRoveedor.Text == string.Empty ||
                    txbMarca.Text == string.Empty || TXBModelo.Text == string.Empty ||
                    txbAño.Text == string.Empty || txbSerieMotor.Text == string.Empty ||
                    txbPrecio.Text == string.Empty || txbIdEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceVehiculos.Id_Vehiculo = Convert.ToInt32(txbIdVehiculos.Text);
                    _ceVehiculos.Id_Proveedor = Convert.ToInt32(txbIDPRoveedor.Text);
                    _ceVehiculos.Marca = txbMarca.Text;
                    _ceVehiculos.Modelo = TXBModelo.Text;
                    _ceVehiculos.Anio = Convert.ToInt32(txbAño.Text);
                    _ceVehiculos.Serie_Chasis = txbSerieChasis.Text;
                    _ceVehiculos.Serie_Motor = txbSerieMotor.Text;
                    _ceVehiculos.Precio = Convert.ToDecimal(txbPrecio.Text);
                    _ceVehiculos.Id_Estado = Convert.ToInt32(txbIdEstado.Text);
                    _ceVehiculos.Fecha_Ingreso_Pais = dateTimePickcFechaIngresoPAis.MaxDate;

                    _cnVehiculos.ActualizarVehiculo(_ceVehiculos);

                    MessageBox.Show("Vehículo actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
