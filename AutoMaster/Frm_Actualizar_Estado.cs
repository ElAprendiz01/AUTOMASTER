using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
namespace AutoMaster
{
    public partial class Frm_Actualizar_Estado : frm_base
    {
        CEestado _ceEstado = new CEestado();
        CNEstado _cnEstado = new CNEstado();
        public Frm_Actualizar_Estado()
        {
            InitializeComponent();
        }

        private void ActualizarEstado_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar_estado();
        }
        #region Actualizar_estado 
        private void Actualizar_estado()
        {

            try
            {
                if (txbCodigoEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    _ceEstado.Id_Estado = Convert.ToInt32(TxbIdEstado.Text);
                    _ceEstado.Estado = txbCodigoEstado.Text;
                    _ceEstado.Activo = checkBoxactivoEstado.Checked;
                    // importante mandar a llamar la capa de negocio para que haga el resto de la chamba 
                    _cnEstado.EditarEstado(_ceEstado);
                    MessageBox.Show("Estado guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // Messagebox de error 
                MessageBox.Show("Error al guardar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
