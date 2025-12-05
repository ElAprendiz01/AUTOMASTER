namespace AutoMaster.frmServiciosVehiculos
{
    partial class frmInsertarServicioDeVehiculos
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
            this.dateTimePickerFechaDeServicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.IDTRabajador = new System.Windows.Forms.TextBox();
            this.TxbCosto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIDTipoDeServicio = new System.Windows.Forms.TextBox();
            this.TXBIdVehiculo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(863, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Size = new System.Drawing.Size(863, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 405);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(315, 166);
            // 
            // dateTimePickerFechaDeServicio
            // 
            this.dateTimePickerFechaDeServicio.Location = new System.Drawing.Point(208, 196);
            this.dateTimePickerFechaDeServicio.Name = "dateTimePickerFechaDeServicio";
            this.dateTimePickerFechaDeServicio.Size = new System.Drawing.Size(193, 27);
            this.dateTimePickerFechaDeServicio.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 142;
            this.label7.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 143;
            this.label4.Text = "Observaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 144;
            this.label1.Text = "ID\r\nTrbajador ";
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.BackColor = System.Drawing.SystemColors.Info;
            this.txbObservaciones.Location = new System.Drawing.Point(595, 177);
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(139, 27);
            this.txbObservaciones.TabIndex = 139;
            // 
            // IDTRabajador
            // 
            this.IDTRabajador.BackColor = System.Drawing.SystemColors.Info;
            this.IDTRabajador.Location = new System.Drawing.Point(600, 130);
            this.IDTRabajador.Name = "IDTRabajador";
            this.IDTRabajador.Size = new System.Drawing.Size(139, 27);
            this.IDTRabajador.TabIndex = 140;
            // 
            // TxbCosto
            // 
            this.TxbCosto.BackColor = System.Drawing.SystemColors.Info;
            this.TxbCosto.Location = new System.Drawing.Point(600, 86);
            this.TxbCosto.Name = "TxbCosto";
            this.TxbCosto.Size = new System.Drawing.Size(139, 27);
            this.TxbCosto.TabIndex = 141;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(644, 405);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 135;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 136;
            this.label2.Text = "Fecha de Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 137;
            this.label5.Text = "ID Tipo De Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 138;
            this.label3.Text = "ID Vehiculo";
            // 
            // txbIDTipoDeServicio
            // 
            this.txbIDTipoDeServicio.AcceptsReturn = true;
            this.txbIDTipoDeServicio.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDTipoDeServicio.Location = new System.Drawing.Point(229, 149);
            this.txbIDTipoDeServicio.Name = "txbIDTipoDeServicio";
            this.txbIDTipoDeServicio.Size = new System.Drawing.Size(139, 27);
            this.txbIDTipoDeServicio.TabIndex = 134;
            // 
            // TXBIdVehiculo
            // 
            this.TXBIdVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.TXBIdVehiculo.Location = new System.Drawing.Point(229, 102);
            this.TXBIdVehiculo.Name = "TXBIdVehiculo";
            this.TXBIdVehiculo.Size = new System.Drawing.Size(139, 27);
            this.TXBIdVehiculo.TabIndex = 133;
            // 
            // frmInsertarServicioDeVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 514);
            this.Controls.Add(this.dateTimePickerFechaDeServicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbObservaciones);
            this.Controls.Add(this.IDTRabajador);
            this.Controls.Add(this.TxbCosto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIDTipoDeServicio);
            this.Controls.Add(this.TXBIdVehiculo);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmInsertarServicioDeVehiculos";
            this.Text = "frmServicioDeVehiculos";
            this.Load += new System.EventHandler(this.frmInsertarServicioDeVehiculos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.TXBIdVehiculo, 0);
            this.Controls.SetChildIndex(this.txbIDTipoDeServicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.TxbCosto, 0);
            this.Controls.SetChildIndex(this.IDTRabajador, 0);
            this.Controls.SetChildIndex(this.txbObservaciones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFechaDeServicio, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePickerFechaDeServicio;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbObservaciones;
        public System.Windows.Forms.TextBox IDTRabajador;
        public System.Windows.Forms.TextBox TxbCosto;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbIDTipoDeServicio;
        public System.Windows.Forms.TextBox TXBIdVehiculo;
    }
}