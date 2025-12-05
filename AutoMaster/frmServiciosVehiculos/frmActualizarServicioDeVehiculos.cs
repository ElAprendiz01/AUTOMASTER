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

namespace AutoMaster.frmServiciosVehiculos
{
    public partial class frmActualizarServicioDeVehiculos : frm_base
    {
        NSServicioVehiculo _cnServicio = new NSServicioVehiculo();
        CE_ServicioDeVehiculosr _ceServicio = new CE_ServicioDeVehiculosr();

        public frmActualizarServicioDeVehiculos()
        {
            InitializeComponent();
        }

        private void frmActualizarServicioDeVehiculos_Load(object sender, EventArgs e)
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
                if (iDsERVICIOvEHICULOS.Text == string.Empty ||
                    TXBIdVehiculo.Text == string.Empty ||
                    txbIDTipoDeServicio.Text == string.Empty ||
                    TxbCosto.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceServicio.Id_Servicio = Convert.ToInt32(iDsERVICIOvEHICULOS.Text);
                    _ceServicio.Id_Vehiculo = Convert.ToInt32(TXBIdVehiculo.Text);
                    _ceServicio.Id_Tipo_Servicio = Convert.ToInt32(txbIDTipoDeServicio.Text);
                    _ceServicio.Costo = Convert.ToDecimal(TxbCosto.Text);
                    _ceServicio.Observaciones = txbObservaciones.Text;
                    _ceServicio.Fecha_Servicio = dateTimePickerFechaDeServicio.Value;

                    if (string.IsNullOrWhiteSpace(IDTRabajador.Text))
                    {
                        _ceServicio.Id_Empleado = 0;
                    }
                    else
                    {
                        _ceServicio.Id_Empleado = Convert.ToInt32(IDTRabajador.Text);
                    }

                    _cnServicio.ActualizarServicio(_ceServicio);

                    MessageBox.Show("Servicio actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbIDTipoDeServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXBIdVehiculo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
