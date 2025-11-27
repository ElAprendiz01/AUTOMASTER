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

namespace AutoMaster.frmCliente
{
    public partial class frmActualizarCliente : frm_base
    {
        CN_Cliente _CNContacto = new CN_Cliente();
        CE_clientes _CEContacto = new CE_clientes();
        public frmActualizarCliente()
        {
            InitializeComponent();
        }

        private void frmActualizarCliente_Load(object sender, EventArgs e)
        {

        }
        private void Actualizar()
        {
            try
            {
               
                if (txbIDEmpleado.Text == string.Empty || txbIdPersona.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    

                    _CEContacto.Id_Cliente = Convert.ToInt32(txbIDEmpleado.Text);
                    _CEContacto.Id_Persona = Convert.ToInt32(txbIdPersona.Text);

               
                    _CEContacto.Activo = checkBoxactivoEmpleado.Checked;

                
                    _CNContacto.ActualizarCliente(_CEContacto);

              
                    MessageBox.Show("Cliente actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
