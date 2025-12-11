using System;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace AutoMaster
{
    public partial class Frm_InicioSesion : Form
    {
        // Instanciamos la Capa de Negocio
        CN_InicioSesion objcninicio = new CN_InicioSesion();

        // Variables Globales para guardar quién inició sesión
        public static string User_nombre;
        public static string User_Rol;
        public static int User_Id;

        public Frm_InicioSesion()
        {
            InitializeComponent();
        }

        private void Frm_InicioSesion_Load(object sender, EventArgs e)
        {
            // Opcional: Poner el foco en la caja de texto usuario
            txtUser.Select();
        }

        void logeo()
        {
            // Validaciones básicas de campos vacíos
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. LLAMADA A LA CAPA DE NEGOCIO
            // Ya no recibimos un DataTable, recibimos un Objeto Entidad (o null)
            CE_InicioSesion usuarioValidado = objcninicio.ValidarUsuario(txtUser.Text, txtPass.Text);

            // 2. VERIFICAMOS EL RESULTADO
            if (usuarioValidado != null)
            {
                // -- LOGIN EXITOSO --

                // Guardamos los datos en las variables estáticas para usarlas en todo el sistema
                User_Id = usuarioValidado.Id_Usuario;
                User_nombre = usuarioValidado.Usuario;
                User_Rol = usuarioValidado.Nombre_Rol;

                MessageBox.Show("Bienvenido al sistema: " + User_nombre + "\nRol: " + User_Rol,
                                "Acceso Correcto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // 3. ABRIR EL FORMULARIO PRINCIPAL
                // Ocultamos el Login
                this.Hide();

                // Instanciamos y mostramos el menú principal (Asegúrate de tener este Form creado)
                Frm_principal frm = new Frm_principal();

                // Esta lógica asegura que si cierran el menú principal, se cierre toda la app
                frm.Show();
                frm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // -- LOGIN FALLIDO --
                // Nota: Por seguridad, no decimos si falló el usuario o la clave específicamente.
                MessageBox.Show("Usuario o Contraseña Incorrecta",
                                "Acceso Denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                // Limpiamos la clave para que intente de nuevo
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logeo();
        }

        // Opcional: Permitir dar ENTER en la caja de contraseña para iniciar sesión
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logeo();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
