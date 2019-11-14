namespace FrbaOfertas.AbmProveedor
{
    partial class AccionesProveedor
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
            this.NuevoBtn = new System.Windows.Forms.Button();
            this.FiltrarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuevoBtn);
            this.groupBox1.Controls.Add(this.FiltrarBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Location = new System.Drawing.Point(88, 31);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(138, 50);
            this.NuevoBtn.TabIndex = 1;
            this.NuevoBtn.Text = "Nuevo Proveedor";
            this.NuevoBtn.UseVisualStyleBackColor = true;
            // 
            // FiltrarBtn
            // 
            this.FiltrarBtn.Location = new System.Drawing.Point(88, 122);
            this.FiltrarBtn.Name = "FiltrarBtn";
            this.FiltrarBtn.Size = new System.Drawing.Size(138, 50);
            this.FiltrarBtn.TabIndex = 2;
            this.FiltrarBtn.Text = "Filtrar Proveedor";
            this.FiltrarBtn.UseVisualStyleBackColor = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(100, 269);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(138, 53);
            this.SalirBtn.TabIndex = 6;
            this.SalirBtn.Text = "SALIR";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // AccionesProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 352);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccionesProveedor";
            this.Text = "Acciones";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.Button FiltrarBtn;
        private System.Windows.Forms.Button SalirBtn;

    }
}