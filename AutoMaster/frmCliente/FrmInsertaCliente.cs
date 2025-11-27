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
namespace AutoMaster.frmCliente
{
    public partial class FrmInsertaCliente : frm_base
    {
        CN_Cliente _CNContacto = new CN_Cliente();
        CE_clientes _CEContacto = new CE_clientes();
        public FrmInsertaCliente()
        {
            InitializeComponent();
        }

        private void FrmInsertaCliente_Load(object sender, EventArgs e)
        {
            
        }
        private void guardar()
        {
            try
            {

                _CEContacto.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                _CEContacto.Activo = checkBoxactivoEmpleado.Checked;

                _CNContacto.InsertarCliente(_CEContacto);

                MessageBox.Show("Cliente actualizado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
