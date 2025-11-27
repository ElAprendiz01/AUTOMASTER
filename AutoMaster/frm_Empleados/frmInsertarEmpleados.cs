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
    public partial class frmInsertarEmpleados : frm_base
    {
        CE_Empelados En_Empelados = new CE_Empelados();
        CN_Empleados _cnEmpleados = new CN_Empleados();
        public frmInsertarEmpleados()
        {
            InitializeComponent();
        }

        private void frmInsertarEmpleados_Load(object sender, EventArgs e)
        {

        }
        private void GuardarNuevoEmpleado()
        {
            try
            {
                // 1. VALIDACIÓN: Verificamos que las cajas de texto no estén vacías
                if (txbIdPersona.Text == string.Empty || txbIDCargo.Text == string.Empty ||
                    TxbIDArea.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    En_Empelados.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                    En_Empelados.Id_Cargo = Convert.ToInt32(txbIDCargo.Text);
                    En_Empelados.Id_Area = Convert.ToInt32(TxbIDArea.Text);

                    En_Empelados.Activo = checkBoxactivoEmpleado.Checked;

                   _cnEmpleados.insertar_empleado(En_Empelados);

                   MessageBox.Show("Empleado guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoEmpleado();
        }
    }
}
