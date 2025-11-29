namespace AutoMaster.FrmVentas
{
    partial class frmAtualizarVenta
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbIdVentas = new System.Windows.Forms.TextBox();
            this.txbObservacion = new System.Windows.Forms.TextBox();
            this.txbPrecioDeVenta = new System.Windows.Forms.TextBox();
            this.txbIdEmpleado = new System.Windows.Forms.TextBox();
            this.txbIdCliente = new System.Windows.Forms.TextBox();
            this.txbIDVehiculo = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechadeVenta = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(852, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Size = new System.Drawing.Size(852, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 430);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(284, 166);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Location = new System.Drawing.Point(523, 400);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 55);
            this.btnActualizar.TabIndex = 88;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 89;
            this.label7.Text = "Observación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 43);
            this.label5.TabIndex = 90;
            this.label5.Text = "Precio de\r\nventa\r\n";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "ID Empleado";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(27, 151);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(82, 19);
            this.lbelCodigoCatalogo.TabIndex = 92;
            this.lbelCodigoCatalogo.Text = "ID Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "Fecha de venta ";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(27, 102);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(96, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 94;
            this.Lbl_IdTipoCatalogo.Text = "ID Vehículo";
            // 
            // txbIdVentas
            // 
            this.txbIdVentas.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdVentas.Location = new System.Drawing.Point(678, 97);
            this.txbIdVentas.Name = "txbIdVentas";
            this.txbIdVentas.Size = new System.Drawing.Size(139, 27);
            this.txbIdVentas.TabIndex = 83;
            this.txbIdVentas.Visible = false;
            // 
            // txbObservacion
            // 
            this.txbObservacion.BackColor = System.Drawing.SystemColors.Info;
            this.txbObservacion.Location = new System.Drawing.Point(457, 186);
            this.txbObservacion.Name = "txbObservacion";
            this.txbObservacion.Size = new System.Drawing.Size(200, 27);
            this.txbObservacion.TabIndex = 84;
            // 
            // txbPrecioDeVenta
            // 
            this.txbPrecioDeVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txbPrecioDeVenta.Location = new System.Drawing.Point(457, 135);
            this.txbPrecioDeVenta.Name = "txbPrecioDeVenta";
            this.txbPrecioDeVenta.Size = new System.Drawing.Size(200, 27);
            this.txbPrecioDeVenta.TabIndex = 85;
            // 
            // txbIdEmpleado
            // 
            this.txbIdEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdEmpleado.Location = new System.Drawing.Point(139, 191);
            this.txbIdEmpleado.Name = "txbIdEmpleado";
            this.txbIdEmpleado.Size = new System.Drawing.Size(172, 27);
            this.txbIdEmpleado.TabIndex = 86;
            this.txbIdEmpleado.TextChanged += new System.EventHandler(this.txbIdEmpleado_TextChanged);
            // 
            // txbIdCliente
            // 
            this.txbIdCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdCliente.Location = new System.Drawing.Point(139, 143);
            this.txbIdCliente.Name = "txbIdCliente";
            this.txbIdCliente.Size = new System.Drawing.Size(172, 27);
            this.txbIdCliente.TabIndex = 87;
            // 
            // txbIDVehiculo
            // 
            this.txbIDVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDVehiculo.Location = new System.Drawing.Point(139, 92);
            this.txbIDVehiculo.Name = "txbIDVehiculo";
            this.txbIDVehiculo.Size = new System.Drawing.Size(172, 27);
            this.txbIDVehiculo.TabIndex = 82;
            // 
            // dateTimePickerFechadeVenta
            // 
            this.dateTimePickerFechadeVenta.Location = new System.Drawing.Point(457, 94);
            this.dateTimePickerFechadeVenta.Name = "dateTimePickerFechadeVenta";
            this.dateTimePickerFechadeVenta.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerFechadeVenta.TabIndex = 95;
            // 
            // frmAtualizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 539);
            this.Controls.Add(this.dateTimePickerFechadeVenta);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbIdVentas);
            this.Controls.Add(this.txbObservacion);
            this.Controls.Add(this.txbPrecioDeVenta);
            this.Controls.Add(this.txbIdEmpleado);
            this.Controls.Add(this.txbIdCliente);
            this.Controls.Add(this.txbIDVehiculo);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmAtualizarVenta";
            this.Text = "frmAtualizarVenta";
            this.Load += new System.EventHandler(this.frmAtualizarVenta_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDVehiculo, 0);
            this.Controls.SetChildIndex(this.txbIdCliente, 0);
            this.Controls.SetChildIndex(this.txbIdEmpleado, 0);
            this.Controls.SetChildIndex(this.txbPrecioDeVenta, 0);
            this.Controls.SetChildIndex(this.txbObservacion, 0);
            this.Controls.SetChildIndex(this.txbIdVentas, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFechadeVenta, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbIdVentas;
        public System.Windows.Forms.TextBox txbObservacion;
        public System.Windows.Forms.TextBox txbPrecioDeVenta;
        public System.Windows.Forms.TextBox txbIdEmpleado;
        public System.Windows.Forms.TextBox txbIdCliente;
        public System.Windows.Forms.TextBox txbIDVehiculo;
        public System.Windows.Forms.DateTimePicker dateTimePickerFechadeVenta;
    }
}