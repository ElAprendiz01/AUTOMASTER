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
using CAPA_ENTIDAD;

namespace AutoMaster
{
    public partial class frm_insertar_Nuevo_TipoDeCatalogo : frm_base
    {
        CNtipoDeCatalogos  _CNTipoCatalogo = new CNtipoDeCatalogos();
        CEtipoDeCatalogo _ceTipoCatalogo = new CEtipoDeCatalogo();
        public frm_insertar_Nuevo_TipoDeCatalogo()
        {
            InitializeComponent();
        }

        private void frmNuevoTipoDeCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        // nuevo metodo para guardar nuevo tipo de catalogo
        private void GuardarNuevoTipoCatalogo()
        {
            try
            {
                if (txbCodigo.Text == string.Empty || txbtipoDeCatalogo.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                    _ceTipoCatalogo.Codigo = txbCodigo.Text;
                    _ceTipoCatalogo.Tipo_Catalogo = txbtipoDeCatalogo.Text;
                    _ceTipoCatalogo.Activo = checkBoxactivoTipoDeCatalogo.Checked;
                    _CNTipoCatalogo.InsertarTipoDeCatalogo(_ceTipoCatalogo);
                    MessageBox.Show("Tipo de Catálogo guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // Messagebox de error 
                MessageBox.Show("Error al guardar el catálogo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoTipoCatalogo();
        }
    }
}
