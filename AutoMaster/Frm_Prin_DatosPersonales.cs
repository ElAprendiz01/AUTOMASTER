using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CAPA_NEGOCIO;
namespace AutoMaster
{
    public partial class Frm_Prin_DatosPersonales : frm_base
    {
        CNDatosPersonales _cndtp = new CNDatosPersonales();

        public Frm_Prin_DatosPersonales()
        {
            InitializeComponent();
        }

        private void Rfm_Prin_DatosPersonales_Load(object sender, EventArgs e)
        {
            Listar();

        }

        private void dataGridViewListarDatopersonales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
        //metodo para lisar 
        private void Listar()
        {
            dataGridViewListarDatopersonales.DataSource = _cndtp.cnListarDatosPersonales();
            CPEstilos.AplicarEstilosProfesionales(dataGridViewListarDatopersonales);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Frm_insertar_DatosPersonales _dtp = new Frm_insertar_DatosPersonales();
            _dtp.ShowDialog();
            Listar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarPersona();
            Listar();


        }

        private void ActualizarPersona()
        {
            // Validamos que haya una fila seleccionada
            if (dataGridViewListarDatopersonales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una persona para actualizar",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Instanciamos el formulario de actualización
                frm_Actualizar_DatosPersonales ventActualizar = new frm_Actualizar_DatosPersonales();

                // Obtenemos la fila actual
                DataGridViewRow fila = dataGridViewListarDatopersonales.CurrentRow;

                if (fila != null)
                {
                    // Asignamos valores a los controles del formulario
                    ventActualizar.txbIdPersonal.Text = fila.Cells["Id_Persona"].Value?.ToString();
                    ventActualizar.txbPrimerNombre.Text = fila.Cells["Primer_Nombre"].Value?.ToString();
                    ventActualizar.txbSegundoNombre.Text = fila.Cells["Segundo_Nombre"].Value?.ToString();
                    ventActualizar.txbPrimerApellido.Text = fila.Cells["Primer_Apellido"].Value?.ToString();
                    ventActualizar.txbSegundoApellido.Text = fila.Cells["Segundo_Apellido"].Value?.ToString();
                    ventActualizar.txbIdGenero.Text = fila.Cells["Id_Genero"].Value.ToString();
                    ventActualizar.txbIdTipoDni.Text = fila.Cells["Id_Tipo_DNI"].Value.ToString();
                    ventActualizar.txbDNI.Text = fila.Cells["DNI"].Value?.ToString();
                    ventActualizar.txbIdEstado.Text = fila.Cells["Id_Estado"].Value.ToString();

                    // Mostramos el formulario
                    ventActualizar.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos personales: {ex.Message}",
                                "Editar Persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
