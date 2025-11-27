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
    public partial class FrmInsertarContactoProveedor : frm_base
    {
        CN_ContactoProveedores _contPro = new CN_ContactoProveedores();
        CE_ContactoProveedor _ceContPro = new CE_ContactoProveedor();

        public FrmInsertarContactoProveedor()
        {
            InitializeComponent();
        }

        private void FrmInsertarContactoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoContacto();

        }
        private void GuardarNuevoContacto()
        {
            try
            {
                if (txbIdContactoProveedor.Text == string.Empty || txbIdContactoProveedor.Text == string.Empty)
                {
                    MessageBox.Show("Faltan los identificadores (Proveedor o Contacto)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceContPro.Id_Proveedor = Convert.ToInt32(txbIdProveedor.Text);
                    _ceContPro.Id_Contacto = Convert.ToInt32(txbIdContactoProveedor.Text);
                    _ceContPro.ContactoPrincipal = checkContactoProveedorPrincipal.Checked;

                    _contPro.InsertarContactoProveedor(_ceContPro);

                    MessageBox.Show("Relación Proveedor-Contacto guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
