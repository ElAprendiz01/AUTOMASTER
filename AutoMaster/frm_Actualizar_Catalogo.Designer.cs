namespace AutoMaster
{
    partial class frm_Actualizar_Catalogo
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.listarIdTipoCat = new System.Windows.Forms.DataGridView();
            this.checkBoxactivoCatalogo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreCatalogo = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbNombreCatalogo = new System.Windows.Forms.TextBox();
            this.txbCodigoCatalogo = new System.Windows.Forms.TextBox();
            this.txbIDTIPOCATALOGO = new System.Windows.Forms.TextBox();
            this.txbIDCatalogo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarIdTipoCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(834, 56);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Size = new System.Drawing.Size(834, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 308);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Location = new System.Drawing.Point(502, 300);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 55);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.listarIdTipoCat);
            this.panel3.Location = new System.Drawing.Point(59, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 138);
            this.panel3.TabIndex = 16;
            // 
            // listarIdTipoCat
            // 
            this.listarIdTipoCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarIdTipoCat.Location = new System.Drawing.Point(15, 16);
            this.listarIdTipoCat.Name = "listarIdTipoCat";
            this.listarIdTipoCat.Size = new System.Drawing.Size(288, 107);
            this.listarIdTipoCat.TabIndex = 0;
            this.listarIdTipoCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listarIdTipoCat_CellContentClick);
            // 
            // checkBoxactivoCatalogo
            // 
            this.checkBoxactivoCatalogo.AutoSize = true;
            this.checkBoxactivoCatalogo.Location = new System.Drawing.Point(572, 138);
            this.checkBoxactivoCatalogo.Name = "checkBoxactivoCatalogo";
            this.checkBoxactivoCatalogo.Size = new System.Drawing.Size(145, 23);
            this.checkBoxactivoCatalogo.TabIndex = 11;
            this.checkBoxactivoCatalogo.Text = "Activo o inctivo";
            this.checkBoxactivoCatalogo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Activo";
            // 
            // lblNombreCatalogo
            // 
            this.lblNombreCatalogo.AutoSize = true;
            this.lblNombreCatalogo.Location = new System.Drawing.Point(402, 68);
            this.lblNombreCatalogo.Name = "lblNombreCatalogo";
            this.lblNombreCatalogo.Size = new System.Drawing.Size(167, 19);
            this.lblNombreCatalogo.TabIndex = 13;
            this.lblNombreCatalogo.Text = "Nombre de Catálogo";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(47, 140);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(158, 19);
            this.lbelCodigoCatalogo.TabIndex = 14;
            this.lbelCodigoCatalogo.Text = "Código de Catálogo";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(47, 68);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(160, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 15;
            this.Lbl_IdTipoCatalogo.Text = "ID Tipo De Catálogo";
            // 
            // txbNombreCatalogo
            // 
            this.txbNombreCatalogo.BackColor = System.Drawing.SystemColors.Info;
            this.txbNombreCatalogo.Location = new System.Drawing.Point(578, 60);
            this.txbNombreCatalogo.Name = "txbNombreCatalogo";
            this.txbNombreCatalogo.Size = new System.Drawing.Size(139, 27);
            this.txbNombreCatalogo.TabIndex = 10;
            // 
            // txbCodigoCatalogo
            // 
            this.txbCodigoCatalogo.BackColor = System.Drawing.SystemColors.Info;
            this.txbCodigoCatalogo.Location = new System.Drawing.Point(223, 132);
            this.txbCodigoCatalogo.Name = "txbCodigoCatalogo";
            this.txbCodigoCatalogo.Size = new System.Drawing.Size(139, 27);
            this.txbCodigoCatalogo.TabIndex = 9;
            // 
            // txbIDTIPOCATALOGO
            // 
            this.txbIDTIPOCATALOGO.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDTIPOCATALOGO.Location = new System.Drawing.Point(223, 60);
            this.txbIDTIPOCATALOGO.Name = "txbIDTIPOCATALOGO";
            this.txbIDTIPOCATALOGO.Size = new System.Drawing.Size(139, 27);
            this.txbIDTIPOCATALOGO.TabIndex = 8;
            // 
            // txbIDCatalogo
            // 
            this.txbIDCatalogo.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDCatalogo.Location = new System.Drawing.Point(246, 188);
            this.txbIDCatalogo.Name = "txbIDCatalogo";
            this.txbIDCatalogo.Size = new System.Drawing.Size(104, 27);
            this.txbIDCatalogo.TabIndex = 18;
            this.txbIDCatalogo.Visible = false;
            // 
            // frmActaulizarCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 420);
            this.Controls.Add(this.txbIDCatalogo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkBoxactivoCatalogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreCatalogo);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbNombreCatalogo);
            this.Controls.Add(this.txbCodigoCatalogo);
            this.Controls.Add(this.txbIDTIPOCATALOGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.MaximizeBox = false;
            this.Name = "frmActaulizarCatalogo";
            this.Text = "frmActaulizarCatalogo";
            this.Load += new System.EventHandler(this.frmActaulizarCatalogo_Load);
            this.Controls.SetChildIndex(this.txbIDTIPOCATALOGO, 0);
            this.Controls.SetChildIndex(this.txbCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.txbNombreCatalogo, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.lblNombreCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkBoxactivoCatalogo, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDCatalogo, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listarIdTipoCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView listarIdTipoCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreCatalogo;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbNombreCatalogo;
        public System.Windows.Forms.TextBox txbCodigoCatalogo;
        public System.Windows.Forms.TextBox txbIDTIPOCATALOGO;
        public System.Windows.Forms.TextBox txbIDCatalogo;
        public System.Windows.Forms.CheckBox checkBoxactivoCatalogo;
    }
}