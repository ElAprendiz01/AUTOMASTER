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
    public partial class frmPrinVehiculos : frm_base
    {
        CN_Vehiculos _cnVehiculos = new CN_Vehiculos();
        CE_Vehiculo _ceVehiculos = new CE_Vehiculo();
        public frmPrinVehiculos()
        {
            InitializeComponent();
        }

        private void frmPrinVehiculos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void dataGridViewListarVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listar()
        {
            dataGridViewListarVehiculos.DataSource = _cnVehiculos.CNListarVehiculos();
            if (dataGridViewListarVehiculos.Columns.Contains("Anio"))
            {
                dataGridViewListarVehiculos.Columns["Anio"].Visible = false;
            }

            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarVehiculos);
        }

        private void ActualizarVehiculo()
        {
            if (dataGridViewListarVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo para actualizar");
            }
            else
            {
                try
                {
                    frmActualizarVehiculo ventActualizar = new frmActualizarVehiculo();

                    ventActualizar.txbIdVehiculos.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Id_Vehiculo"].Value.ToString();
                    ventActualizar.txbIDPRoveedor.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Id_Proveedor"].Value.ToString();
                    ventActualizar.txbMarca.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Marca"].Value.ToString();
                    ventActualizar.TXBModelo.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Modelo"].Value.ToString();
                    ventActualizar.txbAño.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Año"].Value.ToString();
                    ventActualizar.txbSerieChasis.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Serie_Chasis"].Value.ToString();
                    ventActualizar.txbSerieMotor.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Serie_Motor"].Value.ToString();
                    ventActualizar.txbPrecio.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Precio"].Value.ToString();
                    ventActualizar.txbIdEstado.Text = dataGridViewListarVehiculos.CurrentRow.Cells["Id_Estado"].Value.ToString();
                    object valorCelda = dataGridViewListarVehiculos.CurrentRow.Cells["Fecha_Ingreso_Pais"].Value;

                    if (valorCelda != DBNull.Value && valorCelda != null)
                    {
                        ventActualizar.dateTimePickcFechaIngresoPAis.Value = Convert.ToDateTime(valorCelda);
                    }
                    else
                    {
                        ventActualizar.dateTimePickcFechaIngresoPAis.Value = DateTime.Now; // o cualquier valor por defecto
                    }

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el vehículo:  {ex.Message}, ", "Editar Vehículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarVehiculo();
            listar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frnInsertarVehiculos ventnuevovehiculo = new frnInsertarVehiculos();
            ventnuevovehiculo.ShowDialog();
            listar();
        }
    }
}
