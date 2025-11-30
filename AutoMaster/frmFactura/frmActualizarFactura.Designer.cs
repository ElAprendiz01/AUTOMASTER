namespace AutoMaster.frmFactura
{
    partial class frmActualizarFactura
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
            this.txbIdFactura = new System.Windows.Forms.TextBox();
            this.txbsubTotal = new System.Windows.Forms.TextBox();
            this.txbNumeroFactura = new System.Windows.Forms.TextBox();
            this.txbIDFinanciamiento = new System.Windows.Forms.TextBox();
            this.txbIDPago = new System.Windows.Forms.TextBox();
            this.txbIDVenta = new System.Windows.Forms.TextBox();
            this.txbIVA = new System.Windows.Forms.TextBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(898, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Size = new System.Drawing.Size(898, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 426);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-37, -38);
            this.pictureBox1.Size = new System.Drawing.Size(329, 166);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Location = new System.Drawing.Point(15, 426);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 55);
            this.btnActualizar.TabIndex = 107;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 109;
            this.label7.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 38);
            this.label5.TabIndex = 110;
            this.label5.Text = "Número de \r\nfactura\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "ID Financiamiento";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(24, 147);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(69, 19);
            this.lbelCodigoCatalogo.TabIndex = 112;
            this.lbelCodigoCatalogo.Text = "ID Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "IVA";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(24, 109);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 114;
            this.Lbl_IdTipoCatalogo.Text = "ID Venta";
            // 
            // txbIdFactura
            // 
            this.txbIdFactura.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdFactura.Location = new System.Drawing.Point(168, 426);
            this.txbIdFactura.Name = "txbIdFactura";
            this.txbIdFactura.Size = new System.Drawing.Size(139, 27);
            this.txbIdFactura.TabIndex = 102;
            this.txbIdFactura.Visible = false;
            // 
            // txbsubTotal
            // 
            this.txbsubTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txbsubTotal.Location = new System.Drawing.Point(200, 278);
            this.txbsubTotal.Name = "txbsubTotal";
            this.txbsubTotal.Size = new System.Drawing.Size(139, 27);
            this.txbsubTotal.TabIndex = 105;
            this.txbsubTotal.TextChanged += new System.EventHandler(this.txbTasaDeInteres_TextChanged);
            // 
            // txbNumeroFactura
            // 
            this.txbNumeroFactura.BackColor = System.Drawing.SystemColors.Info;
            this.txbNumeroFactura.Location = new System.Drawing.Point(200, 229);
            this.txbNumeroFactura.Name = "txbNumeroFactura";
            this.txbNumeroFactura.Size = new System.Drawing.Size(139, 27);
            this.txbNumeroFactura.TabIndex = 106;
            // 
            // txbIDFinanciamiento
            // 
            this.txbIDFinanciamiento.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDFinanciamiento.Location = new System.Drawing.Point(200, 182);
            this.txbIDFinanciamiento.Name = "txbIDFinanciamiento";
            this.txbIDFinanciamiento.Size = new System.Drawing.Size(139, 27);
            this.txbIDFinanciamiento.TabIndex = 103;
            // 
            // txbIDPago
            // 
            this.txbIDPago.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDPago.Location = new System.Drawing.Point(200, 139);
            this.txbIDPago.Name = "txbIDPago";
            this.txbIDPago.Size = new System.Drawing.Size(139, 27);
            this.txbIDPago.TabIndex = 104;
            this.txbIDPago.TextChanged += new System.EventHandler(this.txbIDClinte_TextChanged);
            // 
            // txbIDVenta
            // 
            this.txbIDVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDVenta.Location = new System.Drawing.Point(200, 101);
            this.txbIDVenta.Name = "txbIDVenta";
            this.txbIDVenta.Size = new System.Drawing.Size(139, 27);
            this.txbIDVenta.TabIndex = 101;
            this.txbIDVenta.TextChanged += new System.EventHandler(this.txbIDVenta_TextChanged);
            // 
            // txbIVA
            // 
            this.txbIVA.BackColor = System.Drawing.SystemColors.Info;
            this.txbIVA.Location = new System.Drawing.Point(200, 322);
            this.txbIVA.Name = "txbIVA";
            this.txbIVA.Size = new System.Drawing.Size(139, 27);
            this.txbIVA.TabIndex = 105;
            this.txbIVA.TextChanged += new System.EventHandler(this.txbTasaDeInteres_TextChanged);
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txbTotal.Location = new System.Drawing.Point(195, 369);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(139, 27);
            this.txbTotal.TabIndex = 105;
            this.txbTotal.TextChanged += new System.EventHandler(this.txbTasaDeInteres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 113;
            this.label4.Text = "Total";
            // 
            // frmActualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 535);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbIdFactura);
            this.Controls.Add(this.txbIVA);
            this.Controls.Add(this.txbsubTotal);
            this.Controls.Add(this.txbNumeroFactura);
            this.Controls.Add(this.txbIDFinanciamiento);
            this.Controls.Add(this.txbIDPago);
            this.Controls.Add(this.txbIDVenta);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmActualizarFactura";
            this.Text = "frmActualizarFactura";
            this.Load += new System.EventHandler(this.frmActualizarFactura_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDVenta, 0);
            this.Controls.SetChildIndex(this.txbIDPago, 0);
            this.Controls.SetChildIndex(this.txbIDFinanciamiento, 0);
            this.Controls.SetChildIndex(this.txbNumeroFactura, 0);
            this.Controls.SetChildIndex(this.txbsubTotal, 0);
            this.Controls.SetChildIndex(this.txbIVA, 0);
            this.Controls.SetChildIndex(this.txbIdFactura, 0);
            this.Controls.SetChildIndex(this.txbTotal, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
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
        public System.Windows.Forms.TextBox txbIdFactura;
        public System.Windows.Forms.TextBox txbsubTotal;
        public System.Windows.Forms.TextBox txbNumeroFactura;
        public System.Windows.Forms.TextBox txbIDFinanciamiento;
        public System.Windows.Forms.TextBox txbIDPago;
        public System.Windows.Forms.TextBox txbIDVenta;
        public System.Windows.Forms.TextBox txbIVA;
        public System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label4;
    }
}