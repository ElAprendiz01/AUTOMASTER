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

namespace AutoMaster.frm_Empleados
{
    public partial class frmActualizarEmpelados : frm_base
    {
        CE_Empelados En_Empelados = new CE_Empelados();
        CN_Empleados _cnEmpleados = new CN_Empleados();
        public frmActualizarEmpelados()
        {
            InitializeComponent();
        }

        private void frmActualizarEmpelados_Load(object sender, EventArgs e)
        {

        }

        private void txbIdPersona_TextChanged(object sender, EventArgs e)
        {

        }
        private void Actualizar()
        {
            try
            {
                if (txbIdEmpleado.Text == string.Empty || txbIdPersona.Text == string.Empty ||
                    txbIDCargo.Text == string.Empty || TxbIDArea.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    En_Empelados.Id_Empleado = Convert.ToInt32(txbIdEmpleado.Text);
                    En_Empelados.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                    En_Empelados.Id_Cargo = Convert.ToInt32(txbIDCargo.Text);
                    En_Empelados.Id_Area = Convert.ToInt32(TxbIDArea.Text);
                    En_Empelados.Activo = checkBoxactivoEmpleado.Checked;

                    _cnEmpleados.ActualizarEmpleado(En_Empelados);

                    MessageBox.Show("Empleado actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
