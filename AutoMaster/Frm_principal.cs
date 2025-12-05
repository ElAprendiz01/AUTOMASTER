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
            var FrmUsuarioSesion = new Frm_InicioSesion();
            FrmUsuarioSesion.ShowDialog();
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
                
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PrinCatalogo _ventEstado = new frm_PrinCatalogo();
            _ventEstado.ShowDialog();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void estadpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_prin_Estado _ventEstado = new Frm_prin_Estado();
            _ventEstado.ShowDialog();
        }

        private void tipoDeCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // funciona como un boton para abrir el formulario de tipo de catalogo
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
            frmPrinContacto contacto = new  frmPrinContacto();
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

<<<<<<< HEAD
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

=======
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
>>>>>>> 1c116be655964fdef3ee09159b2e41f21b466dce
        }
    }
}
