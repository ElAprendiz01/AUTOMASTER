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
    public partial class frm_base : Form
    {
        public frm_base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frm_base_Load(object sender, EventArgs e)
        {

        }
        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                // Esto deshabilita el botón de cerrar a nivel de sistema
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        // Dejare esto por aca solo por si sse me antoja usarlo 
        // que es lo que hace sesto sencillo muestra un reloj de arena en vez de el cursor mientras carga algo 
        // ideal para ponerlo antes de manadar a insertar y actualizar 
        public void MostrarCarga()
        {
            this.Cursor = Cursors.WaitCursor;
        }
        // y este se mandaria a llmar despues de las insercciones o actualizacion y antes del emsnaje de exito 
        public void OcultarCarga()
        {
            this.Cursor = Cursors.Default;
        }
    }
    
}
