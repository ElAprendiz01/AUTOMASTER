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
    public partial class frmInsertarServicioDeVehiculos : frm_base
    {
        public frmInsertarServicioDeVehiculos()
        {
            InitializeComponent();
        }

        private void frmInsertarServicioDeVehiculos_Load(object sender, EventArgs e)
        {

        }
        NSServicioVehiculo _cnServicio = new NSServicioVehiculo();
        CE_ServicioDeVehiculosr _ceServicio = new CE_ServicioDeVehiculosr();

        private void GuardarNuevoServicio()
        {
            try
            {
                if (TXBIdVehiculo.Text == string.Empty ||
                    txbIDTipoDeServicio.Text == string.Empty ||
                    TxbCosto.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceServicio.Id_Vehiculo = Convert.ToInt32(TXBIdVehiculo.Text);
                    _ceServicio.Id_Tipo_Servicio = Convert.ToInt32(txbIDTipoDeServicio.Text);
                    _ceServicio.Fecha_Servicio = dateTimePickerFechaDeServicio.Value;
                    _ceServicio.Costo = Convert.ToDecimal(TxbCosto.Text);
                    _ceServicio.Observaciones = txbObservaciones.Text;

                    if (string.IsNullOrWhiteSpace(IDTRabajador.Text))
                    {
                        _ceServicio.Id_Empleado = 0;
                    }
                    else
                    {
                        _ceServicio.Id_Empleado = Convert.ToInt32(IDTRabajador.Text);
                    }

                    _cnServicio.InsertarServicio(_ceServicio);

                    MessageBox.Show("Servicio guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoServicio();
        }
    }
}
