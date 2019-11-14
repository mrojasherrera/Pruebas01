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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClienteBtn = new System.Windows.Forms.Button();
            this.EstadisticoBtn = new System.Windows.Forms.Button();
            this.ProveedorBtn = new System.Windows.Forms.Button();
            this.FacturarBtn = new System.Windows.Forms.Button();
            this.RolBtn = new System.Windows.Forms.Button();
            this.CreditoBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClienteBtn);
            this.groupBox1.Controls.Add(this.EstadisticoBtn);
            this.groupBox1.Controls.Add(this.ProveedorBtn);
            this.groupBox1.Controls.Add(this.FacturarBtn);
            this.groupBox1.Controls.Add(this.RolBtn);
            this.groupBox1.Controls.Add(this.CreditoBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 305);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // ClienteBtn
            // 
            this.ClienteBtn.Location = new System.Drawing.Point(80, 30);
            this.ClienteBtn.Name = "ClienteBtn";
            this.ClienteBtn.Size = new System.Drawing.Size(135, 56);
            this.ClienteBtn.TabIndex = 1;
            this.ClienteBtn.Text = "ABM Cliente";
            this.ClienteBtn.UseVisualStyleBackColor = true;
            this.ClienteBtn.Click += new System.EventHandler(this.ClienteBtn_Click);
            // 
            // EstadisticoBtn
            // 
            this.EstadisticoBtn.Location = new System.Drawing.Point(302, 220);
            this.EstadisticoBtn.Name = "EstadisticoBtn";
            this.EstadisticoBtn.Size = new System.Drawing.Size(135, 56);
            this.EstadisticoBtn.TabIndex = 6;
            this.EstadisticoBtn.Text = "Listado Estadístico";
            this.EstadisticoBtn.UseVisualStyleBackColor = true;
            // 
            // ProveedorBtn
            // 
            this.ProveedorBtn.Location = new System.Drawing.Point(302, 30);
            this.ProveedorBtn.Name = "ProveedorBtn";
            this.ProveedorBtn.Size = new System.Drawing.Size(135, 56);
            this.ProveedorBtn.TabIndex = 2;
            this.ProveedorBtn.Text = "ABM Proveedor";
            this.ProveedorBtn.UseVisualStyleBackColor = true;
            this.ProveedorBtn.Click += new System.EventHandler(this.ProveedorBtn_Click);
            // 
            // FacturarBtn
            // 
            this.FacturarBtn.Location = new System.Drawing.Point(80, 220);
            this.FacturarBtn.Name = "FacturarBtn";
            this.FacturarBtn.Size = new System.Drawing.Size(135, 56);
            this.FacturarBtn.TabIndex = 5;
            this.FacturarBtn.Text = "Facturar Proveedor";
            this.FacturarBtn.UseVisualStyleBackColor = true;
            // 
            // RolBtn
            // 
            this.RolBtn.Location = new System.Drawing.Point(80, 121);
            this.RolBtn.Name = "RolBtn";
            this.RolBtn.Size = new System.Drawing.Size(135, 56);
            this.RolBtn.TabIndex = 3;
            this.RolBtn.Text = "ABM Rol";
            this.RolBtn.UseVisualStyleBackColor = true;
            // 
            // CreditoBtn
            // 
            this.CreditoBtn.Location = new System.Drawing.Point(302, 121);
            this.CreditoBtn.Name = "CreditoBtn";
            this.CreditoBtn.Size = new System.Drawing.Size(135, 56);
            this.CreditoBtn.TabIndex = 4;
            this.CreditoBtn.Text = "Cargar Crédito";
            this.CreditoBtn.UseVisualStyleBackColor = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(206, 347);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(128, 56);
            this.SalirBtn.TabIndex = 10;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // ListadoAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 434);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoAcciones";
            this.Text = "ListadoAcciones";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClienteBtn;
        private System.Windows.Forms.Button EstadisticoBtn;
        private System.Windows.Forms.Button ProveedorBtn;
        private System.Windows.Forms.Button FacturarBtn;
        private System.Windows.Forms.Button RolBtn;
        private System.Windows.Forms.Button CreditoBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}