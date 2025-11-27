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

namespace AutoMaster
{
    public partial class frm_PrinCatalogo : frm_base
    {
       CNCatalogo _CNCatalogo = new CNCatalogo();
      
        public frm_PrinCatalogo()
        {
            InitializeComponent();
        }

        private void frm_estado_Load(object sender, EventArgs e)
        {
            listar();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarCat);

        }
        private void listar()
        {
            dataGridViewListarCat.DataSource = _CNCatalogo.CNMOSTRARCAT();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarCat);           
        }
       
        private void btNuevo_Click(object sender, EventArgs e)
        {
            Frm_insertar_Nuevo_catalogo ventnuevocat = new Frm_insertar_Nuevo_catalogo();
            ventnuevocat.ShowDialog();
            listar();


        }

        private void dataGridViewListarCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualixarCat();
            listar();
        }
        // metofdo de Actualxar catalogo 
        private void ActualixarCat()
        {
            // creamos un if para que se seleccione un elemnto de la datagridview
            if (dataGridViewListarCat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un catálogo para actualizar");

            } // en el else vamos con las validacioens de autorelleno 
            else
            {
                // creamos el try catch
                try
                {
                    // hacemos instancia del frmActualixar 
                    frm_Actualizar_Catalogo ventActualizar = new frm_Actualizar_Catalogo();
                   
                    // mostramos el formulario
                    // llenamos los text box con los datos de la datagridview usamos mejor este metodo a diferencia al que usa el docente 
                    // la razon por la que aqui es mas preciso y nos vamos con el nombre de la columna o directamente la entidad jejeje
                  ventActualizar.txbIDCatalogo.Text = dataGridViewListarCat.CurrentRow.Cells["Id_Catalogo"].Value.ToString();
                    ventActualizar.txbCodigoCatalogo.Text = dataGridViewListarCat.CurrentRow.Cells["Codigo"].Value.ToString();
                    ventActualizar.txbNombreCatalogo.Text = dataGridViewListarCat.CurrentRow.Cells["Catalogo"].Value.ToString();
                    ventActualizar.txbIDTIPOCATALOGO.Text = dataGridViewListarCat.CurrentRow.Cells["ID_Tipo_Catalogo"].Value.ToString();
                    ventActualizar.checkBoxactivoCatalogo.Checked = Convert.ToBoolean(dataGridViewListarCat.CurrentRow.Cells["Activo"].Value);

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

        private void btnElimianar_Click(object sender, EventArgs e)
        {

        }
    }
        
}
