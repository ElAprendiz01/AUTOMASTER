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
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(203, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 61);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.menúPrincipal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 442);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menúPrincipal
            // 
            this.menúPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menúPrincipal.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ventasToolStripMenuItem});
            this.menúPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menúPrincipal.Name = "menúPrincipal";
            this.menúPrincipal.Size = new System.Drawing.Size(197, 442);
            this.menúPrincipal.TabIndex = 0;
            this.menúPrincipal.Text = "menú Principal ";
            this.menúPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // estadpToolStripMenuItem
            // 
            this.estadpToolStripMenuItem.Name = "estadpToolStripMenuItem";
            this.estadpToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.estadpToolStripMenuItem.Text = "Estado";
            this.estadpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estadpToolStripMenuItem.Click += new System.EventHandler(this.estadpToolStripMenuItem_Click);
            // 
            // tipoDeCatalogoToolStripMenuItem
            // 
            this.tipoDeCatalogoToolStripMenuItem.Name = "tipoDeCatalogoToolStripMenuItem";
            this.tipoDeCatalogoToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.tipoDeCatalogoToolStripMenuItem.Text = "Tipo de Catálogo";
            this.tipoDeCatalogoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipoDeCatalogoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCatalogoToolStripMenuItem_Click);
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            this.catálogoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catálogoToolStripMenuItem.Click += new System.EventHandler(this.catálogoToolStripMenuItem_Click);
            // 
            // datosPerosnalesToolStripMenuItem
            // 
            this.datosPerosnalesToolStripMenuItem.Name = "datosPerosnalesToolStripMenuItem";
            this.datosPerosnalesToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.datosPerosnalesToolStripMenuItem.Text = "Datos Personales";
            this.datosPerosnalesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datosPerosnalesToolStripMenuItem.Click += new System.EventHandler(this.datosPerosnalesToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.contactosToolStripMenuItem.Text = "Contactos ";
            this.contactosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactosToolStripMenuItem.Click += new System.EventHandler(this.contactosToolStripMenuItem_Click);
            // 
            // direccionesToolStripMenuItem
            // 
            this.direccionesToolStripMenuItem.Name = "direccionesToolStripMenuItem";
            this.direccionesToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.direccionesToolStripMenuItem.Text = "Direcciones ";
            this.direccionesToolStripMenuItem.Click += new System.EventHandler(this.direccionesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // contactoDeProveedoresToolStripMenuItem
            // 
            this.contactoDeProveedoresToolStripMenuItem.Name = "contactoDeProveedoresToolStripMenuItem";
            this.contactoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.contactoDeProveedoresToolStripMenuItem.Text = "Contacto Proveedores";
            this.contactoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.contactoDeProveedoresToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.dToolStripMenuItem.Text = "Empleados";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos ";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Controls.Add(this.portada);
            this.panel4.Location = new System.Drawing.Point(226, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 256);
            this.panel4.TabIndex = 2;
            // 
            // portada
            // 
            this.portada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portada.BackColor = System.Drawing.SystemColors.Desktop;
            this.portada.Image = ((System.Drawing.Image)(resources.GetObject("portada.Image")));
            this.portada.Location = new System.Drawing.Point(-101, 3);
            this.portada.Name = "portada";
            this.portada.Size = new System.Drawing.Size(814, 281);
            this.portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portada.TabIndex = 3;
            this.portada.TabStop = false;
            this.portada.UseWaitCursor = true;
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(184, 21);
            this.ventasToolStripMenuItem.Text = "Ventas ";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(864, 442);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_principal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem estadpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPerosnalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menúPrincipal;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox portada;
        private System.Windows.Forms.ToolStripMenuItem direccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}

