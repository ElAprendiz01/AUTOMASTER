namespace AutoMaster.frmPagos
{
    partial class frmPrinPagos
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
            this.dataGridViewListarpagos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarpagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(877, 81);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Size = new System.Drawing.Size(877, 46);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(766, 443);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(329, 166);
            // 
            // btnElimianar
            // 
            this.btnElimianar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimianar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimianar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimianar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimianar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimianar.Location = new System.Drawing.Point(269, 418);
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
            this.btnEditar.Location = new System.Drawing.Point(146, 418);
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
            this.btNuevo.Location = new System.Drawing.Point(22, 418);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(96, 55);
            this.btNuevo.TabIndex = 16;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // dataGridViewListarpagos
            // 
            this.dataGridViewListarpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarpagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewListarpagos.Location = new System.Drawing.Point(21, 109);
            this.dataGridViewListarpagos.Name = "dataGridViewListarpagos";
            this.dataGridViewListarpagos.Size = new System.Drawing.Size(830, 288);
            this.dataGridViewListarpagos.TabIndex = 13;
            // 
            // frmPrinPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 552);
            this.Controls.Add(this.btnElimianar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dataGridViewListarpagos);
            this.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.Name = "frmPrinPagos";
            this.Text = "frmPrinPagos";
            this.Load += new System.EventHandler(this.frmPrinPagos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridViewListarpagos, 0);
            this.Controls.SetChildIndex(this.btNuevo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnElimianar, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarpagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnElimianar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btNuevo;
        public System.Windows.Forms.DataGridView dataGridViewListarpagos;
    }
}