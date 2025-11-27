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

namespace AutoMaster.frmProveedores
{
    public partial class frmInsertarProveedores : frm_base
    {
        CN_Proveedores _cnProvee = new CN_Proveedores();
        CE_Proveedores _ceProvee = new CE_Proveedores();
        public frmInsertarProveedores()
        {
            InitializeComponent();
        }

        private void frmInsertarProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoProveedor();
        }
        private void GuardarNuevoProveedor()
        {
            try
            {
                if (txbNomEmpresa.Text == string.Empty ||
                    txbRUC.Text == string.Empty || TxbIDEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos obligatorios", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceProvee.Representante = string.IsNullOrEmpty(txbIdRepresentante.Text) ? (int?)null : Convert.ToInt32(txbIdRepresentante.Text);
                    _ceProvee.Nombre_Empresa = txbNomEmpresa.Text;
                    _ceProvee.RUC_Empresa = txbRUC.Text;
                    _ceProvee.Id_Estado = Convert.ToInt32(TxbIDEstado.Text);

                    _cnProvee.InsertarProveedor(_ceProvee);

                    MessageBox.Show("Proveedor guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
