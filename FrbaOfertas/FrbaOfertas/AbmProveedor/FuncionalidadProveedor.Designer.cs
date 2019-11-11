namespace FrbaOfertas.AbmProveedor
{
    partial class FuncionalidadProveedor
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
            this.NuevoBtn = new System.Windows.Forms.Button();
            this.FiltrarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCIONES";
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Location = new System.Drawing.Point(88, 29);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(138, 62);
            this.NuevoBtn.TabIndex = 1;
            this.NuevoBtn.Text = "Nuevo Proveedor";
            this.NuevoBtn.UseVisualStyleBackColor = true;
            // 
            // FiltrarBtn
            // 
            this.FiltrarBtn.Location = new System.Drawing.Point(88, 118);
            this.FiltrarBtn.Name = "FiltrarBtn";
            this.FiltrarBtn.Size = new System.Drawing.Size(138, 62);
            this.FiltrarBtn.TabIndex = 2;
            this.FiltrarBtn.Text = "Filtrar Proveedor";
            this.FiltrarBtn.UseVisualStyleBackColor = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(105, 329);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(138, 62);
            this.SalirBtn.TabIndex = 3;
            this.SalirBtn.Text = "SALIR";
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuevoBtn);
            this.groupBox1.Controls.Add(this.FiltrarBtn);
            this.groupBox1.Location = new System.Drawing.Point(17, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // FuncionalidadProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.label1);
            this.Name = "FuncionalidadProveedor";
            this.Text = "Funcionalidades";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.Button FiltrarBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}