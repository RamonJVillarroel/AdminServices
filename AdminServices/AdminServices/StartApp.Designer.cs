namespace AdminServices
{
    partial class presentacion
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnServicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn3meses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(73, 20);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(568, 227);
            this.dgvClients.TabIndex = 0;
            // 
            // btnServicio
            // 
            this.btnServicio.Location = new System.Drawing.Point(84, 268);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(105, 23);
            this.btnServicio.TabIndex = 1;
            this.btnServicio.Text = "Nuevo Servicio";
            this.btnServicio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar Servicio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn3meses
            // 
            this.btn3meses.Location = new System.Drawing.Point(327, 268);
            this.btn3meses.Name = "btn3meses";
            this.btn3meses.Size = new System.Drawing.Size(123, 23);
            this.btn3meses.TabIndex = 3;
            this.btn3meses.Text = "Buscar servicios";
            this.btn3meses.UseVisualStyleBackColor = true;
            // 
            // presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(712, 381);
            this.Controls.Add(this.btn3meses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.dgvClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de servicios";
            this.Load += new System.EventHandler(this.presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn3meses;
    }
}

