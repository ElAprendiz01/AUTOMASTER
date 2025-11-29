namespace AutoMaster.frm_Financiamiento
{
    partial class frmActualizarFinanciamiento
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
            this.dateTimePickcFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbIdFinanciamiento = new System.Windows.Forms.TextBox();
            this.txbTasaDeInteres = new System.Windows.Forms.TextBox();
            this.txbplazoEnElMes = new System.Windows.Forms.TextBox();
            this.TXBMonto = new System.Windows.Forms.TextBox();
            this.txbIDClinte = new System.Windows.Forms.TextBox();
            this.txbIDVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechadeCanselacion = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(830, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Size = new System.Drawing.Size(830, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 427);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(282, 166);
            // 
            // dateTimePickcFechaInicio
            // 
            this.dateTimePickcFechaInicio.Location = new System.Drawing.Point(469, 102);
            this.dateTimePickcFechaInicio.Name = "dateTimePickcFechaInicio";
            this.dateTimePickcFechaInicio.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickcFechaInicio.TabIndex = 100;
            this.dateTimePickcFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePickcFechaInicio_ValueChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Location = new System.Drawing.Point(626, 427);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 55);
            this.btnActualizar.TabIndex = 91;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 38);
            this.label2.TabIndex = 94;
            this.label2.Text = "Fecha de \r\ncancelación \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 95;
            this.label7.Text = "Tasa de Interés ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Monto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(39, 155);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(82, 19);
            this.lbelCodigoCatalogo.TabIndex = 97;
            this.lbelCodigoCatalogo.Text = "ID Cliente";
            this.lbelCodigoCatalogo.Click += new System.EventHandler(this.lbelCodigoCatalogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 38);
            this.label1.TabIndex = 98;
            this.label1.Text = "Fecha de \r\ninicio\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(39, 102);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 99;
            this.Lbl_IdTipoCatalogo.Text = "ID Venta";
            this.Lbl_IdTipoCatalogo.Click += new System.EventHandler(this.Lbl_IdTipoCatalogo_Click);
            // 
            // txbIdFinanciamiento
            // 
            this.txbIdFinanciamiento.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdFinanciamiento.Location = new System.Drawing.Point(679, 105);
            this.txbIdFinanciamiento.Name = "txbIdFinanciamiento";
            this.txbIdFinanciamiento.Size = new System.Drawing.Size(139, 27);
            this.txbIdFinanciamiento.TabIndex = 84;
            this.txbIdFinanciamiento.Visible = false;
            // 
            // txbTasaDeInteres
            // 
            this.txbTasaDeInteres.BackColor = System.Drawing.SystemColors.Info;
            this.txbTasaDeInteres.Location = new System.Drawing.Point(215, 296);
            this.txbTasaDeInteres.Name = "txbTasaDeInteres";
            this.txbTasaDeInteres.Size = new System.Drawing.Size(139, 27);
            this.txbTasaDeInteres.TabIndex = 89;
            this.txbTasaDeInteres.TextChanged += new System.EventHandler(this.txbTasaDeInteres_TextChanged);
            // 
            // txbplazoEnElMes
            // 
            this.txbplazoEnElMes.BackColor = System.Drawing.SystemColors.Info;
            this.txbplazoEnElMes.Location = new System.Drawing.Point(215, 240);
            this.txbplazoEnElMes.Name = "txbplazoEnElMes";
            this.txbplazoEnElMes.Size = new System.Drawing.Size(139, 27);
            this.txbplazoEnElMes.TabIndex = 90;
            this.txbplazoEnElMes.TextChanged += new System.EventHandler(this.txbplazoEnElMes_TextChanged);
            // 
            // TXBMonto
            // 
            this.TXBMonto.BackColor = System.Drawing.SystemColors.Info;
            this.TXBMonto.Location = new System.Drawing.Point(215, 193);
            this.TXBMonto.Name = "TXBMonto";
            this.TXBMonto.Size = new System.Drawing.Size(139, 27);
            this.TXBMonto.TabIndex = 87;
            this.TXBMonto.TextChanged += new System.EventHandler(this.TXBMonto_TextChanged);
            // 
            // txbIDClinte
            // 
            this.txbIDClinte.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDClinte.Location = new System.Drawing.Point(215, 147);
            this.txbIDClinte.Name = "txbIDClinte";
            this.txbIDClinte.Size = new System.Drawing.Size(139, 27);
            this.txbIDClinte.TabIndex = 88;
            this.txbIDClinte.TextChanged += new System.EventHandler(this.txbIDClinte_TextChanged);
            // 
            // txbIDVenta
            // 
            this.txbIDVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDVenta.Location = new System.Drawing.Point(215, 94);
            this.txbIDVenta.Name = "txbIDVenta";
            this.txbIDVenta.Size = new System.Drawing.Size(139, 27);
            this.txbIDVenta.TabIndex = 83;
            this.txbIDVenta.TextChanged += new System.EventHandler(this.txbIDVenta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 38);
            this.label5.TabIndex = 96;
            this.label5.Text = "Plazo en \r\nmeses ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerFechadeCanselacion
            // 
            this.dateTimePickerFechadeCanselacion.Location = new System.Drawing.Point(469, 166);
            this.dateTimePickerFechadeCanselacion.Name = "dateTimePickerFechadeCanselacion";
            this.dateTimePickerFechadeCanselacion.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerFechadeCanselacion.TabIndex = 100;
            this.dateTimePickerFechadeCanselacion.ValueChanged += new System.EventHandler(this.dateTimePickerFechadeCanselacion_ValueChanged);
            // 
            // frmActualizarFinanciamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 536);
            this.Controls.Add(this.dateTimePickerFechadeCanselacion);
            this.Controls.Add(this.dateTimePickcFechaInicio);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbIdFinanciamiento);
            this.Controls.Add(this.txbTasaDeInteres);
            this.Controls.Add(this.txbplazoEnElMes);
            this.Controls.Add(this.TXBMonto);
            this.Controls.Add(this.txbIDClinte);
            this.Controls.Add(this.txbIDVenta);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmActualizarFinanciamiento";
            this.Text = "frmActualizarFinanciamiento";
            this.Load += new System.EventHandler(this.frmActualizarFinanciamiento_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDVenta, 0);
            this.Controls.SetChildIndex(this.txbIDClinte, 0);
            this.Controls.SetChildIndex(this.TXBMonto, 0);
            this.Controls.SetChildIndex(this.txbplazoEnElMes, 0);
            this.Controls.SetChildIndex(this.txbTasaDeInteres, 0);
            this.Controls.SetChildIndex(this.txbIdFinanciamiento, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.dateTimePickcFechaInicio, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFechadeCanselacion, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePickcFechaInicio;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbIdFinanciamiento;
        public System.Windows.Forms.TextBox txbTasaDeInteres;
        public System.Windows.Forms.TextBox txbplazoEnElMes;
        public System.Windows.Forms.TextBox TXBMonto;
        public System.Windows.Forms.TextBox txbIDClinte;
        public System.Windows.Forms.TextBox txbIDVenta;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePickerFechadeCanselacion;
    }
}