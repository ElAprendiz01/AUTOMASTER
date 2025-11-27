namespace AutoMaster.frmContactoProveedor
{
    partial class FrmInsertarContactoProveedor
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.checkContactoProveedorPrincipal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbIdContactoProveedor = new System.Windows.Forms.TextBox();
            this.txbIdProveedor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(827, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Size = new System.Drawing.Size(827, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 414);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-17, -38);
            this.pictureBox1.Size = new System.Drawing.Size(215, 166);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(36, 280);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkContactoProveedorPrincipal
            // 
            this.checkContactoProveedorPrincipal.AutoSize = true;
            this.checkContactoProveedorPrincipal.Location = new System.Drawing.Point(232, 246);
            this.checkContactoProveedorPrincipal.Name = "checkContactoProveedorPrincipal";
            this.checkContactoProveedorPrincipal.Size = new System.Drawing.Size(15, 14);
            this.checkContactoProveedorPrincipal.TabIndex = 84;
            this.checkContactoProveedorPrincipal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 86;
            this.label3.Text = "Principal";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(32, 176);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(99, 19);
            this.lbelCodigoCatalogo.TabIndex = 87;
            this.lbelCodigoCatalogo.Text = "ID Contacto";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(32, 104);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(109, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 88;
            this.Lbl_IdTipoCatalogo.Text = "ID Proveedor";
            // 
            // txbIdContactoProveedor
            // 
            this.txbIdContactoProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdContactoProveedor.Location = new System.Drawing.Point(208, 168);
            this.txbIdContactoProveedor.Name = "txbIdContactoProveedor";
            this.txbIdContactoProveedor.Size = new System.Drawing.Size(139, 27);
            this.txbIdContactoProveedor.TabIndex = 82;
            // 
            // txbIdProveedor
            // 
            this.txbIdProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdProveedor.Location = new System.Drawing.Point(208, 96);
            this.txbIdProveedor.Name = "txbIdProveedor";
            this.txbIdProveedor.Size = new System.Drawing.Size(139, 27);
            this.txbIdProveedor.TabIndex = 81;
            // 
            // FrmInsertarContactoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 523);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.checkContactoProveedorPrincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbIdContactoProveedor);
            this.Controls.Add(this.txbIdProveedor);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "FrmInsertarContactoProveedor";
            this.Text = "FrmInsertarContactoProveedor";
            this.Load += new System.EventHandler(this.FrmInsertarContactoProveedor_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIdProveedor, 0);
            this.Controls.SetChildIndex(this.txbIdContactoProveedor, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkContactoProveedorPrincipal, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.CheckBox checkContactoProveedorPrincipal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbIdContactoProveedor;
        public System.Windows.Forms.TextBox txbIdProveedor;
    }
}