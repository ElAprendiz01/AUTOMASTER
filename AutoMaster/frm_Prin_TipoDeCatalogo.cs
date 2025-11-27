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

namespace AutoMaster
{
    public partial class frm_Prin_TipoDeCatalogo : frm_base
    {
        CNtipoDeCatalogos _CNtipoCatalogo = new CNtipoDeCatalogos();
        public frm_Prin_TipoDeCatalogo()
        {
            InitializeComponent();
        }

        private void frmTipoDeCatalogo_Load(object sender, EventArgs e)
        {
            // aqui mandoa  llamar mi metodo listar
            listar();
            // LE APLICO LOS ESTILOS
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListartipoDeCatalogo);
        }

        private void dataGridViewListarCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // llamo al formulario actualizar
            ActualixarTipoCat();
            listar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            // instancio lo al frm donde lo voy a llamar
            frm_insertar_Nuevo_TipoDeCatalogo _ventaNuevoTipoCatalog = new frm_insertar_Nuevo_TipoDeCatalogo();
            _ventaNuevoTipoCatalog.ShowDialog();
            listar();

        }

        private void btnElimianar_Click(object sender, EventArgs e)
        {

        }
        // metodo para lista 
        private void listar()
        {
            dataGridViewListartipoDeCatalogo.DataSource = _CNtipoCatalogo.MostrarTipoDeCatalogo();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListartipoDeCatalogo);
        }
        private void ActualixarTipoCat()
        {
            // creamos un if para que se seleccione un elemnto de la datagridview
            if (dataGridViewListartipoDeCatalogo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un catálogo para actualizar");

            } // en el else vamos con las validacioens de autorelleno 
            else
            {
                // creamos el try catch
                try
                {
                    // hacemos instancia del frmActualixar 
                    frm_Actilizar_TipoDeCatalogo ventActualizar = new frm_Actilizar_TipoDeCatalogo();

                    // mostramos el formulario
                    // llenamos los text box con los datos de la datagridview usamos mejor este metodo a diferencia al que usa el docente 
                    // la razon por la que aqui es mas preciso y nos vamos con el nombre de la columna o directamente la entidad jejeje
                    ventActualizar.txbIdTipoDeCatalogo .Text = dataGridViewListartipoDeCatalogo.CurrentRow.Cells["Id_Tipo_Catalogo"].Value.ToString();
                    ventActualizar.txbCodigo .Text = dataGridViewListartipoDeCatalogo.CurrentRow.Cells["Codigo"].Value.ToString();
                    ventActualizar.txbtipoDeCatalogo.Text = dataGridViewListartipoDeCatalogo.CurrentRow.Cells["Tipo_Catalogo"].Value.ToString();
                    ventActualizar.checkBoxactivoTipoDeCatalogo.Checked = Convert.ToBoolean(dataGridViewListartipoDeCatalogo.CurrentRow.Cells["Activo"].Value);

                    ventActualizar.ShowDialog();

                }
                catch (Exception ex)
                {

                    /// mesnaje de error 
                    MessageBox.Show($"Error al actualizar el catálogo:  {ex.Message}, ", "Editar Catalog ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /// 

                }
            }

        }




    }
}
