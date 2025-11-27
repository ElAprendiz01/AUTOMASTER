namespace AutoMaster.frmProveedores
{
    partial class frmInsertarProveedores
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
            this.panel1.Size = new System.Drawing.Size(859, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Size = new System.Drawing.Size(859, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 428);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(311, 166);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(635, 428);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 86;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "ID Estado";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(22, 201);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(181, 19);
            this.lbelCodigoCatalogo.TabIndex = 88;
            this.lbelCodigoCatalogo.Text = "Nombre de la Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "RUC";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(22, 129);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(140, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 90;
            this.Lbl_IdTipoCatalogo.Text = "ID Representante";
            // 
            // TxbIDEstado
            // 
            this.TxbIDEstado.BackColor = System.Drawing.SystemColors.Info;
            this.TxbIDEstado.Location = new System.Drawing.Point(592, 193);
            this.TxbIDEstado.Name = "TxbIDEstado";
            this.TxbIDEstado.Size = new System.Drawing.Size(139, 27);
            this.TxbIDEstado.TabIndex = 84;
            // 
            // txbRUC
            // 
            this.txbRUC.BackColor = System.Drawing.SystemColors.Info;
            this.txbRUC.Location = new System.Drawing.Point(592, 121);
            this.txbRUC.Name = "txbRUC";
            this.txbRUC.Size = new System.Drawing.Size(139, 27);
            this.txbRUC.TabIndex = 81;
            // 
            // txbNomEmpresa
            // 
            this.txbNomEmpresa.BackColor = System.Drawing.SystemColors.Info;
            this.txbNomEmpresa.Location = new System.Drawing.Point(229, 193);
            this.txbNomEmpresa.Name = "txbNomEmpresa";
            this.txbNomEmpresa.Size = new System.Drawing.Size(139, 27);
            this.txbNomEmpresa.TabIndex = 85;
            // 
            // txbIdRepresentante
            // 
            this.txbIdRepresentante.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdRepresentante.Location = new System.Drawing.Point(229, 121);
            this.txbIdRepresentante.Name = "txbIdRepresentante";
            this.txbIdRepresentante.Size = new System.Drawing.Size(139, 27);
            this.txbIdRepresentante.TabIndex = 82;
            // 
            // frmInsertarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 537);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.TxbIDEstado);
            this.Controls.Add(this.txbRUC);
            this.Controls.Add(this.txbNomEmpresa);
            this.Controls.Add(this.txbIdRepresentante);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmInsertarProveedores";
            this.Text = "frmInsertarProveedores";
            this.Load += new System.EventHandler(this.frmInsertarProveedores_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIdRepresentante, 0);
            this.Controls.SetChildIndex(this.txbNomEmpresa, 0);
            this.Controls.SetChildIndex(this.txbRUC, 0);
            this.Controls.SetChildIndex(this.TxbIDEstado, 0);
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
        public System.Windows.Forms.TextBox TxbIDEstado;
        public System.Windows.Forms.TextBox txbRUC;
        public System.Windows.Forms.TextBox txbNomEmpresa;
        public System.Windows.Forms.TextBox txbIdRepresentante;
    }
}