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
    public partial class frmPrinFinanciamiento : frm_base
    {
        CN_Financiamiento _cnFinanciamiento = new CN_Financiamiento();
        CE_Financiamiento _crfin = new CE_Financiamiento();
        public frmPrinFinanciamiento()
        {
            InitializeComponent();
        }

        private void frmPrinFinanciamiento_Load(object sender, EventArgs e)
        {
            ListarFiannciamiento();

        }

        public void ListarFiannciamiento()  
        {
            dataGridViewListarFinanciamiento.DataSource = _cnFinanciamiento.ListarFinanciamientos();


            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarFinanciamiento);
        }
        private void ActualizarFinanciamiento()
        {
            if (dataGridViewListarFinanciamiento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un financiamiento para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    frmActualizarFinanciamiento ventActualizar = new frmActualizarFinanciamiento();
                    DataGridViewRow fila = dataGridViewListarFinanciamiento.CurrentRow;

                    ventActualizar.txbIdFinanciamiento.Text = fila.Cells["Id_Financiamiento"].Value.ToString();
                    ventActualizar.txbIDVenta.Text = fila.Cells["Id_Venta"].Value.ToString();
                    ventActualizar.txbIDClinte.Text = fila.Cells["Id_Cliente"].Value.ToString();
                    ventActualizar.TXBMonto.Text = fila.Cells["Monto"].Value.ToString();
                    ventActualizar.txbplazoEnElMes.Text = fila.Cells["Plazo_Meses"].Value.ToString();

                    object valTasa = fila.Cells["Tasa_Interes"].Value;
                    if (valTasa != DBNull.Value && valTasa != null)
                    {
                        ventActualizar.txbTasaDeInteres.Text = valTasa.ToString();
                    }
                    else
                    {
                        ventActualizar.txbTasaDeInteres.Text = "0.00";
                    }

                    ventActualizar.dateTimePickcFechaInicio.Value = Convert.ToDateTime(fila.Cells["Fecha_Inicio"].Value);

                    object valFechaCancel = fila.Cells["Fecha_Cancelacion"].Value;
                    if (valFechaCancel != DBNull.Value && valFechaCancel != null)
                    {
                        ventActualizar.dateTimePickerFechadeCanselacion.Value = Convert.ToDateTime(valFechaCancel);
                    }
                    else
                    {
                        ventActualizar.dateTimePickerFechadeCanselacion.Value = DateTime.Now;
                    }

                    ventActualizar.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos para actualizar: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarFinanciamiento();
            ListarFiannciamiento();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            FrmInsertarfinanciamiento frmInsertarfinanciamiento = new FrmInsertarfinanciamiento();
            frmInsertarfinanciamiento.ShowDialog();
            ListarFiannciamiento();
        }

        private void btnElimianar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListarFinanciamiento.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un financiamiento de la lista para eliminarlo.", "Acción Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string valorId = dataGridViewListarFinanciamiento.CurrentRow.Cells["Id_Financiamiento"].Value.ToString();

                    if (string.IsNullOrEmpty(valorId))
                    {
                        MessageBox.Show("Error Crítico: No se pudo identificar el ID del financiamiento seleccionado.", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show($"¿Está completamente seguro de eliminar el Financiamiento #{valorId}? Esta acción es irreversible.", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _crfin.Id_Financiamiento = Convert.ToInt32(valorId);

                            _cnFinanciamiento.EliminarFinanciamiento(_crfin);

                            MessageBox.Show("Registro eliminado correctamente.", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ListarFiannciamiento();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fatal al intentar eliminar: {ex.Message}", "Fallo de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridViewListarFinanciamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
           
        


        }
    }
}
