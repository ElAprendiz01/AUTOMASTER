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

namespace AutoMaster.frmDirecciones
{
    public partial class frmActualizarDirecciones : frm_base
    {
        CE_Direcciones _ceDirecciones = new CE_Direcciones();
        CN_Direcciones _cnDirecciones = new CN_Direcciones();
        public frmActualizarDirecciones()
        {
            InitializeComponent();
        }

        private void frmActualizarDirecciones_Load(object sender, EventArgs e)
        {

        }

        private void txbDepartamento_TextChanged(object sender, EventArgs e)
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
                if (txbIdDireccion.Text == string.Empty || txbIdPersona.Text == string.Empty ||
                    txbDireccion.Text == string.Empty || txbCiudad.Text == string.Empty ||
                    txbDepartamento.Text == string.Empty || TxbIDEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceDirecciones.Id_Direccion = Convert.ToInt32(txbIdDireccion.Text);
                    _ceDirecciones.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                    _ceDirecciones.Direccion = txbDireccion.Text;
                    _ceDirecciones.Ciudad = txbCiudad.Text;
                    _ceDirecciones.Departamento = txbDepartamento.Text;
                    _ceDirecciones.Principal = checkBoxactivoDirecciones.Checked;
                    _ceDirecciones.Id_Estado = Convert.ToInt32(TxbIDEstado.Text);

                    _cnDirecciones.ActualizarDirecciones(_ceDirecciones);

                    MessageBox.Show("Dirección actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la dirección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
