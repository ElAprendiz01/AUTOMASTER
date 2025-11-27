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

namespace AutoMaster
{
    public partial class frm_Actualizar_Catalogo : frm_base
    {
        CNCatalogo _CNCatalogo = new CNCatalogo();
        CE_CATALOGO _ceCatalogo = new CE_CATALOGO();
        public frm_Actualizar_Catalogo()
        {
            InitializeComponent();
        }

        private void frmActaulizarCatalogo_Load(object sender, EventArgs e)
        {
            listarSoloID();

            CPEstilos.AplicarEstilosProfesionales(listarIdTipoCat);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void Actualizar() 
        {

            try
            {
                if (txbCodigoCatalogo.Text == string.Empty || txbCodigoCatalogo.Text == string.Empty || txbIDTIPOCATALOGO.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceCatalogo.Id_Catalogo = Convert.ToInt32(txbIDCatalogo.Text);
                    _ceCatalogo.Id_Tipo_Catalogo = Convert.ToInt32(txbIDTIPOCATALOGO.Text);
                    _ceCatalogo.Codigo = txbCodigoCatalogo.Text;
                    _ceCatalogo.Catalogo = txbNombreCatalogo.Text;
                    _ceCatalogo.Activo = checkBoxactivoCatalogo.Checked;
                    _CNCatalogo.ActualizarCatalogo(_ceCatalogo);
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

        private void listarIdTipoCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listarSoloID()
        {
            listarIdTipoCat.DataSource = _CNCatalogo.CNListarIdtipodecatalogoYSuNombre();

            CPEstilos.AplicarEstilosProfesionales(listarIdTipoCat);
        }
    }
}
