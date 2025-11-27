using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;
namespace AutoMaster.fmrContacto
{
    public partial class frmActualizarCONTACTO : frm_base
    {
        CN_Contactos _CN_Contactos = new CN_Contactos();
        CE_Contacto _CE_Contacto = new CE_Contacto();
        public frmActualizarCONTACTO()
        {
            InitializeComponent();
        }

        private void frmActualizarCONTACTO_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actualizar();

        }
        private void Actualizar()
        {
            try
            {
                if (txbIdContacto.Text == string.Empty || txbIdPersona.Text == string.Empty ||
                    txbIDTipoDeContacto.Text == string.Empty || txbContacto.Text == string.Empty ||
                    TxbIDEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CE_Contacto.Id_Contacto = Convert.ToInt32(txbIdContacto.Text);
                    _CE_Contacto.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                    _CE_Contacto.Id_Tipo_Contacto = Convert.ToInt32(txbIDTipoDeContacto.Text);
                    _CE_Contacto.Contacto = txbContacto.Text;
                    _CE_Contacto.Principal = checkBoxactivoContactocheckBoxactivoContacto.Checked;
                    _CE_Contacto.Id_Estado = Convert.ToInt32(TxbIDEstado.Text);

                    _CN_Contactos.ActualizarContacto(_CE_Contacto);

                    MessageBox.Show("Contacto actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el contacto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
