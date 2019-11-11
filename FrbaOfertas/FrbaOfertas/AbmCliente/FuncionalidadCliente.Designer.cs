namespace FrbaOfertas.AbmCliente
{
    partial class FuncionalidadCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCIONES";
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Location = new System.Drawing.Point(82, 30);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(140, 44);
            this.NuevoBtn.TabIndex = 1;
            this.NuevoBtn.Text = "Nuevo Cliente";
            this.NuevoBtn.UseVisualStyleBackColor = true;
            // 
            // FiltrarBtn
            // 
            this.FiltrarBtn.Location = new System.Drawing.Point(82, 100);
            this.FiltrarBtn.Name = "FiltrarBtn";
            this.FiltrarBtn.Size = new System.Drawing.Size(140, 44);
            this.FiltrarBtn.TabIndex = 2;
            this.FiltrarBtn.Text = "Filtrar Cliente";
            this.FiltrarBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuevoBtn);
            this.groupBox1.Controls.Add(this.FiltrarBtn);
            this.groupBox1.Location = new System.Drawing.Point(24, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // FuncionalidadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FuncionalidadCliente";
            this.Text = "Funcionalidades";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.Button FiltrarBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}