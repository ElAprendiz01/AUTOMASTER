using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace AutoMaster
{
    public partial class frm_Actualizar_DatosPersonales : frm_base
    {
        CNDatosPersonales _cnDatosPersonales = new CNDatosPersonales();
        CEDatosPersonales _ceDatosPersonales = new CEDatosPersonales();
        public frm_Actualizar_DatosPersonales()
        {
            InitializeComponent();
        }

        private void frm_Actualizar_DatosPersonales_Load(object sender, EventArgs e)
        {

        }

        private void txbSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void Actualizar_DatosPersonales()
        {
            try
            {
                // Validación simple: si algún campo clave está vacío
                if (txbPrimerNombre.Text == string.Empty ||
                    txbPrimerApellido.Text == string.Empty ||
                    txbDNI.Text == string.Empty ||
                    txbIdEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Creamos la entidad y llenamos con TODOS los valores del formulario
                    _ceDatosPersonales.Id_Persona = Convert.ToInt32(txbIdPersonal.Text);
                    _ceDatosPersonales.Primer_Nombre = txbPrimerNombre.Text;
                    _ceDatosPersonales.Segundo_Nombre = txbSegundoNombre.Text;
                    _ceDatosPersonales.Primer_Apellido = txbPrimerApellido.Text;
                    _ceDatosPersonales.Segundo_Apellido = txbSegundoApellido.Text;
                    _ceDatosPersonales.Id_Genero = Convert.ToInt32(txbIdGenero.Text);
                    _ceDatosPersonales.Id_Tipo_DNI = Convert.ToInt32(txbIdTipoDni.Text);
                    _ceDatosPersonales.DNI = txbDNI.Text;
                    _ceDatosPersonales.Id_Estado = Convert.ToInt32(txbIdEstado.Text);

                    // Mandamos a la capa de negocio para que ejecute el SP de actualización
                    _cnDatosPersonales.CnActualizar(_ceDatosPersonales);

                    MessageBox.Show("Datos personales guardados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos personales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actualizar_DatosPersonales();
        }
    }
}
