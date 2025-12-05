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

namespace AutoMaster.frmTaller
{
    public partial class frmActualizarTaller : frm_base
    {
        CN_TALLER _cnTaller = new CN_TALLER();
        CE_Taller _ceTaller = new CE_Taller();
        public frmActualizarTaller()
        {
            InitializeComponent();
        }

        private void frmActualizarTaller_Load(object sender, EventArgs e)
        {

        }

        private void txbDescripcionDelTrabjo_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void TXBIdVehiculo_TextChanged(object sender, EventArgs e)
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
                // Validación de campos obligatorios (NOT NULL en Base de Datos)
                if (txbIdTaller.Text == string.Empty ||
                    TXBIdVehiculo.Text == string.Empty ||
                    txbDescripcionDelTrabjo.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos obligatorios", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceTaller.Id_Taller = Convert.ToInt32(txbIdTaller.Text);
                    _ceTaller.Id_Vehiculo = Convert.ToInt32(TXBIdVehiculo.Text);
                    _ceTaller.Descripcion_Trabajo = txbDescripcionDelTrabjo.Text;
                    _ceTaller.Fecha_Ingreso = dateTimePickerFechaDeIngreso.Value;
                    _ceTaller.Fecha_Salida = dateTimePickerFechaDeSalida.Value;

                    // Manejo seguro de campos Nullable (Costo)
                    if (string.IsNullOrEmpty(TxbCosto.Text))
                    {
                        _ceTaller.Costo = null;
                    }
                    else
                    {
                        _ceTaller.Costo = Convert.ToDecimal(TxbCosto.Text);
                    }

                    // Manejo seguro de campos Nullable (Responsable)
                    if (string.IsNullOrEmpty(IDTRabajador.Text))
                    {
                        _ceTaller.Id_Responsable = null;
                    }
                    else
                    {
                        _ceTaller.Id_Responsable = Convert.ToInt32(IDTRabajador.Text);
                    }

                    _cnTaller.ActualizarTaller(_ceTaller);

                    MessageBox.Show("Taller actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Taller: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
