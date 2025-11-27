namespace AutoMaster
{
    partial class frm_insertarNuevo_Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_insertarNuevo_Estado));
            this.checkBoxactivoEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbelCodigoCatalogo = new System.Windows.Forms.Label();
            this.txbCodigoEstado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Size = new System.Drawing.Size(765, 81);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Size = new System.Drawing.Size(765, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 338);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(0, 112);
            // 
            // checkBoxactivoEstado
            // 
            this.checkBoxactivoEstado.AutoSize = true;
            this.checkBoxactivoEstado.Location = new System.Drawing.Point(140, 213);
            this.checkBoxactivoEstado.Name = "checkBoxactivoEstado";
            this.checkBoxactivoEstado.Size = new System.Drawing.Size(154, 23);
            this.checkBoxactivoEstado.TabIndex = 30;
            this.checkBoxactivoEstado.Text = "Activo o inactivo";
            this.checkBoxactivoEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Activo";
            // 
            // lbelCodigoCatalogo
            // 
            this.lbelCodigoCatalogo.AutoSize = true;
            this.lbelCodigoCatalogo.Location = new System.Drawing.Point(19, 128);
            this.lbelCodigoCatalogo.Name = "lbelCodigoCatalogo";
            this.lbelCodigoCatalogo.Size = new System.Drawing.Size(60, 19);
            this.lbelCodigoCatalogo.TabIndex = 32;
            this.lbelCodigoCatalogo.Text = "Estado";
            // 
            // txbCodigoEstado
            // 
            this.txbCodigoEstado.BackColor = System.Drawing.SystemColors.Info;
            this.txbCodigoEstado.Location = new System.Drawing.Point(140, 120);
            this.txbCodigoEstado.Name = "txbCodigoEstado";
            this.txbCodigoEstado.Size = new System.Drawing.Size(139, 27);
            this.txbCodigoEstado.TabIndex = 28;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(86, 282);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 290);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(237, 27);
            this.label4.MaximumSize = new System.Drawing.Size(500, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 31);
            this.label4.TabIndex = 50;
            this.label4.Text = "Registro  Estados";
            // 
            // frm_insertarNuevo_Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 438);
            this.Controls.Add(this.checkBoxactivoEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbelCodigoCatalogo);
            this.Controls.Add(this.txbCodigoEstado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.MinimizeBox = false;
            this.Name = "frm_insertarNuevo_Estado";
            this.Text = "frmNuevoEstado";
            this.Load += new System.EventHandler(this.frmNuevoEstado_Load);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.txbCodigoEstado, 0);
            this.Controls.SetChildIndex(this.lbelCodigoCatalogo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkBoxactivoEstado, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBoxactivoEstado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbelCodigoCatalogo;
        public System.Windows.Forms.TextBox txbCodigoEstado;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}