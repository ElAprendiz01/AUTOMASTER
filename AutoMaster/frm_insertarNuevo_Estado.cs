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
using CAPA_ENTIDAD;

namespace AutoMaster
{
    public partial class frm_insertarNuevo_Estado : frm_base
    {
        CEestado _ceEstado = new CEestado();
        CNEstado _CNEstado = new CNEstado();

        public frm_insertarNuevo_Estado()
        {
            InitializeComponent();
        }

        private void frmNuevoEstado_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            insertar();
            
        }
        private void insertar()
        {

            try
            {
                if ( txbCodigoEstado.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                  
                    _ceEstado.Estado = txbCodigoEstado.Text;
                    _ceEstado.Activo = checkBoxactivoEstado.Checked;
                    _CNEstado.InsertarEstado(_ceEstado);
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
    }
}
