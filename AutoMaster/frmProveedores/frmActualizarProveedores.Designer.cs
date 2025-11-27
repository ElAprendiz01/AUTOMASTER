namespace AutoMaster.frmProveedores
{
    partial class frmActualizarProveedores
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbId_Proveedor = new System.Windows.Forms.TextBox();
            this.TxbIDEstado = new System.Windows.Forms.TextBox();
            this.txbRUC = new System.Windows.Forms.TextBox();
            this.txbNomEmpresa = new System.Windows.Forms.TextBox();
            this.txbIdRepresentante = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(962, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Size = new System.Drawing.Size(962, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 410);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(316, 166);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(401, 340);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "ID Estado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(36, 190);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(181, 19);
            this.lbelCodigoCatalogo.TabIndex = 78;
            this.lbelCodigoCatalogo.Text = "Nombre de la Empresa";
            this.lbelCodigoCatalogo.Click += new System.EventHandler(this.lbelCodigoCatalogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "RUC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(36, 118);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(140, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 80;
            this.Lbl_IdTipoCatalogo.Text = "ID Representante";
            this.Lbl_IdTipoCatalogo.Click += new System.EventHandler(this.Lbl_IdTipoCatalogo_Click);
            // 
            // txbId_Proveedor
            // 
            this.txbId_Proveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txbId_Proveedor.Location = new System.Drawing.Point(391, 271);
            this.txbId_Proveedor.Name = "txbId_Proveedor";
            this.txbId_Proveedor.Size = new System.Drawing.Size(139, 27);
            this.txbId_Proveedor.TabIndex = 71;
            this.txbId_Proveedor.Visible = false;
            this.txbId_Proveedor.TextChanged += new System.EventHandler(this.txbId_Proveedor_TextChanged);
            // 
            // TxbIDEstado
            // 
            this.TxbIDEstado.BackColor = System.Drawing.SystemColors.Info;
            this.TxbIDEstado.Location = new System.Drawing.Point(606, 182);
            this.TxbIDEstado.Name = "TxbIDEstado";
            this.TxbIDEstado.Size = new System.Drawing.Size(139, 27);
            this.TxbIDEstado.TabIndex = 72;
            this.TxbIDEstado.TextChanged += new System.EventHandler(this.TxbIDEstado_TextChanged);
            // 
            // txbRUC
            // 
            this.txbRUC.BackColor = System.Drawing.SystemColors.Info;
            this.txbRUC.Location = new System.Drawing.Point(606, 110);
            this.txbRUC.Name = "txbRUC";
            this.txbRUC.Size = new System.Drawing.Size(139, 27);
            this.txbRUC.TabIndex = 69;
            this.txbRUC.TextChanged += new System.EventHandler(this.txbRUC_TextChanged);
            // 
            // txbNomEmpresa
            // 
            this.txbNomEmpresa.BackColor = System.Drawing.SystemColors.Info;
            this.txbNomEmpresa.Location = new System.Drawing.Point(243, 182);
            this.txbNomEmpresa.Name = "txbNomEmpresa";
            this.txbNomEmpresa.Size = new System.Drawing.Size(139, 27);
            this.txbNomEmpresa.TabIndex = 73;
            this.txbNomEmpresa.TextChanged += new System.EventHandler(this.txbNomEmpresa_TextChanged);
            // 
            // txbIdRepresentante
            // 
            this.txbIdRepresentante.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdRepresentante.Location = new System.Drawing.Point(243, 110);
            this.txbIdRepresentante.Name = "txbIdRepresentante";
            this.txbIdRepresentante.Size = new System.Drawing.Size(139, 27);
            this.txbIdRepresentante.TabIndex = 70;
            this.txbIdRepresentante.TextChanged += new System.EventHandler(this.txbIdRepresentante_TextChanged);
            // 
            // frmActualizarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 519);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbId_Proveedor);
            this.Controls.Add(this.TxbIDEstado);
            this.Controls.Add(this.txbRUC);
            this.Controls.Add(this.txbNomEmpresa);
            this.Controls.Add(this.txbIdRepresentante);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmActualizarProveedores";
            this.Text = "frmActualizarProveedores";
            this.Load += new System.EventHandler(this.frmActualizarProveedores_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIdRepresentante, 0);
            this.Controls.SetChildIndex(this.txbNomEmpresa, 0);
            this.Controls.SetChildIndex(this.txbRUC, 0);
            this.Controls.SetChildIndex(this.TxbIDEstado, 0);
            this.Controls.SetChildIndex(this.txbId_Proveedor, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbId_Proveedor;
        public System.Windows.Forms.TextBox TxbIDEstado;
        public System.Windows.Forms.TextBox txbRUC;
        public System.Windows.Forms.TextBox txbNomEmpresa;
        public System.Windows.Forms.TextBox txbIdRepresentante;
    }
}