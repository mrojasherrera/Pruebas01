﻿namespace FrbaOfertas.PantallaUsuarios
{
    partial class PantallaProveedor
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
            this.PublicarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublicarBtn
            // 
            this.PublicarBtn.Location = new System.Drawing.Point(372, 125);
            this.PublicarBtn.Name = "PublicarBtn";
            this.PublicarBtn.Size = new System.Drawing.Size(136, 53);
            this.PublicarBtn.TabIndex = 0;
            this.PublicarBtn.Text = "Publicar Oferta";
            this.PublicarBtn.UseVisualStyleBackColor = true;
            this.PublicarBtn.Click += new System.EventHandler(this.PublicarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(45, 284);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(151, 51);
            this.SalirBtn.TabIndex = 1;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // PantallaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 378);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.PublicarBtn);
            this.Name = "PantallaProveedor";
            this.Text = "PantallaProveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PublicarBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}