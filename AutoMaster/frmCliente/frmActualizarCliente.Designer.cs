namespace AutoMaster.frmCliente
{
    partial class frmActualizarCliente
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
            this.checkBoxactivoEmpleado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdPersona = new System.Windows.Forms.TextBox();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(865, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Size = new System.Drawing.Size(865, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 430);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(317, 166);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(33, 417);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Actualizar ";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkBoxactivoEmpleado
            // 
            this.checkBoxactivoEmpleado.AutoSize = true;
            this.checkBoxactivoEmpleado.Location = new System.Drawing.Point(265, 206);
            this.checkBoxactivoEmpleado.Name = "checkBoxactivoEmpleado";
            this.checkBoxactivoEmpleado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxactivoEmpleado.TabIndex = 61;
            this.checkBoxactivoEmpleado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Activo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "ID Persona";
            // 
            // txbIdPersona
            // 
            this.txbIdPersona.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdPersona.Location = new System.Drawing.Point(191, 121);
            this.txbIdPersona.Name = "txbIdPersona";
            this.txbIdPersona.Size = new System.Drawing.Size(139, 27);
            this.txbIdPersona.TabIndex = 58;
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDEmpleado.Location = new System.Drawing.Point(191, 271);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.Size = new System.Drawing.Size(139, 27);
            this.txbIDEmpleado.TabIndex = 58;
            this.txbIDEmpleado.Visible = false;
            // 
            // frmActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 539);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.checkBoxactivoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.txbIdPersona);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmActualizarCliente";
            this.Text = "frmActualizarCliente";
            this.Load += new System.EventHandler(this.frmActualizarCliente_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIdPersona, 0);
            this.Controls.SetChildIndex(this.txbIDEmpleado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkBoxactivoEmpleado, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.CheckBox checkBoxactivoEmpleado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIdPersona;
        public System.Windows.Forms.TextBox txbIDEmpleado;
    }
}