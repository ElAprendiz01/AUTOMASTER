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
using System.Drawing.Printing;

namespace AutoMaster
{
    public partial class Frm_insertar_DatosPersonales : frm_base
    {
        CNDatosPersonales _cndto = new CNDatosPersonales();
        CEDatosPersonales _cedto = new CEDatosPersonales();
        public Frm_insertar_DatosPersonales()
        {
            InitializeComponent();
        }

        private void Frm_insertar_DatosPersonales_Load(object sender, EventArgs e)
        {
            listar();

        }
        private void listar()
        {
            // Llamamos al método de la capa de negocio/datos
            DataSet ds = _cndto.ListarOpciones();


            // Validamos que el SP devolvió las tres tablas
            if (ds.Tables.Count >= 3)
            {
                // Primer DataGridView: Géneros
                listarGenero.DataSource = ds.Tables[0];
                listarGenero.Columns["ID"].HeaderText = "ID";
                listarGenero.Columns["Genero"].HeaderText = "Genero";

                // Segundo DataGridView: Tipos de DNI
                listarTiposdeDNI.DataSource = ds.Tables[1];
                listarTiposdeDNI.Columns["ID"].HeaderText = "ID";
                listarTiposdeDNI.Columns["DNI"].HeaderText = "TIPO DNI";

                // Tercer DataGridView: Estados
                listarEstados.DataSource = ds.Tables[2];
                listarEstados.Columns["ID"].HeaderText = "ID";
                listarEstados.Columns["Estado"].HeaderText = "Estado";

                // Opcional: aplicar estilos profesionales a cada grid
                CPEstilos.AplicarEstilosProfesionales(listarGenero);
                CPEstilos.AplicarEstilosProfesionales(listarTiposdeDNI);
                CPEstilos.AplicarEstilosProfesionales(listarEstados);
            }
            else
            {
                MessageBox.Show("El procedimiento no devolvió los tres conjuntos de datos esperados.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarNuevoCatalogo();

        }
        private void GuardarNuevoCatalogo()
        {
            try
            {
                if (txbPrimerNombre.Text == string.Empty || txbSegundoNombre.Text == string.Empty || txbPrimerApellido.Text == string.Empty
                    || txbSegundoApellido.Text == string.Empty || txbIdGenero.Text == string.Empty || txbIdTipoDni.Text == string.Empty
                    || txbDNI.Text == string.Empty || txbIdGenero.Text == string.Empty)
                {
                    MessageBox.Show("Llena todos los campos ", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _cedto.Primer_Nombre = txbPrimerNombre.Text;
                    _cedto.Segundo_Nombre = txbSegundoNombre.Text;
                    _cedto.Primer_Apellido = txbPrimerApellido.Text;
                    _cedto.Segundo_Apellido = txbSegundoApellido.Text;
                    _cedto.Id_Genero = Convert.ToInt32(txbIdGenero.Text);
                    _cedto.Id_Tipo_DNI = Convert.ToInt32(txbIdTipoDni.Text);
                    _cedto.DNI = txbDNI.Text;
                    _cedto.Id_Estado = Convert.ToInt32(txbIDEstadodtp.Text);
                    _cndto.cnInsertarDatosPersoneles(_cedto);
                    MessageBox.Show("Datos Personales  insertados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                // Messagebox de error 
                MessageBox.Show("Error al guardar el Los Datos : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
