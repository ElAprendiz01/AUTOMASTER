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

namespace AutoMaster
{
    public partial class Frm_insertar_Nuevo_catalogo : frm_base
    {
        CNCatalogo _CNCatalogo = new CNCatalogo();
        CE_CATALOGO _ceCatalogo = new CE_CATALOGO();
        public Frm_insertar_Nuevo_catalogo()
        {
            InitializeComponent();
        }

        private void FrmAgregarNuevo_catalogo_Load(object sender, EventArgs e)
        {
            listarSoloID();

            CPEstilos.AplicarEstilosProfesionales(listarIdTipoCat);
        }

        private void Lbl_IdTipoCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void txbIDTIPOCATALOGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listarSoloID()
        {
            listarIdTipoCat.DataSource = _CNCatalogo.CNListarIdtipodecatalogoYSuNombre();

            CPEstilos.AplicarEstilosProfesionales(listarIdTipoCat);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoCatalogo();
        }
        // metodo para Guardar nuevo catalogo
        private void GuardarNuevoCatalogo()
        {
            try
            {
                if (txbCodigoCatalogo.Text == string.Empty|| txbCodigoCatalogo.Text == string.Empty || txbIDTIPOCATALOGO.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceCatalogo.Id_Tipo_Catalogo = Convert.ToInt32(txbIDTIPOCATALOGO.Text);
                    _ceCatalogo.Codigo = txbCodigoCatalogo.Text;
                    _ceCatalogo.Catalogo = txbNombreCatalogo.Text;
                    _ceCatalogo.Activo = checkBoxactivoCatalogo.Checked;
                    _CNCatalogo.insertar_catalogo(_ceCatalogo);
                    MessageBox.Show("Catálogo guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // Messagebox de error 
                MessageBox.Show("Error al guardar el catálogo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
