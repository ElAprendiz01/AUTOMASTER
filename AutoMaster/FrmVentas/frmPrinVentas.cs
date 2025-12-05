using AutoMaster.frm_Financiamiento;
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
    public partial class frmPrinVentas : frm_base
    {
        CN_Ventas _cnVentas = new CN_Ventas();
        CE_Ventas _ceVentas = new CE_Ventas();
        public frmPrinVentas()
        {
            InitializeComponent();
        }

        private void frmPrinVentas_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            dataGridViewListarVVentas.DataSource = _cnVentas.CNListarVentas();

            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarVVentas);
        }
        private void ActualizarVenta()
        {
            if (dataGridViewListarVVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    frmAtualizarVenta ventActualizar = new frmAtualizarVenta();

                    ventActualizar.txbIdVentas.Text = dataGridViewListarVVentas.CurrentRow.Cells["Id_Venta"].Value.ToString();
                    ventActualizar.txbIDVehiculo.Text = dataGridViewListarVVentas.CurrentRow.Cells["Id_Vehiculo"].Value.ToString();
                    ventActualizar.txbIdCliente.Text = dataGridViewListarVVentas.CurrentRow.Cells["Id_Cliente"].Value.ToString();
                    ventActualizar.txbIdEmpleado.Text = dataGridViewListarVVentas.CurrentRow.Cells["Id_Empleado"].Value.ToString();
                    ventActualizar.txbPrecioDeVenta.Text = dataGridViewListarVVentas.CurrentRow.Cells["Precio_Venta"].Value.ToString();
                    ventActualizar.txbObservacion.Text = dataGridViewListarVVentas.CurrentRow.Cells["Observaciones"].Value.ToString();
                    ventActualizar.dateTimePickerFechadeVenta.Value = Convert.ToDateTime(dataGridViewListarVVentas.CurrentRow.Cells["Fecha_Venta"].Value);

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar editar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void financiar()
        {
            FrmInsertarfinanciamiento _finaciamient = new FrmInsertarfinanciamiento();
            _finaciamient.txbIDVenta.Text = dataGridViewListarVVentas.CurrentRow.Cells["Id_Venta"].Value.ToString();
            _finaciamient.txbIDClinte.Text = dataGridViewListarVVentas.CurrentRow.Cells["Id_Cliente"].Value.ToString();
            _finaciamient.TXBMonto.Text = dataGridViewListarVVentas.CurrentRow.Cells["Precio_Venta"].Value.ToString();
            _finaciamient.ShowDialog();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarVenta();
            listar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarVentas _venta = new frmInsertarVentas();
            _venta.ShowDialog();
            listar();
        }

        private void btnElimianar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. PRIMER IF: Validación de Selección en la Grilla
                if (dataGridViewListarVVentas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una venta de la lista para eliminarla.", "Acción Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Capturamos el valor antes de procesarlo
                    string valorId = dataGridViewListarVVentas.CurrentRow.Cells["Id_Venta"].Value.ToString();

                    // 2. SEGUNDO IF: Validación de Integridad del Dato (Defensa contra nulos)
                    if (string.IsNullOrEmpty(valorId))
                    {
                        MessageBox.Show("Error Crítico: No se pudo identificar el ID de la venta seleccionada.", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // 3. TERCER IF: Confirmación de Seguridad (Usuario Final)
                        if (MessageBox.Show($"¿Está completamente seguro de eliminar la Venta #{valorId}? Esta acción es irreversible.", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Inyección de Dependencia a la Entidad
                            _ceVentas.Id_Venta = Convert.ToInt32(valorId);

                            // Ejecución en Capa de Negocio
                            _cnVentas.EliminarVenta(_ceVentas);

                            MessageBox.Show("Registro eliminado correctamente.", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            listar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fatal al intentar eliminar: {ex.Message}", "Fallo de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnfinanciar_Click(object sender, EventArgs e)
        {
            financiar();
        }
    }
}
