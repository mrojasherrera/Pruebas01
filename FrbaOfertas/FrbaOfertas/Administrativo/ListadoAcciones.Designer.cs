namespace FrbaOfertas.Administrativo
{
    partial class ListadoAcciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteBtn = new System.Windows.Forms.Button();
            this.ProveedorBtn = new System.Windows.Forms.Button();
            this.RolBtn = new System.Windows.Forms.Button();
            this.CreditoBtn = new System.Windows.Forms.Button();
            this.FacturarBtn = new System.Windows.Forms.Button();
            this.EstadisticoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCIONES";
            // 
            // ClienteBtn
            // 
            this.ClienteBtn.Location = new System.Drawing.Point(153, 83);
            this.ClienteBtn.Name = "ClienteBtn";
            this.ClienteBtn.Size = new System.Drawing.Size(135, 56);
            this.ClienteBtn.TabIndex = 1;
            this.ClienteBtn.Text = "ABM Cliente";
            this.ClienteBtn.UseVisualStyleBackColor = true;
            // 
            // ProveedorBtn
            // 
            this.ProveedorBtn.Location = new System.Drawing.Point(153, 145);
            this.ProveedorBtn.Name = "ProveedorBtn";
            this.ProveedorBtn.Size = new System.Drawing.Size(135, 56);
            this.ProveedorBtn.TabIndex = 2;
            this.ProveedorBtn.Text = "ABM Proveedor";
            this.ProveedorBtn.UseVisualStyleBackColor = true;
            // 
            // RolBtn
            // 
            this.RolBtn.Location = new System.Drawing.Point(153, 207);
            this.RolBtn.Name = "RolBtn";
            this.RolBtn.Size = new System.Drawing.Size(135, 56);
            this.RolBtn.TabIndex = 3;
            this.RolBtn.Text = "ABM Rol";
            this.RolBtn.UseVisualStyleBackColor = true;
            // 
            // CreditoBtn
            // 
            this.CreditoBtn.Location = new System.Drawing.Point(153, 269);
            this.CreditoBtn.Name = "CreditoBtn";
            this.CreditoBtn.Size = new System.Drawing.Size(135, 56);
            this.CreditoBtn.TabIndex = 4;
            this.CreditoBtn.Text = "Cargar Crédito";
            this.CreditoBtn.UseVisualStyleBackColor = true;
            // 
            // FacturarBtn
            // 
            this.FacturarBtn.Location = new System.Drawing.Point(153, 331);
            this.FacturarBtn.Name = "FacturarBtn";
            this.FacturarBtn.Size = new System.Drawing.Size(135, 56);
            this.FacturarBtn.TabIndex = 5;
            this.FacturarBtn.Text = "Facturar Proveedor";
            this.FacturarBtn.UseVisualStyleBackColor = true;
            // 
            // EstadisticoBtn
            // 
            this.EstadisticoBtn.Location = new System.Drawing.Point(153, 393);
            this.EstadisticoBtn.Name = "EstadisticoBtn";
            this.EstadisticoBtn.Size = new System.Drawing.Size(135, 56);
            this.EstadisticoBtn.TabIndex = 6;
            this.EstadisticoBtn.Text = "Listado Estadístico";
            this.EstadisticoBtn.UseVisualStyleBackColor = true;
            // 
            // ListadoAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 522);
            this.Controls.Add(this.EstadisticoBtn);
            this.Controls.Add(this.FacturarBtn);
            this.Controls.Add(this.CreditoBtn);
            this.Controls.Add(this.RolBtn);
            this.Controls.Add(this.ProveedorBtn);
            this.Controls.Add(this.ClienteBtn);
            this.Controls.Add(this.label1);
            this.Name = "ListadoAcciones";
            this.Text = "ListadoAcciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClienteBtn;
        private System.Windows.Forms.Button ProveedorBtn;
        private System.Windows.Forms.Button RolBtn;
        private System.Windows.Forms.Button CreditoBtn;
        private System.Windows.Forms.Button FacturarBtn;
        private System.Windows.Forms.Button EstadisticoBtn;
    }
}