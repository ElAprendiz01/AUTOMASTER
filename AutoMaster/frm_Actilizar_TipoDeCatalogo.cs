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
    public partial class frm_Actilizar_TipoDeCatalogo : frm_base
    {
        CNtipoDeCatalogos _cnTipoCatalog = new CNtipoDeCatalogos();
        CEtipoDeCatalogo _ceTipoCatalogo = new CEtipoDeCatalogo();
        public frm_Actilizar_TipoDeCatalogo()
        {
            InitializeComponent();
        }

        private void frmActilizarTipoDeCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actualizar();

        }
        // metodo para actualizar tipo de catalogo
        private void Actualizar()
        {

            try
            {
                if (txbCodigo.Text == string.Empty || txbIdTipoDeCatalogo.Text == string.Empty )
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceTipoCatalogo.Id_Tipo_Catalogo = Convert.ToInt32(txbIdTipoDeCatalogo.Text);
                    _ceTipoCatalogo.Codigo = txbCodigo.Text;
                    _ceTipoCatalogo.Tipo_Catalogo = txbtipoDeCatalogo.Text;
                    _ceTipoCatalogo.Activo = checkBoxactivoTipoDeCatalogo.Checked;
                    _cnTipoCatalog.ActualizarTipoDeCatalogo(_ceTipoCatalogo);
                    MessageBox.Show(" Tipo de Catálogo guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // Messagebox de error 
                MessageBox.Show("Error al guardar el Tipo de catálogo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
