namespace AutoMaster.frmPagos
{
    partial class frmInsertarPagos
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
            this.dateTimePickcFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbObservacion = new System.Windows.Forms.TextBox();
            this.txbMetodoDePAgo = new System.Windows.Forms.TextBox();
            this.TXBMonto = new System.Windows.Forms.TextBox();
            this.txbIDFinanciamiento = new System.Windows.Forms.TextBox();
            this.txbIDVenta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(860, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Size = new System.Drawing.Size(860, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 403);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(312, 166);
            // 
            // dateTimePickcFechaPago
            // 
            this.dateTimePickcFechaPago.Location = new System.Drawing.Point(171, 337);
            this.dateTimePickcFechaPago.Name = "dateTimePickcFechaPago";
            this.dateTimePickcFechaPago.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickcFechaPago.TabIndex = 129;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(641, 403);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 122;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 123;
            this.label7.Text = "Observación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 38);
            this.label5.TabIndex = 124;
            this.label5.Text = "Metodo de \r\npago\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 125;
            this.label3.Text = "Monto";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(32, 154);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(146, 19);
            this.lbelCodigoCatalogo.TabIndex = 126;
            this.lbelCodigoCatalogo.Text = "ID Financiamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 38);
            this.label1.TabIndex = 127;
            this.label1.Text = "Fecha de \r\nPago\r\n";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(32, 101);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 128;
            this.Lbl_IdTipoCatalogo.Text = "ID Venta";
            // 
            // txbObservacion
            // 
            this.txbObservacion.BackColor = System.Drawing.SystemColors.Info;
            this.txbObservacion.Location = new System.Drawing.Point(180, 295);
            this.txbObservacion.Name = "txbObservacion";
            this.txbObservacion.Size = new System.Drawing.Size(139, 27);
            this.txbObservacion.TabIndex = 120;
            // 
            // txbMetodoDePAgo
            // 
            this.txbMetodoDePAgo.BackColor = System.Drawing.SystemColors.Info;
            this.txbMetodoDePAgo.Location = new System.Drawing.Point(180, 239);
            this.txbMetodoDePAgo.Name = "txbMetodoDePAgo";
            this.txbMetodoDePAgo.Size = new System.Drawing.Size(139, 27);
            this.txbMetodoDePAgo.TabIndex = 121;
            // 
            // TXBMonto
            // 
            this.TXBMonto.BackColor = System.Drawing.SystemColors.Info;
            this.TXBMonto.Location = new System.Drawing.Point(180, 192);
            this.TXBMonto.Name = "TXBMonto";
            this.TXBMonto.Size = new System.Drawing.Size(139, 27);
            this.TXBMonto.TabIndex = 118;
            // 
            // txbIDFinanciamiento
            // 
            this.txbIDFinanciamiento.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDFinanciamiento.Location = new System.Drawing.Point(180, 146);
            this.txbIDFinanciamiento.Name = "txbIDFinanciamiento";
            this.txbIDFinanciamiento.Size = new System.Drawing.Size(139, 27);
            this.txbIDFinanciamiento.TabIndex = 119;
            // 
            // txbIDVenta
            // 
            this.txbIDVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDVenta.Location = new System.Drawing.Point(180, 93);
            this.txbIDVenta.Name = "txbIDVenta";
            this.txbIDVenta.Size = new System.Drawing.Size(139, 27);
            this.txbIDVenta.TabIndex = 117;
            // 
            // frmInsertarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.dateTimePickcFechaPago);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbObservacion);
            this.Controls.Add(this.txbMetodoDePAgo);
            this.Controls.Add(this.TXBMonto);
            this.Controls.Add(this.txbIDFinanciamiento);
            this.Controls.Add(this.txbIDVenta);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmInsertarPagos";
            this.Text = "frmInsertarPagos";
            this.Load += new System.EventHandler(this.frmInsertarPagos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDVenta, 0);
            this.Controls.SetChildIndex(this.txbIDFinanciamiento, 0);
            this.Controls.SetChildIndex(this.TXBMonto, 0);
            this.Controls.SetChildIndex(this.txbMetodoDePAgo, 0);
            this.Controls.SetChildIndex(this.txbObservacion, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.dateTimePickcFechaPago, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePickcFechaPago;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbObservacion;
        public System.Windows.Forms.TextBox txbMetodoDePAgo;
        public System.Windows.Forms.TextBox TXBMonto;
        public System.Windows.Forms.TextBox txbIDFinanciamiento;
        public System.Windows.Forms.TextBox txbIDVenta;
    }
}