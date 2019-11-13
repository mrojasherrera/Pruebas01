namespace FrbaOfertas.PantallaUsuarios
{
    partial class PantallaCliente
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
            this.ComprarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACCIONES:";
            // 
            // ComprarBtn
            // 
            this.ComprarBtn.Location = new System.Drawing.Point(426, 93);
            this.ComprarBtn.Name = "ComprarBtn";
            this.ComprarBtn.Size = new System.Drawing.Size(115, 44);
            this.ComprarBtn.TabIndex = 2;
            this.ComprarBtn.Text = "Comprar Oferta";
            this.ComprarBtn.UseVisualStyleBackColor = true;
            this.ComprarBtn.Click += new System.EventHandler(this.ComprarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "USUARIO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTB);
            this.groupBox1.Controls.Add(this.NombreTB);
            this.groupBox1.Controls.Add(this.UsuarioTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "APELLIDO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE:";
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Enabled = false;
            this.UsuarioTB.Location = new System.Drawing.Point(139, 29);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(151, 20);
            this.UsuarioTB.TabIndex = 6;
            // 
            // NombreTB
            // 
            this.NombreTB.Enabled = false;
            this.NombreTB.Location = new System.Drawing.Point(139, 67);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(151, 20);
            this.NombreTB.TabIndex = 7;
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Enabled = false;
            this.ApellidoTB.Location = new System.Drawing.Point(139, 103);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(151, 20);
            this.ApellidoTB.TabIndex = 8;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(160, 263);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(112, 49);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // PantallaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 351);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComprarBtn);
            this.Controls.Add(this.label1);
            this.Name = "PantallaCliente";
            this.Text = "PantallaCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComprarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.Button SalirBtn;
    }
}