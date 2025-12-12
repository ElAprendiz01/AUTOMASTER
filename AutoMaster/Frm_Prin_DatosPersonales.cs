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

namespace AutoMaster
{
    public partial class Frm_Prin_DatosPersonales : frm_base // Asumo que heredas de un form base
    {
        // Instancia de la capa de negocio
        CNDatosPersonales _cndtp = new CNDatosPersonales();

        public Frm_Prin_DatosPersonales()
        {
            InitializeComponent();
        }

        private void Rfm_Prin_DatosPersonales_Load(object sender, EventArgs e)
        {
            Listar();
        }

        // Método para listar los datos en la grilla
        private void Listar()
        {
            try
            {
                dataGridViewListarDatopersonales.DataSource = _cndtp.cnListarDatosPersonales();
                // Asumo que tienes una clase de estilos, si no, comenta esta línea
                // CPEstilos.AplicarEstilosProfesionales(dataGridViewListarDatopersonales); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista: " + ex.Message);
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Frm_insertar_DatosPersonales _dtp = new Frm_insertar_DatosPersonales();
            _dtp.ShowDialog();
            Listar(); // Refrescamos la lista al cerrar el formulario de insertar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarPersona();
            Listar(); // Refrescamos la lista después de editar
        }

        // --- AQUÍ ESTÁ EL BOTÓN QUE PEDISTE (CREAR USUARIO LOGIN) ---
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // 1. Validar selección
            if (dataGridViewListarDatopersonales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una persona primero.");
                return;
            }

            // 2. Capturar el ID de la persona de la celda (Asegúrate que la columna se llame "Id_Persona")
            int idPersonaSeleccionada = Convert.ToInt32(dataGridViewListarDatopersonales.CurrentRow.Cells["Id_Persona"].Value);

            // Capturamos el nombre solo para mostrarlo (estético)
            string nombre = dataGridViewListarDatopersonales.CurrentRow.Cells["Primer_Nombre"].Value.ToString();

            // 3. Abrir el formulario y PASARLE EL ID
            Frm_RegistroUsuario frm = new Frm_RegistroUsuario();

            // ¡AQUÍ ESTÁ LA CLAVE! Asignamos el ID a la variable que creamos en el paso 3
            frm.Id_Persona_Recibido = idPersonaSeleccionada;

            frm.Text = "Creando usuario para: " + nombre;
            frm.ShowDialog();
        }

        private void ActualizarPersona()
        {
            if (dataGridViewListarDatopersonales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una persona para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                frm_Actualizar_DatosPersonales ventActualizar = new frm_Actualizar_DatosPersonales();
                DataGridViewRow fila = dataGridViewListarDatopersonales.CurrentRow;

                if (fila != null)
                {
                    // Pasamos los datos al formulario de actualizar
                    // Nota: Asegúrate que los nombres de columnas ("Id_Persona", etc.) sean exactos a tu BD
                    ventActualizar.txbIdPersonal.Text = fila.Cells["Id_Persona"].Value?.ToString();
                    ventActualizar.txbPrimerNombre.Text = fila.Cells["Primer_Nombre"].Value?.ToString();
                    ventActualizar.txbSegundoNombre.Text = fila.Cells["Segundo_Nombre"].Value?.ToString();
                    ventActualizar.txbPrimerApellido.Text = fila.Cells["Primer_Apellido"].Value?.ToString();
                    ventActualizar.txbSegundoApellido.Text = fila.Cells["Segundo_Apellido"].Value?.ToString();

                    // Manejo seguro de valores nulos o columnas que podrían fallar
                    if (fila.Cells["Id_Genero"].Value != null)
                        ventActualizar.txbIdGenero.Text = fila.Cells["Id_Genero"].Value.ToString();

                    if (fila.Cells["Id_Tipo_DNI"].Value != null)
                        ventActualizar.txbIdTipoDni.Text = fila.Cells["Id_Tipo_DNI"].Value.ToString();

                    ventActualizar.txbDNI.Text = fila.Cells["DNI"].Value?.ToString();

                    if (fila.Cells["Id_Estado"].Value != null)
                        ventActualizar.txbIdEstado.Text = fila.Cells["Id_Estado"].Value.ToString();

                    ventActualizar.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al preparar actualización: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewListarDatopersonales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Generalmente vacío a menos que tengas botones dentro de la grilla
        }
    }
}