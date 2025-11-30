namespace AutoMaster.frm_Financiamiento
{
    partial class FrmInsertarfinanciamiento
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
            this.dateTimePickerFechadeCanselacion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickcFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbTasaDeInteres = new System.Windows.Forms.TextBox();
            this.txbplazoEnElMes = new System.Windows.Forms.TextBox();
            this.TXBMonto = new System.Windows.Forms.TextBox();
            this.txbIDClinte = new System.Windows.Forms.TextBox();
            this.txbIDVenta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(868, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Size = new System.Drawing.Size(868, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 430);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(320, 166);
            // 
            // dateTimePickerFechadeCanselacion
            // 
            this.dateTimePickerFechadeCanselacion.Location = new System.Drawing.Point(463, 168);
            this.dateTimePickerFechadeCanselacion.Name = "dateTimePickerFechadeCanselacion";
            this.dateTimePickerFechadeCanselacion.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerFechadeCanselacion.TabIndex = 114;
            // 
            // dateTimePickcFechaInicio
            // 
            this.dateTimePickcFechaInicio.Location = new System.Drawing.Point(463, 104);
            this.dateTimePickcFechaInicio.Name = "dateTimePickcFechaInicio";
            this.dateTimePickcFechaInicio.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickcFechaInicio.TabIndex = 115;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInsertar.Location = new System.Drawing.Point(649, 430);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(96, 55);
            this.btnInsertar.TabIndex = 106;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 38);
            this.label2.TabIndex = 107;
            this.label2.Text = "Fecha de \r\ncancelación \r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 108;
            this.label7.Text = "Tasa de Interés ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 38);
            this.label5.TabIndex = 109;
            this.label5.Text = "Plazo en \r\nmeses ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 110;
            this.label3.Text = "Monto";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(33, 157);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(82, 19);
            this.lbelCodigoCatalogo.TabIndex = 111;
            this.lbelCodigoCatalogo.Text = "ID Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 38);
            this.label1.TabIndex = 112;
            this.label1.Text = "Fecha de \r\ninicio\r\n";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(33, 104);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(75, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 113;
            this.Lbl_IdTipoCatalogo.Text = "ID Venta";
            // 
            // txbTasaDeInteres
            // 
            this.txbTasaDeInteres.BackColor = System.Drawing.SystemColors.Info;
            this.txbTasaDeInteres.Location = new System.Drawing.Point(209, 298);
            this.txbTasaDeInteres.Name = "txbTasaDeInteres";
            this.txbTasaDeInteres.Size = new System.Drawing.Size(139, 27);
            this.txbTasaDeInteres.TabIndex = 104;
            // 
            // txbplazoEnElMes
            // 
            this.txbplazoEnElMes.BackColor = System.Drawing.SystemColors.Info;
            this.txbplazoEnElMes.Location = new System.Drawing.Point(209, 242);
            this.txbplazoEnElMes.Name = "txbplazoEnElMes";
            this.txbplazoEnElMes.Size = new System.Drawing.Size(139, 27);
            this.txbplazoEnElMes.TabIndex = 105;
            // 
            // TXBMonto
            // 
            this.TXBMonto.BackColor = System.Drawing.SystemColors.Info;
            this.TXBMonto.Location = new System.Drawing.Point(209, 195);
            this.TXBMonto.Name = "TXBMonto";
            this.TXBMonto.Size = new System.Drawing.Size(139, 27);
            this.TXBMonto.TabIndex = 102;
            // 
            // txbIDClinte
            // 
            this.txbIDClinte.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDClinte.Location = new System.Drawing.Point(209, 149);
            this.txbIDClinte.Name = "txbIDClinte";
            this.txbIDClinte.Size = new System.Drawing.Size(139, 27);
            this.txbIDClinte.TabIndex = 103;
            // 
            // txbIDVenta
            // 
            this.txbIDVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDVenta.Location = new System.Drawing.Point(209, 96);
            this.txbIDVenta.Name = "txbIDVenta";
            this.txbIDVenta.Size = new System.Drawing.Size(139, 27);
            this.txbIDVenta.TabIndex = 101;
            // 
            // FrmInsertarfinanciamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 539);
            this.Controls.Add(this.dateTimePickerFechadeCanselacion);
            this.Controls.Add(this.dateTimePickcFechaInicio);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbTasaDeInteres);
            this.Controls.Add(this.txbplazoEnElMes);
            this.Controls.Add(this.TXBMonto);
            this.Controls.Add(this.txbIDClinte);
            this.Controls.Add(this.txbIDVenta);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "FrmInsertarfinanciamiento";
            this.Text = "FrmInsertarfinanciamiento";
            this.Load += new System.EventHandler(this.FrmInsertarfinanciamiento_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIDVenta, 0);
            this.Controls.SetChildIndex(this.txbIDClinte, 0);
            this.Controls.SetChildIndex(this.TXBMonto, 0);
            this.Controls.SetChildIndex(this.txbplazoEnElMes, 0);
            this.Controls.SetChildIndex(this.txbTasaDeInteres, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnInsertar, 0);
            this.Controls.SetChildIndex(this.dateTimePickcFechaInicio, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFechadeCanselacion, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePickerFechadeCanselacion;
        public System.Windows.Forms.DateTimePicker dateTimePickcFechaInicio;
        public System.Windows.Forms.Button btnInsertar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbTasaDeInteres;
        public System.Windows.Forms.TextBox txbplazoEnElMes;
        public System.Windows.Forms.TextBox TXBMonto;
        public System.Windows.Forms.TextBox txbIDClinte;
        public System.Windows.Forms.TextBox txbIDVenta;
    }
}