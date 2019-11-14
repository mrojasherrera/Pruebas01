namespace FrbaOfertas.PantallaUsuarios
{
    partial class PantallaAdmin
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
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FuncionalidadesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AdmTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(118, 213);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(160, 49);
            this.SalirBtn.TabIndex = 15;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FuncionalidadesBtn);
            this.groupBox1.Location = new System.Drawing.Point(440, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // FuncionalidadesBtn
            // 
            this.FuncionalidadesBtn.Location = new System.Drawing.Point(52, 42);
            this.FuncionalidadesBtn.Name = "FuncionalidadesBtn";
            this.FuncionalidadesBtn.Size = new System.Drawing.Size(164, 38);
            this.FuncionalidadesBtn.TabIndex = 0;
            this.FuncionalidadesBtn.Text = "Funcionalidades";
            this.FuncionalidadesBtn.UseVisualStyleBackColor = true;
            this.FuncionalidadesBtn.Click += new System.EventHandler(this.FuncionalidadesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AdmTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 177);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrador General";
            // 
            // AdmTB
            // 
            this.AdmTB.Enabled = false;
            this.AdmTB.Location = new System.Drawing.Point(186, 88);
            this.AdmTB.Name = "AdmTB";
            this.AdmTB.Size = new System.Drawing.Size(180, 20);
            this.AdmTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADOR:";
            // 
            // PantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 283);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PantallaAdmin";
            this.Text = "PantallaAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FuncionalidadesBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AdmTB;
        private System.Windows.Forms.Label label1;
    }
}