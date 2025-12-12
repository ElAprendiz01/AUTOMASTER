namespace AutoMaster
{
    partial class Frm_InicioSesion
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

            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(171, 307);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(395, 44);
            this.txtPass.TabIndex = 0;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(171, 164);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(395, 44);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.MintCream;
            this.btnInicioSesion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(270, 396);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(225, 75);
            this.btnInicioSesion.TabIndex = 2;
            this.btnInicioSesion.Text = "Iniciar Sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 40);
            this.label1.TabIndex = 3;

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.BtnInicioSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 0;

            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Frm_InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);

            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(170, 128);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(411, 48);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(170, 288);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(411, 48);
            this.txtContra.TabIndex = 3;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnInicioSesion
            // 
            this.BtnInicioSesion.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnInicioSesion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicioSesion.Location = new System.Drawing.Point(257, 375);
            this.BtnInicioSesion.Name = "BtnInicioSesion";
            this.BtnInicioSesion.Size = new System.Drawing.Size(222, 57);
            this.BtnInicioSesion.TabIndex = 4;
            this.BtnInicioSesion.Text = "Iniciar Sesion";
            this.BtnInicioSesion.UseVisualStyleBackColor = false;
            this.BtnInicioSesion.Click += new System.EventHandler(this.BtnInicioSesion_Click);
            // 
            // Frm_InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.BtnInicioSesion);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button BtnInicioSesion;

            this.components = new System.ComponentModel.Container();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(761, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InicioSesion";
            this.Load += new System.EventHandler(this.Frm_InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}