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

namespace AutoMaster.frmContactoProveedor
{
    public partial class frmActualizarContactoProveedor : frm_base
    {
        CN_ContactoProveedores _contPro = new CN_ContactoProveedores();
        CE_ContactoProveedor _ceContPro = new CE_ContactoProveedor();
        public frmActualizarContactoProveedor()
        {
            InitializeComponent();
        }

        private void frmActualizarContactoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void txbIDTipoDeContacto_TextChanged(object sender, EventArgs e)
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
                if (txbIdContacto.Text == string.Empty || txbIdContactoProveedor.Text == string.Empty)
                {
                    MessageBox.Show("Faltan los identificadores para ubicar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceContPro.Id_Proveedor = Convert.ToInt32(txbIdContactoProveedor.Text);
                    _ceContPro.Id_Contacto = Convert.ToInt32(txbIdContacto.Text);
                    _ceContPro.ContactoPrincipal = checkContactoProveedorPrincipal.Checked;

                    _contPro.ActualizarContactoProveedor(_ceContPro);

                    MessageBox.Show("Relación Proveedor-Contacto actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
