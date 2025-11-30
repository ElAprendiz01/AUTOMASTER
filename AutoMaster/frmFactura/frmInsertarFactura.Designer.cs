namespace AutoMaster.frmFactura
{
    partial class frmInsertarFactura
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbIVA = new System.Windows.Forms.TextBox();
            this.txbsubTotal = new System.Windows.Forms.TextBox();
            this.txbNumeroFactura = new System.Windows.Forms.TextBox();
            this.txbIDFinanciamiento = new System.Windows.Forms.TextBox();
            this.txbIDPago = new System.Windows.Forms.TextBox();
            this.txbIDVenta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(859, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Size = new System.Drawing.Size(859, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 422);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(311, 166);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(40, 412);
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
            this.label7.Location = new System.Drawing.Point(36, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 123;
            this.label7.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 38);
            this.label5.TabIndex = 124;
            this.label5.Text = "Número de \r\nfactura\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 125;
            this.label3.Text = "ID Financiamiento";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(36, 132);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(69, 19);
            this.lbelCodigoCatalogo.TabIndex = 126;
            this.lbelCodigoCatalogo.Text = "ID Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 127;
            this.label4.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 128;
            this.label1.Text = "IVA";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(36, 94);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 129;
            this.Lbl_IdTipoCatalogo.Text = "ID Venta";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txbTotal.Location = new System.Drawing.Point(207, 354);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(139, 27);
            this.txbTotal.TabIndex = 118;
            // 
            // txbIVA
            // 
            this.txbIVA.BackColor = System.Drawing.SystemColors.Info;
            this.txbIVA.Location = new System.Drawing.Point(212, 307);
            this.txbIVA.Name = "txbIVA";
            this.txbIVA.Size = new System.Drawing.Size(139, 27);
            this.txbIVA.TabIndex = 119;
            // 
            // txbsubTotal
            // 
            this.txbsubTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txbsubTotal.Location = new System.Drawing.Point(212, 263);
            this.txbsubTotal.Name = "txbsubTotal";
            this.txbsubTotal.Size = new System.Drawing.Size(139, 27);
            this.txbsubTotal.TabIndex = 120;
            // 
            // txbNumeroFactura
            // 
            this.txbNumeroFactura.BackColor = System.Drawing.SystemColors.Info;
            this.txbNumeroFactura.Location = new System.Drawing.Point(212, 214);
            this.txbNumeroFactura.Name = "txbNumeroFactura";
            this.txbNumeroFactura.Size = new System.Drawing.Size(139, 27);
            this.txbNumeroFactura.TabIndex = 121;
            // 
            // txbIDFinanciamiento
            // 
            this.txbIDFinanciamiento.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDFinanciamiento.Location = new System.Drawing.Point(212, 167);
            this.txbIDFinanciamiento.Name = "txbIDFinanciamiento";
            this.txbIDFinanciamiento.Size = new System.Drawing.Size(139, 27);
            this.txbIDFinanciamiento.TabIndex = 116;
            // 
            // txbIDPago
            // 
            this.txbIDPago.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDPago.Location = new System.Drawing.Point(212, 124);
            this.txbIDPago.Name = "txbIDPago";
            this.txbIDPago.Size = new System.Drawing.Size(139, 27);
            this.txbIDPago.TabIndex = 117;
            // 
            // txbIDVenta
            // 
            this.txbIDVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDVenta.Location = new System.Drawing.Point(212, 86);
            this.txbIDVenta.Name = "txbIDVenta";
            this.txbIDVenta.Size = new System.Drawing.Size(139, 27);
            this.txbIDVenta.TabIndex = 115;
            // 
            // frmInsertarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 531);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbIVA);
            this.Controls.Add(this.txbsubTotal);
            this.Controls.Add(this.txbNumeroFactura);
            this.Controls.Add(this.txbIDFinanciamiento);
            this.Controls.Add(this.txbIDPago);
            this.Controls.Add(this.txbIDVenta);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmInsertarFactura";
            this.Text = "frmInsertarFactura";
            this.Load += new System.EventHandler(this.frmInsertarFactura_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDVenta, 0);
            this.Controls.SetChildIndex(this.txbIDPago, 0);
            this.Controls.SetChildIndex(this.txbIDFinanciamiento, 0);
            this.Controls.SetChildIndex(this.txbNumeroFactura, 0);
            this.Controls.SetChildIndex(this.txbsubTotal, 0);
            this.Controls.SetChildIndex(this.txbIVA, 0);
            this.Controls.SetChildIndex(this.txbTotal, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbTotal;
        public System.Windows.Forms.TextBox txbIVA;
        public System.Windows.Forms.TextBox txbsubTotal;
        public System.Windows.Forms.TextBox txbNumeroFactura;
        public System.Windows.Forms.TextBox txbIDFinanciamiento;
        public System.Windows.Forms.TextBox txbIDPago;
        public System.Windows.Forms.TextBox txbIDVenta;
    }
}