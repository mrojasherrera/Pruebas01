namespace FrbaOfertas
{
    partial class IniciarSesion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.RolCB = new System.Windows.Forms.ComboBox();
            this.gD2C2019DataSet4 = new FrbaOfertas.GD2C2019DataSet4();
            this.roleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new FrbaOfertas.GD2C2019DataSet4TableAdapters.RoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "ROL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "USUARIO:";
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Location = new System.Drawing.Point(223, 118);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(177, 20);
            this.UsuarioTB.TabIndex = 0;
            // 
            // PassTB
            // 
            this.PassTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PassTB.Location = new System.Drawing.Point(223, 151);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(177, 20);
            this.PassTB.TabIndex = 1;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.Location = new System.Drawing.Point(292, 253);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(101, 42);
            this.IngresarBtn.TabIndex = 4;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = true;
            this.IngresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(147, 253);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(101, 42);
            this.SalirBtn.TabIndex = 3;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // RolCB
            // 
            this.RolCB.DataSource = this.roleBindingSource1;
            this.RolCB.DisplayMember = "Rol_Nombre";
            this.RolCB.FormattingEnabled = true;
            this.RolCB.Location = new System.Drawing.Point(223, 180);
            this.RolCB.Name = "RolCB";
            this.RolCB.Size = new System.Drawing.Size(177, 21);
            this.RolCB.TabIndex = 21;
            this.RolCB.ValueMember = "Rol_Nombre";
            // 
            // gD2C2019DataSet4
            // 
            this.gD2C2019DataSet4.DataSetName = "GD2C2019DataSet4";
            this.gD2C2019DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleBindingSource1
            // 
            this.roleBindingSource1.DataMember = "Role";
            this.roleBindingSource1.DataSource = this.gD2C2019DataSet4;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 341);
            this.Controls.Add(this.RolCB);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UsuarioTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.ComboBox RolCB;
        private GD2C2019DataSet4 gD2C2019DataSet4;
        private System.Windows.Forms.BindingSource roleBindingSource1;
        private GD2C2019DataSet4TableAdapters.RoleTableAdapter roleTableAdapter;
    }
}