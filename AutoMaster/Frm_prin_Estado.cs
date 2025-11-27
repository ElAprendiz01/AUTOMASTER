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
    public partial class Frm_prin_Estado : frm_base
    {
        CNEstado _CNCatalogo = new CNEstado();
        CEestado CEestado = new CEestado();
        public Frm_prin_Estado()
        {
            InitializeComponent();
        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            listar();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarEstado);

        }

        private void dataGridViewListarEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listar()
        {
            dataGridViewListarEstado.DataSource = _CNCatalogo.ListarEstado();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarEstado);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_insertarNuevo_Estado ventnuevocat = new frm_insertarNuevo_Estado();
            ventnuevocat.ShowDialog();
            listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualixarEstado();
            listar();
        }
        private void ActualixarEstado()
        {
            // creamos un if para que se seleccione un elemnto de la datagridview
            if (dataGridViewListarEstado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Estado para actualizar");

            } // en el else vamos con las validacioens de autorelleno 
            else
            {
                // creamos el try catch
                try
                {
                    // hacemos instancia del frmActualizar 
                    Frm_Actualizar_Estado ventActualizar = new Frm_Actualizar_Estado();

                    // mostramos el formulario
                    // llenamos los text box con los datos de la datagridview usamos mejor este metodo a diferencia al que usa el docente 
                    // la razon por la que aqui es mas preciso y nos vamos con el nombre de la columna o directamente la entidad jejeje
                    ventActualizar.TxbIdEstado.Text = dataGridViewListarEstado.CurrentRow.Cells["Id_Estado"].Value.ToString();
                    ventActualizar.txbCodigoEstado.Text = dataGridViewListarEstado.CurrentRow.Cells["Estado"].Value.ToString();
                   ventActualizar.checkBoxactivoEstado.Checked = Convert.ToBoolean(dataGridViewListarEstado.CurrentRow.Cells["Activo"].Value);
                   
                    ventActualizar.ShowDialog();

                }
                catch (Exception ex)
                {

                    /// mesnaje de error 
                    MessageBox.Show($"Error al actualizar el catálogo:  {ex.Message}, ", "Editar Catalog ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

                }
            }

        }
    }
}
