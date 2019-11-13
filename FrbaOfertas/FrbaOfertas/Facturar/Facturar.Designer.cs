namespace FrbaOfertas.Facturar
{
    partial class Facturar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListProv = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet4 = new FrbaOfertas.GD2C2019DataSet4();
            this.Desde = new System.Windows.Forms.DateTimePicker();
            this.Hasta = new System.Windows.Forms.DateTimePicker();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.FacturarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.proveedorTableAdapter = new FrbaOfertas.GD2C2019DataSet4TableAdapters.ProveedorTableAdapter();
            this.tablaOfertasDG = new System.Windows.Forms.DataGridView();
            this.Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOfertasDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURAR PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROVEEDOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESDE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "HASTA:";
            // 
            // ListProv
            // 
            this.ListProv.DataSource = this.proveedorBindingSource;
            this.ListProv.DisplayMember = "Provee_CUIT";
            this.ListProv.FormattingEnabled = true;
            this.ListProv.Location = new System.Drawing.Point(185, 87);
            this.ListProv.Name = "ListProv";
            this.ListProv.Size = new System.Drawing.Size(200, 21);
            this.ListProv.TabIndex = 0;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.gD2C2019DataSet4;
            // 
            // gD2C2019DataSet4
            // 
            this.gD2C2019DataSet4.DataSetName = "GD2C2019DataSet4";
            this.gD2C2019DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Desde
            // 
            this.Desde.Location = new System.Drawing.Point(185, 128);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(200, 20);
            this.Desde.TabIndex = 1;
            // 
            // Hasta
            // 
            this.Hasta.Location = new System.Drawing.Point(185, 174);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(200, 20);
            this.Hasta.TabIndex = 2;
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(107, 241);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(93, 47);
            this.VolverBtn.TabIndex = 4;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            // 
            // FacturarBtn
            // 
            this.FacturarBtn.Location = new System.Drawing.Point(715, 367);
            this.FacturarBtn.Name = "FacturarBtn";
            this.FacturarBtn.Size = new System.Drawing.Size(93, 47);
            this.FacturarBtn.TabIndex = 5;
            this.FacturarBtn.Text = "Facturar";
            this.FacturarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(292, 241);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(93, 47);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tablaOfertasDG
            // 
            this.tablaOfertasDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOfertasDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oferta,
            this.Descripcion,
            this.Importe});
            this.tablaOfertasDG.Location = new System.Drawing.Point(449, 87);
            this.tablaOfertasDG.Name = "tablaOfertasDG";
            this.tablaOfertasDG.Size = new System.Drawing.Size(347, 258);
            this.tablaOfertasDG.TabIndex = 11;
            // 
            // Oferta
            // 
            this.Oferta.DataPropertyName = "o.Oferta_Codigo";
            this.Oferta.HeaderText = "Ofertas";
            this.Oferta.Name = "Oferta";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "o.Oferta_Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 432);
            this.Controls.Add(this.tablaOfertasDG);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.FacturarBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.ListProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturar";
            this.Text = "Facturar a proveedor";
            this.Load += new System.EventHandler(this.Facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOfertasDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ListProv;
        private System.Windows.Forms.DateTimePicker Desde;
        private System.Windows.Forms.DateTimePicker Hasta;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button FacturarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private GD2C2019DataSet4 gD2C2019DataSet4;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private GD2C2019DataSet4TableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridView tablaOfertasDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;

    }
}