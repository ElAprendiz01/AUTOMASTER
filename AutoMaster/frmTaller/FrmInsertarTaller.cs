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
    public partial class FrmInsertarTaller : frm_base
    {
        CN_TALLER _cnTaller = new CN_TALLER();
        CE_Taller _ceTaller = new CE_Taller();
        public FrmInsertarTaller()
        {
            InitializeComponent();
        }

        private void FrmInsertarTaller_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoTaller();
        }
        private void GuardarNuevoTaller()
        {
            try
            {
                
                if (TXBIdVehiculo.Text == string.Empty ||
                    txbDescripcionDelTrabjo.Text == string.Empty)
                {
                    MessageBox.Show("Llena los campos obligatorios (Vehículo, Descripción)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                  
                    _ceTaller.Id_Vehiculo = Convert.ToInt32(TXBIdVehiculo.Text);
                    _ceTaller.Descripcion_Trabajo = txbDescripcionDelTrabjo.Text;
                    _ceTaller.Fecha_Ingreso = dateTimePickerFechaDeIngreso.Value;

                    
                    _ceTaller.Fecha_Salida = dateTimePickerFechaDeSalida.Value;

                    if (string.IsNullOrEmpty(TxbCosto.Text))
                    {
                        _ceTaller.Costo = null;
                    }
                    else
                    {
                        _ceTaller.Costo = Convert.ToDecimal(TxbCosto.Text);
                    }

                
                    if (string.IsNullOrEmpty(IDTRabajador.Text))
                    {
                        _ceTaller.Id_Responsable = null;
                    }
                    else
                    {
                        _ceTaller.Id_Responsable = Convert.ToInt32(IDTRabajador.Text);
                    }

                  
                    _cnTaller.InsertarTaller(_ceTaller);

                    MessageBox.Show("Taller guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Taller: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
