namespace AutoMaster.FrmVentas
{
    partial class frmPrinVentas
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
            this.btnElimianar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.dataGridViewListarVVentas = new System.Windows.Forms.DataGridView();
            this.btnfinanciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarVVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(886, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Size = new System.Drawing.Size(886, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 434);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(380, 166);
            // 
            // btnElimianar
            // 
            this.btnElimianar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimianar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimianar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimianar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimianar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimianar.Location = new System.Drawing.Point(270, 413);
            this.btnElimianar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnElimianar.Name = "btnElimianar";
            this.btnElimianar.Size = new System.Drawing.Size(96, 55);
            this.btnElimianar.TabIndex = 14;
            this.btnElimianar.Text = "Eliminar";
            this.btnElimianar.UseVisualStyleBackColor = false;
            this.btnElimianar.Click += new System.EventHandler(this.btnElimianar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.Location = new System.Drawing.Point(147, 413);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 55);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNuevo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btNuevo.Location = new System.Drawing.Point(23, 413);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(96, 55);
            this.btNuevo.TabIndex = 16;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // dataGridViewListarVVentas
            // 
            this.dataGridViewListarVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarVVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewListarVVentas.Location = new System.Drawing.Point(22, 104);
            this.dataGridViewListarVVentas.Name = "dataGridViewListarVVentas";
            this.dataGridViewListarVVentas.Size = new System.Drawing.Size(830, 288);
            this.dataGridViewListarVVentas.TabIndex = 13;
            // 
            // btnfinanciar
            // 
            this.btnfinanciar.Location = new System.Drawing.Point(401, 413);
            this.btnfinanciar.Name = "btnfinanciar";
            this.btnfinanciar.Size = new System.Drawing.Size(88, 55);
            this.btnfinanciar.TabIndex = 17;
            this.btnfinanciar.Text = "financiar ";
            this.btnfinanciar.UseVisualStyleBackColor = true;
            this.btnfinanciar.Click += new System.EventHandler(this.btnfinanciar_Click);
            // 
            // frmPrinVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 543);
            this.Controls.Add(this.btnfinanciar);
            this.Controls.Add(this.btnElimianar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dataGridViewListarVVentas);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmPrinVentas";
            this.Text = "frmPrinVentas";
            this.Load += new System.EventHandler(this.frmPrinVentas_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridViewListarVVentas, 0);
            this.Controls.SetChildIndex(this.btNuevo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnElimianar, 0);
            this.Controls.SetChildIndex(this.btnfinanciar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarVVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnElimianar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btNuevo;
        public System.Windows.Forms.DataGridView dataGridViewListarVVentas;
        private System.Windows.Forms.Button btnfinanciar;
    }
}