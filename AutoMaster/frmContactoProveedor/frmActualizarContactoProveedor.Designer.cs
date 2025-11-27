namespace AutoMaster.frmContactoProveedor
{
    partial class frmActualizarContactoProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualizar = new System.Windows.Forms.Button();
            this.checkContactoProveedorPrincipal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbIdContacto = new System.Windows.Forms.TextBox();
            this.txbIdContactoProveedor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(911, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Size = new System.Drawing.Size(911, 46);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(800, 413);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Location = new System.Drawing.Point(54, 291);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 55);
            this.btnActualizar.TabIndex = 75;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkContactoProveedorPrincipal
            // 
            this.checkContactoProveedorPrincipal.AutoSize = true;
            this.checkContactoProveedorPrincipal.Location = new System.Drawing.Point(250, 257);
            this.checkContactoProveedorPrincipal.Name = "checkContactoProveedorPrincipal";
            this.checkContactoProveedorPrincipal.Size = new System.Drawing.Size(15, 14);
            this.checkContactoProveedorPrincipal.TabIndex = 74;
            this.checkContactoProveedorPrincipal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Principal";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(50, 187);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(99, 19);
            this.lbelCodigoCatalogo.TabIndex = 78;
            this.lbelCodigoCatalogo.Text = "ID Contacto";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(50, 115);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(109, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 80;
            this.Lbl_IdTipoCatalogo.Text = "ID Proveedor";
            // 
            // txbIdContacto
            // 
            this.txbIdContacto.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdContacto.Location = new System.Drawing.Point(226, 179);
            this.txbIdContacto.Name = "txbIdContacto";
            this.txbIdContacto.Size = new System.Drawing.Size(139, 27);
            this.txbIdContacto.TabIndex = 71;
            // 
            // txbIdContactoProveedor
            // 
            this.txbIdContactoProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdContactoProveedor.Location = new System.Drawing.Point(226, 115);
            this.txbIdContactoProveedor.Name = "txbIdContactoProveedor";
            this.txbIdContactoProveedor.Size = new System.Drawing.Size(139, 27);
            this.txbIdContactoProveedor.TabIndex = 73;
            this.txbIdContactoProveedor.TextChanged += new System.EventHandler(this.txbIDTipoDeContacto_TextChanged);
            // 
            // frmActualizarContactoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.checkContactoProveedorPrincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbIdContacto);
            this.Controls.Add(this.txbIdContactoProveedor);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmActualizarContactoProveedor";
            this.Text = "frmActualizarContactoProveedor";
            this.Load += new System.EventHandler(this.frmActualizarContactoProveedor_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIdContactoProveedor, 0);
            this.Controls.SetChildIndex(this.txbIdContacto, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkContactoProveedorPrincipal, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.CheckBox checkContactoProveedorPrincipal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbIdContacto;
        public System.Windows.Forms.TextBox txbIdContactoProveedor;
    }
}