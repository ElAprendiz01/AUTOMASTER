namespace AutoMaster
{
    partial class Frm_insertar_Nuevo_catalogo
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
            this.txbIDTIPOCATALOGO = new System.Windows.Forms.TextBox();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbCodigoCatalogo = new System.Windows.Forms.TextBox();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.txbNombreCatalogo = new System.Windows.Forms.TextBox();
            this.lblNombreCatalogo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxactivoCatalogo = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listarIdTipoCat = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarIdTipoCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Size = new System.Drawing.Size(721, 56);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Size = new System.Drawing.Size(721, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 310);
            this.button1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(0, 100);
            // 
            // txbIDTIPOCATALOGO
            // 
            this.txbIDTIPOCATALOGO.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDTIPOCATALOGO.Location = new System.Drawing.Point(200, 70);
            this.txbIDTIPOCATALOGO.Name = "txbIDTIPOCATALOGO";
            this.txbIDTIPOCATALOGO.Size = new System.Drawing.Size(139, 27);
            this.txbIDTIPOCATALOGO.TabIndex = 1;
            this.txbIDTIPOCATALOGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDTIPOCATALOGO_KeyPress);
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(24, 78);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(160, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 4;
            this.Lbl_IdTipoCatalogo.Text = "ID Tipo De Catálogo";
            this.Lbl_IdTipoCatalogo.Click += new System.EventHandler(this.Lbl_IdTipoCatalogo_Click);
            // 
            // txbCodigoCatalogo
            // 
            this.txbCodigoCatalogo.BackColor = System.Drawing.SystemColors.Info;
            this.txbCodigoCatalogo.Location = new System.Drawing.Point(200, 142);
            this.txbCodigoCatalogo.Name = "txbCodigoCatalogo";
            this.txbCodigoCatalogo.Size = new System.Drawing.Size(139, 27);
            this.txbCodigoCatalogo.TabIndex = 2;
            this.txbCodigoCatalogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDTIPOCATALOGO_KeyPress);
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(24, 150);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(158, 19);
            this.lbelCodigoCatalogo.TabIndex = 4;
            this.lbelCodigoCatalogo.Text = "Código de Catálogo";
            this.lbelCodigoCatalogo.Click += new System.EventHandler(this.Lbl_IdTipoCatalogo_Click);
            // 
            // txbNombreCatalogo
            // 
            this.txbNombreCatalogo.BackColor = System.Drawing.SystemColors.Info;
            this.txbNombreCatalogo.Location = new System.Drawing.Point(555, 70);
            this.txbNombreCatalogo.Name = "txbNombreCatalogo";
            this.txbNombreCatalogo.Size = new System.Drawing.Size(139, 27);
            this.txbNombreCatalogo.TabIndex = 3;
            this.txbNombreCatalogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDTIPOCATALOGO_KeyPress);
            // 
            // lblNombreCatalogo
            // 
            this.lblNombreCatalogo.AutoSize = true;
            this.lblNombreCatalogo.Location = new System.Drawing.Point(379, 78);
            this.lblNombreCatalogo.Name = "lblNombreCatalogo";
            this.lblNombreCatalogo.Size = new System.Drawing.Size(167, 19);
            this.lblNombreCatalogo.TabIndex = 4;
            this.lblNombreCatalogo.Text = "Nombre de Catálogo";
            this.lblNombreCatalogo.Click += new System.EventHandler(this.Lbl_IdTipoCatalogo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Activo";
            this.label3.Click += new System.EventHandler(this.Lbl_IdTipoCatalogo_Click);
            // 
            // checkBoxactivoCatalogo
            // 
            this.checkBoxactivoCatalogo.AutoSize = true;
            this.checkBoxactivoCatalogo.Location = new System.Drawing.Point(549, 148);
            this.checkBoxactivoCatalogo.Name = "checkBoxactivoCatalogo";
            this.checkBoxactivoCatalogo.Size = new System.Drawing.Size(154, 23);
            this.checkBoxactivoCatalogo.TabIndex = 4;
            this.checkBoxactivoCatalogo.Text = "Activo o inactivo";
            this.checkBoxactivoCatalogo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.listarIdTipoCat);
            this.panel3.Location = new System.Drawing.Point(36, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 138);
            this.panel3.TabIndex = 6;
            // 
            // listarIdTipoCat
            // 
            this.listarIdTipoCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarIdTipoCat.Location = new System.Drawing.Point(14, 14);
            this.listarIdTipoCat.Name = "listarIdTipoCat";
            this.listarIdTipoCat.Size = new System.Drawing.Size(288, 107);
            this.listarIdTipoCat.TabIndex = 0;
            this.listarIdTipoCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(479, 310);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(179, 9);
            this.label4.MaximumSize = new System.Drawing.Size(400, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 31);
            this.label4.TabIndex = 38;
            this.label4.Text = "Registro  De Catálogos";
            // 
            // Frm_insertar_Nuevo_catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 411);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkBoxactivoCatalogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreCatalogo);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbNombreCatalogo);
            this.Controls.Add(this.txbCodigoCatalogo);
            this.Controls.Add(this.txbIDTIPOCATALOGO);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "Frm_insertar_Nuevo_catalogo";
            this.Text = "FrmAgregarNuevo_catalogo";
            this.Load += new System.EventHandler(this.FrmAgregarNuevo_catalogo_Load);
            this.Controls.SetChildIndex(this.txbIDTIPOCATALOGO, 0);
            this.Controls.SetChildIndex(this.txbCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.txbNombreCatalogo, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.lblNombreCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.checkBoxactivoCatalogo, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listarIdTipoCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbIDTIPOCATALOGO;
        public System.Windows.Forms.TextBox txbCodigoCatalogo;
        public System.Windows.Forms.TextBox txbNombreCatalogo;
        private System.Windows.Forms.Label lblNombreCatalogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxactivoCatalogo;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView listarIdTipoCat;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
    }
}