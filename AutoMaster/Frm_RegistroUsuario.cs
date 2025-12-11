using System;
using System.Data;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace AutoMaster
{
    public partial class Frm_RegistroUsuario : Form
    {
        CN_Usuarios objCN = new CN_Usuarios();

        // VARIABLE PÚBLICA PARA RECIBIR EL ID
        public int Id_Persona_Recibido;

        public Frm_RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Frm_RegistroUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            // Llenamos el combo con los roles de la BD
            DataTable dt = objCN.ObtenerRoles();

            cmbRoles.DataSource = dt;
            cmbRoles.DisplayMember = "Nombre_Rol"; // Lo que se ve
            cmbRoles.ValueMember = "Id_Rol";       // El valor interno (ID)
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validamos que tengamos un ID de persona válido
                if (Id_Persona_Recibido == 0)
                {
                    MessageBox.Show("No se ha vinculado ninguna persona a este usuario.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Complete los campos.");
                    return;
                }

                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                int idRol = Convert.ToInt32(cmbRoles.SelectedValue);

                // AHORA ENVIAMOS EL ID_PERSONA QUE TENEMOS GUARDADO
                objCN.InsertarUsuario(usuario, clave, idRol, Id_Persona_Recibido);

                MessageBox.Show("Usuario registrado y vinculado a la persona correctamente.");
                this.Close(); // Cerramos el form porque ya acabamos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}