using AutoMaster.fmrContacto;
using AutoMaster.frm_Empleados;
using AutoMaster.frm_Financiamiento;
using AutoMaster.frm_Vehiculos;
using AutoMaster.frmCliente;
using AutoMaster.frmContactoProveedor;
using AutoMaster.frmDirecciones;
using AutoMaster.frmFactura;
using AutoMaster.frmPagos;
using AutoMaster.frmProveedores;
using AutoMaster.frmServiciosVehiculos;
using AutoMaster.frmTaller;
using AutoMaster.FrmVentas;
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
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        //evento load 

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            // Muestra información del usuario logueado en las etiquetas
           
            if (lblUsuario != null && lblRol != null)
            {
                lblUsuario.Text = "Usuario: " + Frm_InicioSesion.User_nombre;
                lblRol.Text = " | Rol: " + Frm_InicioSesion.User_Rol; // Usamos la variable cargo
            }

            // Ejecuta la lógica de permisos
            GestionarPermisos();
        }

        //Gestiona Permisos
        private void GestionarPermisos()
        {
            string rol = Frm_InicioSesion.User_Rol; // Recuperamos el rol desde el Login


            // Módulos Administrativos
            dToolStripMenuItem.Visible = false;           
            catálogoToolStripMenuItem.Visible = false;   
            catálogoToolStripMenuItem.Visible = false;    

            // Módulos de Operación
            ventasToolStripMenuItem.Visible = false;
            fiancimientoToolStripMenuItem.Visible = false;
            pagosToolStripMenuItem.Visible = false;
            facturasToolStripMenuItem.Visible = false;

            // Módulos de Taller
            tallerToolStripMenuItem.Visible = false;
            servicioDeVehículoToolStripMenuItem.Visible = false;
            vehiculosToolStripMenuItem.Visible = false;

            // LOGICA DEL ROL
            if (rol == "Administrador")
            {
                // El administrador ve TODO
                dToolStripMenuItem.Visible = true;
                catálogoToolStripMenuItem.Visible = true;
                catálogoToolStripMenuItem.Visible = true;
                ventasToolStripMenuItem.Visible = true;
                fiancimientoToolStripMenuItem.Visible = true;
                pagosToolStripMenuItem.Visible = true;
                facturasToolStripMenuItem.Visible = true;
                tallerToolStripMenuItem.Visible = true;
                servicioDeVehículoToolStripMenuItem.Visible = true;
                vehiculosToolStripMenuItem.Visible = true;

                
            }
            else if (rol == "Mecánico")
            {
                // El mecánico solo ve lo relacionado a Taller y Vehículos
                tallerToolStripMenuItem.Visible = true;
                servicioDeVehículoToolStripMenuItem.Visible = true;
                vehiculosToolStripMenuItem.Visible = true;
                datosPerosnalesToolStripMenuItem.Visible = false;
                estadpToolStripMenuItem.Visible = false;
                tipoDeCatalogoToolStripMenuItem.Visible = false;
                contactoDeProveedoresToolStripMenuItem.Visible = false;
                contactosToolStripMenuItem.Visible = false;
                direccionesToolStripMenuItem.Visible = false;
                proveedoresToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;


                
            }
            else if (rol == "Ventas") 
            {
                // El vendedor ve Ventas, Clientes, Facturas, Financiamiento
                ventasToolStripMenuItem.Visible = true;
                fiancimientoToolStripMenuItem.Visible = true;
                pagosToolStripMenuItem.Visible = true;
                facturasToolStripMenuItem.Visible = true;
                vehiculosToolStripMenuItem.Visible = true;
                tipoDeCatalogoToolStripMenuItem.Visible = false;
                datosPerosnalesToolStripMenuItem.Visible = false;

            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e) 
        {

            
        }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PrinCatalogo _ventEstado = new frm_PrinCatalogo();
            _ventEstado.ShowDialog();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void estadpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_prin_Estado _ventEstado = new Frm_prin_Estado();
            _ventEstado.ShowDialog();
        }

        private void tipoDeCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Prin_TipoDeCatalogo _ventTipoCatalog = new frm_Prin_TipoDeCatalogo();
            _ventTipoCatalog.ShowDialog();
        }

        private void datosPerosnalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Prin_DatosPersonales dtp = new Frm_Prin_DatosPersonales();
            dtp.ShowDialog();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinContacto contacto = new frmPrinContacto();
            contacto.ShowDialog();
        }

        private void direccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinDirecciones direcciones = new frmPrinDirecciones();
            direcciones.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinProveedores proveedores = new frmPrinProveedores();
            proveedores.ShowDialog();
        }

        private void contactoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinContactoProveedor contactoProveedor = new frmPrinContactoProveedor();
            contactoProveedor.ShowDialog();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Este es el menú de EMPLEADOS
            frmPrinEmpleados empleados = new frmPrinEmpleados();
            empleados.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinClientes clientes = new frmPrinClientes();
            clientes.ShowDialog();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinVehiculos _frmVehiculo = new frmPrinVehiculos();
            _frmVehiculo.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinVentas _frmVentas = new frmPrinVentas();
            _frmVentas.ShowDialog();
        }

        private void fiancimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinFinanciamiento _frmFinanciamiento = new frmPrinFinanciamiento();
            _frmFinanciamiento.ShowDialog();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinPagos _psgo = new frmPrinPagos();
            _psgo.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinFactura _fac = new frmPrinFactura();
            _fac.ShowDialog();
        }

        private void tallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinTaller _taller = new frmPrinTaller();
            _taller.ShowDialog();
        }

        private void servicioDeVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrinServicioDeVehiculos _servicioVehiculo = new frmPrinServicioDeVehiculos();
            _servicioVehiculo.ShowDialog();
        }

        // Cierre de sesión al cerrar el formulario principal
        private void Frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }
    }
}