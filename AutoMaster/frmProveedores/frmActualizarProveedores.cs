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

namespace AutoMaster.frmProveedores
{
    public partial class frmActualizarProveedores : frm_base
    {
        CN_Proveedores _cnProvee = new CN_Proveedores();
        CE_Proveedores _ceProvee = new CE_Proveedores();
        public frmActualizarProveedores()
        {
            InitializeComponent();
        }

        private void frmActualizarProveedores_Load(object sender, EventArgs e)
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
                if (txbId_Proveedor.Text == string.Empty || txbNomEmpresa.Text == string.Empty ||
                    txbRUC.Text == string.Empty || TxbIDEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos obligatorios", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceProvee.Id_Proveedor = Convert.ToInt32(txbId_Proveedor.Text);
                    _ceProvee.Representante = string.IsNullOrEmpty(txbIdRepresentante.Text) ? (int?)null : Convert.ToInt32(txbIdRepresentante.Text);
                    _ceProvee.Nombre_Empresa = txbNomEmpresa.Text;
                    _ceProvee.RUC_Empresa = txbRUC.Text;
                    _ceProvee.Id_Estado = Convert.ToInt32(TxbIDEstado.Text);

                    _cnProvee.ActualizarProveedor(_ceProvee);

                    MessageBox.Show("Proveedor actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbelCodigoCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_IdTipoCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void txbId_Proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbIDEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNomEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbIdRepresentante_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
