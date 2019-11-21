namespace FrbaOfertas
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RolCB = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roleTableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.RoleTableAdapter();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RolCB);
            this.groupBox1.Controls.Add(this.PassTB);
            this.groupBox1.Controls.Add(this.UsuarioTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // RolCB
            // 
            this.RolCB.DataSource = this.roleBindingSource;
            this.RolCB.DisplayMember = "Rol_Nombre";
            this.RolCB.FormattingEnabled = true;
            this.RolCB.Location = new System.Drawing.Point(173, 120);
            this.RolCB.Name = "RolCB";
            this.RolCB.Size = new System.Drawing.Size(185, 21);
            this.RolCB.TabIndex = 5;
            this.RolCB.ValueMember = "Rol_Nombre";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.gD2C2019DataSet;
            // 
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(173, 79);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(185, 20);
            this.PassTB.TabIndex = 4;
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Location = new System.Drawing.Point(173, 35);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(185, 20);
            this.UsuarioTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ROL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.Location = new System.Drawing.Point(254, 280);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(100, 38);
            this.IngresarBtn.TabIndex = 2;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = true;
            this.IngresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.secrecy_icon;
            this.pictureBox1.Location = new System.Drawing.Point(441, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(93, 280);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(100, 38);
            this.SalirBtn.TabIndex = 4;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 350);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox RolCB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private GD2C2019DataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.Button SalirBtn;
    }
}

