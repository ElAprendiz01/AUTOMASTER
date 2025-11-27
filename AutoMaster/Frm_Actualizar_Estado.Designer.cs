namespace AutoMaster
{
    partial class Frm_Actualizar_Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Actualizar_Estado));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.TxbIdEstado = new System.Windows.Forms.TextBox();
            this.checkBoxactivoEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.txbCodigoEstado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Size = new System.Drawing.Size(713, 81);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Size = new System.Drawing.Size(713, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 271);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(0, 112);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnActualizar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.Location = new System.Drawing.Point(83, 260);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 55);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // TxbIdEstado
            // 
            this.TxbIdEstado.BackColor = System.Drawing.SystemColors.Info;
            this.TxbIdEstado.Location = new System.Drawing.Point(75, 226);
            this.TxbIdEstado.Name = "TxbIdEstado";
            this.TxbIdEstado.Size = new System.Drawing.Size(104, 27);
            this.TxbIdEstado.TabIndex = 27;
            this.TxbIdEstado.Visible = false;
            // 
            // checkBoxactivoEstado
            // 
            this.checkBoxactivoEstado.AutoSize = true;
            this.checkBoxactivoEstado.Location = new System.Drawing.Point(137, 193);
            this.checkBoxactivoEstado.Name = "checkBoxactivoEstado";
            this.checkBoxactivoEstado.Size = new System.Drawing.Size(145, 23);
            this.checkBoxactivoEstado.TabIndex = 22;
            this.checkBoxactivoEstado.Text = "Activo o inctivo";
            this.checkBoxactivoEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Activo";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(23, 121);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(67, 19);
            this.lbelCodigoCatalogo.TabIndex = 25;
            this.lbelCodigoCatalogo.Text = "Código ";
            // 
            // txbCodigoEstado
            // 
            this.txbCodigoEstado.BackColor = System.Drawing.SystemColors.Info;
            this.txbCodigoEstado.Location = new System.Drawing.Point(143, 113);
            this.txbCodigoEstado.Name = "txbCodigoEstado";
            this.txbCodigoEstado.Size = new System.Drawing.Size(139, 27);
            this.txbCodigoEstado.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(268, 243);
            this.label2.MaximumSize = new System.Drawing.Size(320, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 72);
            this.label2.TabIndex = 37;
            this.label2.Text = "  Chevrolet Camaro Deportivo americano de dos puertas estilo agresivo y alto rend" +
    "imiento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(178, 20);
            this.label4.MaximumSize = new System.Drawing.Size(380, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Registro de Estados ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_Actualizar_Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbIdEstado);
            this.Controls.Add(this.checkBoxactivoEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.txbCodigoEstado);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "Frm_Actualizar_Estado";
            this.Text = "ActualizarEstado";
            this.Load += new System.EventHandler(this.ActualizarEstado_Load);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.txbCodigoEstado, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkBoxactivoEstado, 0);
            this.Controls.SetChildIndex(this.TxbIdEstado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox TxbIdEstado;
        public System.Windows.Forms.CheckBox checkBoxactivoEstado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        public System.Windows.Forms.TextBox txbCodigoEstado;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}