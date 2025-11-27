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
namespace AutoMaster.fmrContacto
{
    public partial class frmInsertarCONTACTO : frm_base
    {
        CN_Contactos _CN_Contactos = new CN_Contactos();
        CE_Contacto _CE_Contacto = new CE_Contacto();
        public frmInsertarCONTACTO()
        {
            InitializeComponent();
        }

        private void frmInsertarCONTACTO_Load(object sender, EventArgs e)
        {

        }

        private void TxbIDEstado_TextChanged(object sender, EventArgs e)
        {

        }
        private void GuardarNuevoContacto()
        {
            try
            {
                // 1. VALIDACIÓN: Verificamos que las cajas de texto no estén vacías
                // (Clonado estrictamente de su lógica if/else)
                if (txbIdPersona.Text == string.Empty || txbIDTipoDeContacto.Text == string.Empty ||
                    txbContacto.Text == string.Empty || TxbIDEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   _CE_Contacto.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                    _CE_Contacto.Id_Tipo_Contacto = Convert.ToInt32(txbIDTipoDeContacto.Text);

                    _CE_Contacto.Contacto = txbContacto.Text;

                   _CE_Contacto.Principal = checkBoxactivoContacto.Checked;

                    _CE_Contacto.Id_Estado = Convert.ToInt32(TxbIDEstado.Text);

                    // 3. EJECUCIÓN: Llamada a la Capa de Negocio
                    _CN_Contactos.insertar_contacto(_CE_Contacto);

                    // 4. CONFIRMACIÓN Y CIERRE
                    MessageBox.Show("Contacto guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // Manejo de Excepciones clonado
                MessageBox.Show("Error al guardar el contacto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoContacto();
        }
    }
}
