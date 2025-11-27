namespace AutoMaster
{
    partial class frm_Actualizar_DatosPersonales
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreCatalogo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbSegundoApellido = new System.Windows.Forms.TextBox();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.txbPrimerApellido = new System.Windows.Forms.TextBox();
            this.txbIdTipoDni = new System.Windows.Forms.TextBox();
            this.txbIdGenero = new System.Windows.Forms.TextBox();
            this.txbSegundoNombre = new System.Windows.Forms.TextBox();
            this.txbPrimerNombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listarIdTipoCat = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbIdPersonal = new System.Windows.Forms.TextBox();
            this.txbIdEstado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarIdTipoCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Size = new System.Drawing.Size(942, 81);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Size = new System.Drawing.Size(942, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 398);
            this.button1.TabIndex = 10;
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-61, -41);
            this.pictureBox1.Size = new System.Drawing.Size(515, 189);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(321, 20);
            this.label4.MaximumSize = new System.Drawing.Size(500, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 31);
            this.label4.TabIndex = 68;
            this.label4.Text = "Actualización  De Datos Personales \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "ID Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "DNI";
            // 
            // lblNombreCatalogo
            // 
            this.lblNombreCatalogo.AutoSize = true;
            this.lblNombreCatalogo.Location = new System.Drawing.Point(15, 186);
            this.lblNombreCatalogo.Name = "lblNombreCatalogo";
            this.lblNombreCatalogo.Size = new System.Drawing.Size(125, 19);
            this.lblNombreCatalogo.TabIndex = 62;
            this.lblNombreCatalogo.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 63;
            this.label5.Text = "ID Tipo De DNI";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(15, 135);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(144, 19);
            this.lbelCodigoCatalogo.TabIndex = 64;
            this.lbelCodigoCatalogo.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "ID Genero";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(15, 93);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(126, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 65;
            this.Lbl_IdTipoCatalogo.Text = "Primer Nombre";
            // 
            // txbSegundoApellido
            // 
            this.txbSegundoApellido.BackColor = System.Drawing.SystemColors.Info;
            this.txbSegundoApellido.Location = new System.Drawing.Point(191, 223);
            this.txbSegundoApellido.Name = "txbSegundoApellido";
            this.txbSegundoApellido.Size = new System.Drawing.Size(139, 27);
            this.txbSegundoApellido.TabIndex = 4;
            this.txbSegundoApellido.TextChanged += new System.EventHandler(this.txbSegundoApellido_TextChanged);
            this.txbSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbDNI
            // 
            this.txbDNI.BackColor = System.Drawing.SystemColors.Info;
            this.txbDNI.Location = new System.Drawing.Point(532, 178);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(139, 27);
            this.txbDNI.TabIndex = 7;
            this.txbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbPrimerApellido
            // 
            this.txbPrimerApellido.BackColor = System.Drawing.SystemColors.Info;
            this.txbPrimerApellido.Location = new System.Drawing.Point(191, 178);
            this.txbPrimerApellido.Name = "txbPrimerApellido";
            this.txbPrimerApellido.Size = new System.Drawing.Size(139, 27);
            this.txbPrimerApellido.TabIndex = 3;
            this.txbPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbIdTipoDni
            // 
            this.txbIdTipoDni.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdTipoDni.Location = new System.Drawing.Point(532, 132);
            this.txbIdTipoDni.Name = "txbIdTipoDni";
            this.txbIdTipoDni.Size = new System.Drawing.Size(139, 27);
            this.txbIdTipoDni.TabIndex = 6;
            this.txbIdTipoDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbIdGenero
            // 
            this.txbIdGenero.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdGenero.Location = new System.Drawing.Point(532, 85);
            this.txbIdGenero.Name = "txbIdGenero";
            this.txbIdGenero.Size = new System.Drawing.Size(139, 27);
            this.txbIdGenero.TabIndex = 5;
            this.txbIdGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbSegundoNombre
            // 
            this.txbSegundoNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txbSegundoNombre.Location = new System.Drawing.Point(191, 132);
            this.txbSegundoNombre.Name = "txbSegundoNombre";
            this.txbSegundoNombre.Size = new System.Drawing.Size(139, 27);
            this.txbSegundoNombre.TabIndex = 2;
            this.txbSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbPrimerNombre
            // 
            this.txbPrimerNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txbPrimerNombre.Location = new System.Drawing.Point(191, 85);
            this.txbPrimerNombre.Name = "txbPrimerNombre";
            this.txbPrimerNombre.Size = new System.Drawing.Size(139, 27);
            this.txbPrimerNombre.TabIndex = 1;
            this.txbPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.listarIdTipoCat);
            this.panel3.Location = new System.Drawing.Point(19, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 154);
            this.panel3.TabIndex = 67;
            // 
            // listarIdTipoCat
            // 
            this.listarIdTipoCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarIdTipoCat.Location = new System.Drawing.Point(12, 12);
            this.listarIdTipoCat.Name = "listarIdTipoCat";
            this.listarIdTipoCat.Size = new System.Drawing.Size(313, 132);
            this.listarIdTipoCat.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(420, 377);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbIdPersonal
            // 
            this.txbIdPersonal.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdPersonal.Location = new System.Drawing.Point(437, 288);
            this.txbIdPersonal.Name = "txbIdPersonal";
            this.txbIdPersonal.Size = new System.Drawing.Size(139, 27);
            this.txbIdPersonal.TabIndex = 7;
            this.txbIdPersonal.Visible = false;
            this.txbIdPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // txbIdEstado
            // 
            this.txbIdEstado.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdEstado.Location = new System.Drawing.Point(532, 224);
            this.txbIdEstado.Name = "txbIdEstado";
            this.txbIdEstado.Size = new System.Drawing.Size(139, 27);
            this.txbIdEstado.TabIndex = 7;
            this.txbIdEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // frm_Actualizar_DatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombreCatalogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbSegundoApellido);
            this.Controls.Add(this.txbIdPersonal);
            this.Controls.Add(this.txbIdEstado);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.txbPrimerApellido);
            this.Controls.Add(this.txbIdTipoDni);
            this.Controls.Add(this.txbIdGenero);
            this.Controls.Add(this.txbSegundoNombre);
            this.Controls.Add(this.txbPrimerNombre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frm_Actualizar_DatosPersonales";
            this.Text = "frm_Actualizar_DatosPersonales";
            this.Load += new System.EventHandler(this.frm_Actualizar_DatosPersonales_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.txbPrimerNombre, 0);
            this.Controls.SetChildIndex(this.txbSegundoNombre, 0);
            this.Controls.SetChildIndex(this.txbIdGenero, 0);
            this.Controls.SetChildIndex(this.txbIdTipoDni, 0);
            this.Controls.SetChildIndex(this.txbPrimerApellido, 0);
            this.Controls.SetChildIndex(this.txbDNI, 0);
            this.Controls.SetChildIndex(this.txbIdEstado, 0);
            this.Controls.SetChildIndex(this.txbIdPersonal, 0);
            this.Controls.SetChildIndex(this.txbSegundoApellido, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblNombreCatalogo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listarIdTipoCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombreCatalogo;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbSegundoApellido;
        public System.Windows.Forms.TextBox txbDNI;
        public System.Windows.Forms.TextBox txbPrimerApellido;
        public System.Windows.Forms.TextBox txbIdTipoDni;
        public System.Windows.Forms.TextBox txbIdGenero;
        public System.Windows.Forms.TextBox txbSegundoNombre;
        public System.Windows.Forms.TextBox txbPrimerNombre;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView listarIdTipoCat;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txbIdPersonal;
        public System.Windows.Forms.TextBox txbIdEstado;
    }
}