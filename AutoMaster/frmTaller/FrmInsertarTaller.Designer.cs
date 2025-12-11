namespace AutoMaster.frmTaller
{
    partial class FrmInsertarTaller
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
            this.dateTimePickerFechaDeSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDeIngreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTRabajador = new System.Windows.Forms.TextBox();
            this.TxbCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescripcionDelTrabjo = new System.Windows.Forms.TextBox();
            this.TXBIdVehiculo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(866, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 451);
            this.panel2.Size = new System.Drawing.Size(866, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 388);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(312, 166);
            // 
            // dateTimePickerFechaDeSalida
            // 
            this.dateTimePickerFechaDeSalida.Location = new System.Drawing.Point(169, 245);
            this.dateTimePickerFechaDeSalida.Name = "dateTimePickerFechaDeSalida";
            this.dateTimePickerFechaDeSalida.Size = new System.Drawing.Size(176, 27);
            this.dateTimePickerFechaDeSalida.TabIndex = 157;
            // 
            // dateTimePickerFechaDeIngreso
            // 
            this.dateTimePickerFechaDeIngreso.Location = new System.Drawing.Point(169, 196);
            this.dateTimePickerFechaDeIngreso.Name = "dateTimePickerFechaDeIngreso";
            this.dateTimePickerFechaDeIngreso.Size = new System.Drawing.Size(176, 27);
            this.dateTimePickerFechaDeIngreso.TabIndex = 158;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 155;
            this.label7.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 156;
            this.label1.Text = "ID\r\nTrbajador ";
            // 
            // IDTRabajador
            // 
            this.IDTRabajador.BackColor = System.Drawing.SystemColors.Info;
            this.IDTRabajador.Location = new System.Drawing.Point(561, 146);
            this.IDTRabajador.Name = "IDTRabajador";
            this.IDTRabajador.Size = new System.Drawing.Size(139, 27);
            this.IDTRabajador.TabIndex = 153;
            // 
            // TxbCosto
            // 
            this.TxbCosto.BackColor = System.Drawing.SystemColors.Info;
            this.TxbCosto.Location = new System.Drawing.Point(561, 94);
            this.TxbCosto.Name = "TxbCosto";
            this.TxbCosto.Size = new System.Drawing.Size(139, 27);
            this.TxbCosto.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 149;
            this.label6.Text = "Fecha De Salida";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(647, 388);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 148;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 150;
            this.label2.Text = "Fecha de Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 38);
            this.label5.TabIndex = 151;
            this.label5.Text = "Descripción del\r\nTrabajo\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 152;
            this.label3.Text = "ID Vehiculo";
            // 
            // txbDescripcionDelTrabjo
            // 
            this.txbDescripcionDelTrabjo.AcceptsReturn = true;
            this.txbDescripcionDelTrabjo.BackColor = System.Drawing.SystemColors.Info;
            this.txbDescripcionDelTrabjo.Location = new System.Drawing.Point(190, 149);
            this.txbDescripcionDelTrabjo.Name = "txbDescripcionDelTrabjo";
            this.txbDescripcionDelTrabjo.Size = new System.Drawing.Size(139, 27);
            this.txbDescripcionDelTrabjo.TabIndex = 147;
            // 
            // TXBIdVehiculo
            // 
            this.TXBIdVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.TXBIdVehiculo.Location = new System.Drawing.Point(190, 102);
            this.TXBIdVehiculo.Name = "TXBIdVehiculo";
            this.TXBIdVehiculo.Size = new System.Drawing.Size(139, 27);
            this.TXBIdVehiculo.TabIndex = 146;
            // 
            // FrmInsertarTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 497);
            this.Controls.Add(this.dateTimePickerFechaDeSalida);
            this.Controls.Add(this.dateTimePickerFechaDeIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTRabajador);
            this.Controls.Add(this.TxbCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDescripcionDelTrabjo);
            this.Controls.Add(this.TXBIdVehiculo);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "FrmInsertarTaller";
            this.Text = "FrmInsertarTaller";
            this.Load += new System.EventHandler(this.FrmInsertarTaller_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.TXBIdVehiculo, 0);
            this.Controls.SetChildIndex(this.txbDescripcionDelTrabjo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxbCosto, 0);
            this.Controls.SetChildIndex(this.IDTRabajador, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFechaDeIngreso, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFechaDeSalida, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePickerFechaDeSalida;
        public System.Windows.Forms.DateTimePicker dateTimePickerFechaDeIngreso;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox IDTRabajador;
        public System.Windows.Forms.TextBox TxbCosto;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbDescripcionDelTrabjo;
        public System.Windows.Forms.TextBox TXBIdVehiculo;
    }
}