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

namespace AutoMaster.frmDirecciones
{
    public partial class frmInsertarDirecciones : frm_base
    {
        CN_Direcciones _cnDirecciones = new CN_Direcciones();
        CE_Direcciones _ceDirecciones = new CE_Direcciones();

        public frmInsertarDirecciones()
        {
            InitializeComponent();
        }

        private void frmInsertarDirecciones_Load(object sender, EventArgs e)
        {

        }
        private void GuardarNuevaDireccion()
        {
            try
            {
                if (txbIdPersona.Text == string.Empty || txbDireccion.Text == string.Empty ||
                    txbCiudad.Text == string.Empty || txbDepartamento.Text == string.Empty ||
                    TxbIDEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ceDirecciones.Id_Persona = Convert.ToInt32(txbIdPersona.Text);
                    _ceDirecciones.Direccion = txbDireccion.Text;
                    _ceDirecciones.Ciudad = txbCiudad.Text;
                    _ceDirecciones.Departamento = txbDepartamento.Text;
                    _ceDirecciones.Principal = checkBoxactivoDirecciones.Checked;
                    _ceDirecciones.Id_Estado = Convert.ToInt32(TxbIDEstado.Text);

                    _cnDirecciones.InsertarDirecciones(_ceDirecciones);

                    MessageBox.Show("Dirección guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la dirección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevaDireccion();
        }
    }
}
