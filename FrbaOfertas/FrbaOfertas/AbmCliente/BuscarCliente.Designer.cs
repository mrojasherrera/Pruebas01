namespace FrbaOfertas.AbmCliente
{
    partial class BuscarCliente
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
            this.ClienteDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BusquedaTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NuevoTB = new System.Windows.Forms.Button();
            this.EliminarTB = new System.Windows.Forms.Button();
            this.VolverTB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteDGV
            // 
            this.ClienteDGV.AllowUserToAddRows = false;
            this.ClienteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteDGV.Location = new System.Drawing.Point(12, 145);
            this.ClienteDGV.Name = "ClienteDGV";
            this.ClienteDGV.Size = new System.Drawing.Size(514, 291);
            this.ClienteDGV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BusquedaTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE:";
            // 
            // BusquedaTB
            // 
            this.BusquedaTB.Location = new System.Drawing.Point(116, 34);
            this.BusquedaTB.Name = "BusquedaTB";
            this.BusquedaTB.Size = new System.Drawing.Size(265, 20);
            this.BusquedaTB.TabIndex = 1;
            this.BusquedaTB.TextChanged += new System.EventHandler(this.BusquedaTB_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources._29461_200;
            this.pictureBox1.Location = new System.Drawing.Point(539, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NuevoTB
            // 
            this.NuevoTB.Location = new System.Drawing.Point(589, 202);
            this.NuevoTB.Name = "NuevoTB";
            this.NuevoTB.Size = new System.Drawing.Size(118, 39);
            this.NuevoTB.TabIndex = 3;
            this.NuevoTB.Text = "Nuevo Cliente";
            this.NuevoTB.UseVisualStyleBackColor = true;
            this.NuevoTB.Click += new System.EventHandler(this.NuevoTB_Click);
            // 
            // EliminarTB
            // 
            this.EliminarTB.Location = new System.Drawing.Point(589, 268);
            this.EliminarTB.Name = "EliminarTB";
            this.EliminarTB.Size = new System.Drawing.Size(118, 39);
            this.EliminarTB.TabIndex = 4;
            this.EliminarTB.Text = "Eliminar Cliente";
            this.EliminarTB.UseVisualStyleBackColor = true;
            this.EliminarTB.Click += new System.EventHandler(this.EliminarTB_Click);
            // 
            // VolverTB
            // 
            this.VolverTB.Location = new System.Drawing.Point(589, 333);
            this.VolverTB.Name = "VolverTB";
            this.VolverTB.Size = new System.Drawing.Size(118, 39);
            this.VolverTB.TabIndex = 5;
            this.VolverTB.Text = "Volver";
            this.VolverTB.UseVisualStyleBackColor = true;
            this.VolverTB.Click += new System.EventHandler(this.VolverTB_Click);
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.VolverTB);
            this.Controls.Add(this.EliminarTB);
            this.Controls.Add(this.NuevoTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClienteDGV);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarCliente_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClienteDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BusquedaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NuevoTB;
        private System.Windows.Forms.Button EliminarTB;
        private System.Windows.Forms.Button VolverTB;
    }
}