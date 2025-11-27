namespace AutoMaster.frm_Empleados
{
    partial class frmActualizarEmpelados
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_IdTipoCatalogo = new System.Windows.Forms.Label();
            this.txbIdEmpleado = new System.Windows.Forms.TextBox();
            this.TxbIDArea = new System.Windows.Forms.TextBox();
            this.txbIDCargo = new System.Windows.Forms.TextBox();
            this.txbIdPersona = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(808, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Size = new System.Drawing.Size(808, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 379);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(196, 166);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnGuardar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(48, 323);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 55);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkBoxactivoEmpleado
            // 
            this.checkBoxactivoEmpleado.AutoSize = true;
            this.checkBoxactivoEmpleado.Location = new System.Drawing.Point(231, 280);
            this.checkBoxactivoEmpleado.Name = "checkBoxactivoEmpleado";
            this.checkBoxactivoEmpleado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxactivoEmpleado.TabIndex = 74;
            this.checkBoxactivoEmpleado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "ID Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID Cargo";
            // 
            // Lbl_IdTipoCatalogo
            // 
            this.Lbl_IdTipoCatalogo.AutoSize = true;
            this.Lbl_IdTipoCatalogo.Location = new System.Drawing.Point(25, 108);
            this.Lbl_IdTipoCatalogo.Name = "Lbl_IdTipoCatalogo";
            this.Lbl_IdTipoCatalogo.Size = new System.Drawing.Size(91, 19);
            this.Lbl_IdTipoCatalogo.TabIndex = 80;
            this.Lbl_IdTipoCatalogo.Text = "ID Persona";
            // 
            // txbIdEmpleado
            // 
            this.txbIdEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdEmpleado.Location = new System.Drawing.Point(218, 323);
            this.txbIdEmpleado.Name = "txbIdEmpleado";
            this.txbIdEmpleado.Size = new System.Drawing.Size(139, 27);
            this.txbIdEmpleado.TabIndex = 71;
            this.txbIdEmpleado.Visible = false;
            // 
            // TxbIDArea
            // 
            this.TxbIDArea.BackColor = System.Drawing.SystemColors.Info;
            this.TxbIDArea.Location = new System.Drawing.Point(201, 219);
            this.TxbIDArea.Name = "TxbIDArea";
            this.TxbIDArea.Size = new System.Drawing.Size(139, 27);
            this.TxbIDArea.TabIndex = 72;
            // 
            // txbIDCargo
            // 
            this.txbIDCargo.BackColor = System.Drawing.SystemColors.Info;
            this.txbIDCargo.Location = new System.Drawing.Point(201, 158);
            this.txbIDCargo.Name = "txbIDCargo";
            this.txbIDCargo.Size = new System.Drawing.Size(139, 27);
            this.txbIDCargo.TabIndex = 69;
            // 
            // txbIdPersona
            // 
            this.txbIdPersona.BackColor = System.Drawing.SystemColors.Info;
            this.txbIdPersona.Location = new System.Drawing.Point(201, 100);
            this.txbIdPersona.Name = "txbIdPersona";
            this.txbIdPersona.Size = new System.Drawing.Size(139, 27);
            this.txbIdPersona.TabIndex = 70;
            this.txbIdPersona.TextChanged += new System.EventHandler(this.txbIdPersona_TextChanged);
            // 
            // frmActualizarEmpelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 488);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.checkBoxactivoEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_IdTipoCatalogo);
            this.Controls.Add(this.txbIdEmpleado);
            this.Controls.Add(this.TxbIDArea);
            this.Controls.Add(this.txbIDCargo);
            this.Controls.Add(this.txbIdPersona);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmActualizarEmpelados";
            this.Text = "frmActualizarEmpelados";
            this.Load += new System.EventHandler(this.frmActualizarEmpelados_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txbIdPersona, 0);
            this.Controls.SetChildIndex(this.txbIDCargo, 0);
            this.Controls.SetChildIndex(this.TxbIDArea, 0);
            this.Controls.SetChildIndex(this.txbIdEmpleado, 0);
            this.Controls.SetChildIndex(this.Lbl_IdTipoCatalogo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_IdTipoCatalogo;
        public System.Windows.Forms.TextBox txbIdEmpleado;
        public System.Windows.Forms.TextBox TxbIDArea;
        public System.Windows.Forms.TextBox txbIDCargo;
        public System.Windows.Forms.TextBox txbIdPersona;
    }
}