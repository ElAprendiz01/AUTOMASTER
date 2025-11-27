namespace AutoMaster
{
    partial class Frm_insertar_DatosPersonales
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
            this.lblNombreCatalogo = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbPrimerApellido = new System.Windows.Forms.TextBox();
            this.txbSegundoNombre = new System.Windows.Forms.TextBox();
            this.txbPrimerNombre = new System.Windows.Forms.TextBox();
            this.listarGenero = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listarTiposdeDNI = new System.Windows.Forms.DataGridView();
            this.listarEstados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbSegundoApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdGenero = new System.Windows.Forms.TextBox();
            this.txbIdTipoDni = new System.Windows.Forms.TextBox();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIDEstadodtp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarGenero)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listarTiposdeDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 452);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(776, 398);
            this.button1.TabIndex = 10;
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // lblNombreCatalogo
            // 
            this.lblNombreCatalogo.AutoSize = true;
            this.lblNombreCatalogo.Location = new System.Drawing.Point(8, 189);
            this.lblNombreCatalogo.Name = "lblNombreCatalogo";
            this.lblNombreCatalogo.Size = new System.Drawing.Size(125, 19);
            this.lblNombreCatalogo.TabIndex = 44;
            this.lblNombreCatalogo.Text = "Primer Apellido";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(8, 138);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(144, 19);
            this.lbelCodigoCatalogo.TabIndex = 45;
            this.lbelCodigoCatalogo.Text = "Segundo Nombre";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(8, 96);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(126, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 46;
            this.Lbl_IdTipoCatalogo.Text = "Primer Nombre";
            // 
            // txbPrimerApellido
            // 
            this.txbPrimerApellido.BackColor = System.Drawing.SystemColors.Info;
            this.txbPrimerApellido.Location = new System.Drawing.Point(184, 181);
            this.txbPrimerApellido.Name = "txbPrimerApellido";
            this.txbPrimerApellido.Size = new System.Drawing.Size(139, 27);
            this.txbPrimerApellido.TabIndex = 3;
            this.txbPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // txbSegundoNombre
            // 
            this.txbSegundoNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txbSegundoNombre.Location = new System.Drawing.Point(184, 135);
            this.txbSegundoNombre.Name = "txbSegundoNombre";
            this.txbSegundoNombre.Size = new System.Drawing.Size(139, 27);
            this.txbSegundoNombre.TabIndex = 2;
            this.txbSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // txbPrimerNombre
            // 
            this.txbPrimerNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txbPrimerNombre.Location = new System.Drawing.Point(184, 88);
            this.txbPrimerNombre.Name = "txbPrimerNombre";
            this.txbPrimerNombre.Size = new System.Drawing.Size(139, 27);
            this.txbPrimerNombre.TabIndex = 1;
            this.txbPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // listarGenero
            // 
            this.listarGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarGenero.Location = new System.Drawing.Point(12, 8);
            this.listarGenero.Name = "listarGenero";
            this.listarGenero.Size = new System.Drawing.Size(147, 142);
            this.listarGenero.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.listarTiposdeDNI);
            this.panel3.Controls.Add(this.listarEstados);
            this.panel3.Controls.Add(this.listarGenero);
            this.panel3.Location = new System.Drawing.Point(12, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 162);
            this.panel3.TabIndex = 47;
            // 
            // listarTiposdeDNI
            // 
            this.listarTiposdeDNI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarTiposdeDNI.Location = new System.Drawing.Point(317, 8);
            this.listarTiposdeDNI.Name = "listarTiposdeDNI";
            this.listarTiposdeDNI.Size = new System.Drawing.Size(147, 142);
            this.listarTiposdeDNI.TabIndex = 0;
            // 
            // listarEstados
            // 
            this.listarEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarEstados.Location = new System.Drawing.Point(164, 10);
            this.listarEstados.Name = "listarEstados";
            this.listarEstados.Size = new System.Drawing.Size(147, 140);
            this.listarEstados.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(311, 9);
            this.label4.MaximumSize = new System.Drawing.Size(400, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 62);
            this.label4.TabIndex = 49;
            this.label4.Text = "Registro  De Datos Personales \r\n";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(668, 398);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // txbSegundoApellido
            // 
            this.txbSegundoApellido.BackColor = System.Drawing.SystemColors.Info;
            this.txbSegundoApellido.Location = new System.Drawing.Point(184, 226);
            this.txbSegundoApellido.Name = "txbSegundoApellido";
            this.txbSegundoApellido.Size = new System.Drawing.Size(139, 27);
            this.txbSegundoApellido.TabIndex = 4;
            this.txbSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Segundo Apellido";
            // 
            // txbIdGenero
            // 
            this.txbIdGenero.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdGenero.Location = new System.Drawing.Point(525, 88);
            this.txbIdGenero.Name = "txbIdGenero";
            this.txbIdGenero.Size = new System.Drawing.Size(139, 27);
            this.txbIdGenero.TabIndex = 5;
            this.txbIdGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // txbIdTipoDni
            // 
            this.txbIdTipoDni.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdTipoDni.Location = new System.Drawing.Point(525, 135);
            this.txbIdTipoDni.Name = "txbIdTipoDni";
            this.txbIdTipoDni.Size = new System.Drawing.Size(139, 27);
            this.txbIdTipoDni.TabIndex = 6;
            this.txbIdTipoDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // txbDNI
            // 
            this.txbDNI.BackColor = System.Drawing.SystemColors.Info;
            this.txbDNI.Location = new System.Drawing.Point(525, 181);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(139, 27);
            this.txbDNI.TabIndex = 7;
            this.txbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "ID Tipo De DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "DNI";
            // 
            // txbIDEstadodtp
            // 
            this.txbIDEstadodtp.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDEstadodtp.Location = new System.Drawing.Point(525, 231);
            this.txbIDEstadodtp.Name = "txbIDEstadodtp";
            this.txbIDEstadodtp.Size = new System.Drawing.Size(139, 27);
            this.txbIDEstadodtp.TabIndex = 8;
            this.txbIDEstadodtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrimerNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "ID Estado";
            // 
            // Frm_insertar_DatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombreCatalogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbSegundoApellido);
            this.Controls.Add(this.txbIDEstadodtp);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.txbPrimerApellido);
            this.Controls.Add(this.txbIdTipoDni);
            this.Controls.Add(this.txbIdGenero);
            this.Controls.Add(this.txbSegundoNombre);
            this.Controls.Add(this.txbPrimerNombre);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "Frm_insertar_DatosPersonales";
            this.Text = "Frm_insertar_DatosPersonales";
            this.Load += new System.EventHandler(this.Frm_insertar_DatosPersonales_Load);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.txbPrimerNombre, 0);
            this.Controls.SetChildIndex(this.txbSegundoNombre, 0);
            this.Controls.SetChildIndex(this.txbIdGenero, 0);
            this.Controls.SetChildIndex(this.txbIdTipoDni, 0);
            this.Controls.SetChildIndex(this.txbPrimerApellido, 0);
            this.Controls.SetChildIndex(this.txbDNI, 0);
            this.Controls.SetChildIndex(this.txbIDEstadodtp, 0);
            this.Controls.SetChildIndex(this.txbSegundoApellido, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblNombreCatalogo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarGenero)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listarTiposdeDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombreCatalogo;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbPrimerApellido;
        public System.Windows.Forms.TextBox txbSegundoNombre;
        public System.Windows.Forms.TextBox txbPrimerNombre;
        public System.Windows.Forms.DataGridView listarGenero;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txbSegundoApellido;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbIdGenero;
        public System.Windows.Forms.TextBox txbIdTipoDni;
        public System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbIDEstadodtp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView listarEstados;
        public System.Windows.Forms.DataGridView listarTiposdeDNI;
    }
}