namespace AutoMaster
{
    partial class Frm_Prin_DatosPersonales
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
            this.dataGridViewListarDatopersonales = new System.Windows.Forms.DataGridView();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarDatopersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panel1.Size = new System.Drawing.Size(1306, 132);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 736);
            this.panel2.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panel2.Size = new System.Drawing.Size(1306, 75);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1162, 649);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Size = new System.Drawing.Size(885, 308);
            // 
            // btnElimianar
            // 
            this.btnElimianar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimianar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElimianar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnElimianar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimianar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnElimianar.Location = new System.Drawing.Point(447, 620);
            this.btnElimianar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnElimianar.Name = "btnElimianar";
            this.btnElimianar.Size = new System.Drawing.Size(152, 103);
            this.btnElimianar.TabIndex = 10;
            this.btnElimianar.Text = "Eliminar";
            this.btnElimianar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnEditar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.Location = new System.Drawing.Point(224, 620);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 103);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNuevo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btNuevo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btNuevo.Location = new System.Drawing.Point(27, 620);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(152, 103);
            this.btNuevo.TabIndex = 12;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // dataGridViewListarDatopersonales
            // 
            this.dataGridViewListarDatopersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarDatopersonales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewListarDatopersonales.Location = new System.Drawing.Point(27, 179);
            this.dataGridViewListarDatopersonales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewListarDatopersonales.Name = "dataGridViewListarDatopersonales";
            this.dataGridViewListarDatopersonales.RowHeadersWidth = 62;
            this.dataGridViewListarDatopersonales.Size = new System.Drawing.Size(1252, 336);
            this.dataGridViewListarDatopersonales.TabIndex = 9;
            this.dataGridViewListarDatopersonales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListarDatopersonales_CellContentClick);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(646, 631);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(173, 84);
            this.btnCrearUsuario.TabIndex = 13;
            this.btnCrearUsuario.Text = "Crear Usuarios";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // Frm_Prin_DatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 811);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnElimianar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dataGridViewListarDatopersonales);
            this.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.Name = "Frm_Prin_DatosPersonales";
            this.Text = "Rfm_Prin_DatosPersonales";
            this.Load += new System.EventHandler(this.Rfm_Prin_DatosPersonales_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridViewListarDatopersonales, 0);
            this.Controls.SetChildIndex(this.btNuevo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnElimianar, 0);
            this.Controls.SetChildIndex(this.btnCrearUsuario, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarDatopersonales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnElimianar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btNuevo;
        public System.Windows.Forms.DataGridView dataGridViewListarDatopersonales;
        private System.Windows.Forms.Button btnCrearUsuario;
    }
}