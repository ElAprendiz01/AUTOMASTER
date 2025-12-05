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
    public partial class frmPrinServicioDeVehiculos : frm_base
    {
        NSServicioVehiculo nSServicioVehiculo = new NSServicioVehiculo();
        CE_ServicioDeVehiculosr cE_ServicioDeVehiculosr = new CE_ServicioDeVehiculosr();

        public frmPrinServicioDeVehiculos()
        {
            InitializeComponent();
        }
         
        private void frmPrinServicioDeVehiculos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarServicio();
            listar();   

        }
        private void ActualizarServicio()
        {
            if (dataGridViewListarSERVICIOdEvEHICULOS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un servicio para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    frmActualizarServicioDeVehiculos ventActualizar = new frmActualizarServicioDeVehiculos();
                    DataGridViewRow fila = dataGridViewListarSERVICIOdEvEHICULOS.CurrentRow;

                    ventActualizar.iDsERVICIOvEHICULOS.Text = fila.Cells["Id_Servicio"].Value.ToString();
                    ventActualizar.TXBIdVehiculo.Text = fila.Cells["Id_Vehiculo"].Value.ToString();
                    ventActualizar.txbIDTipoDeServicio.Text = fila.Cells["Id_Tipo_Servicio"].Value.ToString();

                    object valTrabajador = fila.Cells["Id_Empleado"].Value;
                    if (valTrabajador != DBNull.Value && valTrabajador != null)
                    {
                        ventActualizar.IDTRabajador.Text = valTrabajador.ToString();
                    }
                    else
                    {
                        ventActualizar.IDTRabajador.Text = "";
                    }

                    object valCosto = fila.Cells["Costo"].Value;
                    ventActualizar.TxbCosto.Text = (valCosto != DBNull.Value && valCosto != null) ? valCosto.ToString() : "0.00";

                    object valObs = fila.Cells["Observaciones"].Value;
                    ventActualizar.txbObservaciones.Text = (valObs != DBNull.Value && valObs != null) ? valObs.ToString() : "";

                    object valFecha = fila.Cells["Fecha_Servicio"].Value;
                    if (valFecha != DBNull.Value && valFecha != null)
                    {
                        ventActualizar.dateTimePickerFechaDeServicio.Value = Convert.ToDateTime(valFecha);
                    }
                    else
                    {
                        ventActualizar.dateTimePickerFechaDeServicio.Value = DateTime.Now;
                    }

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos para actualizar: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listar()
        {
            dataGridViewListarSERVICIOdEvEHICULOS.DataSource = nSServicioVehiculo.CNListarServiciosVehiculos();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarSERVICIOdEvEHICULOS);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarServicioDeVehiculos frmservi = new frmInsertarServicioDeVehiculos();
            frmservi.ShowDialog();
            listar();
        }
    }
}
