namespace AutoMaster
{
    partial class Frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menúPrincipal = new System.Windows.Forms.MenuStrip();
            this.estadpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPerosnalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.panel4 = new System.Windows.Forms.Panel();
            this.portada = new System.Windows.Forms.PictureBox();

            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiancimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.servicioDeVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.portada = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();




            this.panel4 = new System.Windows.Forms.Panel();
            this.portada = new System.Windows.Forms.PictureBox();
            this.servicioDeVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();


            this.panel3.SuspendLayout();
            this.menúPrincipal.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portada)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(304, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(304, 586);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 94);
            this.panel2.TabIndex = 1;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(329, 66);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(85, 28);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "label2";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(7, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 28);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 72);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.menúPrincipal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 680);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menúPrincipal
            // 
            this.menúPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menúPrincipal.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menúPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menúPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menúPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadpToolStripMenuItem,
            this.tipoDeCatalogoToolStripMenuItem,
            this.catálogoToolStripMenuItem,
            this.datosPerosnalesToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.direccionesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.contactoDeProveedoresToolStripMenuItem,
            this.dToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.fiancimientoToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.servicioDeVehículoToolStripMenuItem,
            this.tallerToolStripMenuItem});
            this.menúPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menúPrincipal.Name = "menúPrincipal";

            this.menúPrincipal.Size = new System.Drawing.Size(285, 680);

            this.menúPrincipal.Size = new System.Drawing.Size(288, 680);

            this.menúPrincipal.TabIndex = 0;
            this.menúPrincipal.Text = "menú Principal ";
            this.menúPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // estadpToolStripMenuItem
            // 
            this.estadpToolStripMenuItem.Name = "estadpToolStripMenuItem";

            this.estadpToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.estadpToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.estadpToolStripMenuItem.Text = "Estado";
            this.estadpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estadpToolStripMenuItem.Click += new System.EventHandler(this.estadpToolStripMenuItem_Click);
            // 
            // tipoDeCatalogoToolStripMenuItem
            // 
            this.tipoDeCatalogoToolStripMenuItem.Name = "tipoDeCatalogoToolStripMenuItem";

            this.tipoDeCatalogoToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.tipoDeCatalogoToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.tipoDeCatalogoToolStripMenuItem.Text = "Tipo de Catálogo";
            this.tipoDeCatalogoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipoDeCatalogoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCatalogoToolStripMenuItem_Click);
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";

            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.catálogoToolStripMenuItem.Text = "Catálogo";
            this.catálogoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catálogoToolStripMenuItem.Click += new System.EventHandler(this.catálogoToolStripMenuItem_Click);
            // 
            // datosPerosnalesToolStripMenuItem
            // 
            this.datosPerosnalesToolStripMenuItem.Name = "datosPerosnalesToolStripMenuItem";

            this.datosPerosnalesToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.datosPerosnalesToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.datosPerosnalesToolStripMenuItem.Text = "Datos Personales";
            this.datosPerosnalesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datosPerosnalesToolStripMenuItem.Click += new System.EventHandler(this.datosPerosnalesToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";

            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.contactosToolStripMenuItem.Text = "Contactos ";
            this.contactosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactosToolStripMenuItem.Click += new System.EventHandler(this.contactosToolStripMenuItem_Click);
            // 
            // direccionesToolStripMenuItem
            // 
            this.direccionesToolStripMenuItem.Name = "direccionesToolStripMenuItem";

            this.direccionesToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.direccionesToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.direccionesToolStripMenuItem.Text = "Direcciones ";
            this.direccionesToolStripMenuItem.Click += new System.EventHandler(this.direccionesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";

            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // contactoDeProveedoresToolStripMenuItem
            // 
            this.contactoDeProveedoresToolStripMenuItem.Name = "contactoDeProveedoresToolStripMenuItem";

            this.contactoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.contactoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.contactoDeProveedoresToolStripMenuItem.Text = "Contacto Proveedores";
            this.contactoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.contactoDeProveedoresToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";

            this.dToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.dToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.dToolStripMenuItem.Text = "Empleados";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";

            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(272, 31);

            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(269, 31);

            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";

            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(272, 31);


            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(269, 31);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos ";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(184, 21);

            this.vehiculosToolStripMenuItem.Text = "Vehiculos ";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(272, 31);
            this.ventasToolStripMenuItem.Text = "Ventas ";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
  // fiancimientoToolStripMenuItem
            // 
            this.fiancimientoToolStripMenuItem.Name = "fiancimientoToolStripMenuItem";
            this.fiancimientoToolStripMenuItem.Size = new System.Drawing.Size(272, 31);
            this.fiancimientoToolStripMenuItem.Text = "Financiamiento";
            this.fiancimientoToolStripMenuItem.Click += new System.EventHandler(this.fiancimientoToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(272, 31);
            this.pagosToolStripMenuItem.Text = "Pagos ";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(272, 31);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 

            // servicioDeVehículoToolStripMenuItem
            // 
            this.servicioDeVehículoToolStripMenuItem.Name = "servicioDeVehículoToolStripMenuItem";
            this.servicioDeVehículoToolStripMenuItem.Size = new System.Drawing.Size(272, 31);
            this.servicioDeVehículoToolStripMenuItem.Text = "servicio DeVehículo";
            this.servicioDeVehículoToolStripMenuItem.Click += new System.EventHandler(this.servicioDeVehículoToolStripMenuItem_Click);
            // 
            // tallerToolStripMenuItem
            // 
            this.tallerToolStripMenuItem.Name = "tallerToolStripMenuItem";
            this.tallerToolStripMenuItem.Size = new System.Drawing.Size(272, 31);
            this.tallerToolStripMenuItem.Text = "Taller";
            this.tallerToolStripMenuItem.Click += new System.EventHandler(this.tallerToolStripMenuItem_Click);
            // 



            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Controls.Add(this.portada);
            this.panel4.Location = new System.Drawing.Point(339, 140);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(892, 394);
            this.panel4.TabIndex = 2;
            // 
            // portada
            // 
            this.portada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portada.BackColor = System.Drawing.SystemColors.Desktop;
            this.portada.Image = ((System.Drawing.Image)(resources.GetObject("portada.Image")));
            this.portada.Location = new System.Drawing.Point(-152, 5);
            this.portada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portada.Name = "portada";
            this.portada.Size = new System.Drawing.Size(1221, 432);
            this.portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portada.TabIndex = 3;
            this.portada.TabStop = false;
            this.portada.UseWaitCursor = true;
            // 

            // Frm_principal
            // 

      // 
            this.servicioDeVehículoToolStripMenuItem.Name = "servicioDeVehículoToolStripMenuItem";
            this.servicioDeVehículoToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.servicioDeVehículoToolStripMenuItem.Text = "servicio DeVehículo";
            this.servicioDeVehículoToolStripMenuItem.Click += new System.EventHandler(this.servicioDeVehículoToolStripMenuItem_Click);
            // 
            // tallerToolStripMenuItem
            // 
            this.tallerToolStripMenuItem.Name = "tallerToolStripMenuItem";
            this.tallerToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.tallerToolStripMenuItem.Text = "Taller";
            this.tallerToolStripMenuItem.Click += new System.EventHandler(this.tallerToolStripMenuItem_Click);
            // 
   // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1296, 680);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_principal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menúPrincipal.ResumeLayout(false);
            this.menúPrincipal.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox portada;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.MenuStrip menúPrincipal;
        private System.Windows.Forms.ToolStripMenuItem estadpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPerosnalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiancimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioDeVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallerToolStripMenuItem;
    }
}

