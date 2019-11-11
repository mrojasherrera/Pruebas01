namespace FrbaOfertas.CragaCredito
{
    partial class Cargar
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
            this.DatoTarjeta = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.NumericUpDown();
            this.TipoPago = new System.Windows.Forms.ComboBox();
            this.tipoDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet3 = new FrbaOfertas.GD2C2019DataSet3();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.CargarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DniCB = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet2 = new FrbaOfertas.GD2C2019DataSet2();
            this.clienteTableAdapter = new FrbaOfertas.GD2C2019DataSet2TableAdapters.ClienteTableAdapter();
            this.tipoDePagoTableAdapter = new FrbaOfertas.GD2C2019DataSet3TableAdapters.TipoDePagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Monto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGAR CRÉDITO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO DE PAGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATOS DE TARJETA:";
            // 
            // DatoTarjeta
            // 
            this.DatoTarjeta.Location = new System.Drawing.Point(236, 161);
            this.DatoTarjeta.Name = "DatoTarjeta";
            this.DatoTarjeta.Size = new System.Drawing.Size(166, 20);
            this.DatoTarjeta.TabIndex = 4;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(236, 120);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(166, 20);
            this.Monto.TabIndex = 5;
            // 
            // TipoPago
            // 
            this.TipoPago.DataSource = this.tipoDePagoBindingSource;
            this.TipoPago.DisplayMember = "Tipo_Pago_Desc";
            this.TipoPago.FormattingEnabled = true;
            this.TipoPago.Location = new System.Drawing.Point(236, 81);
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Size = new System.Drawing.Size(167, 21);
            this.TipoPago.TabIndex = 6;
            this.TipoPago.Text = "Elegir una opción...";
            // 
            // tipoDePagoBindingSource
            // 
            this.tipoDePagoBindingSource.DataMember = "TipoDePago";
            this.tipoDePagoBindingSource.DataSource = this.gD2C2019DataSet3;
            // 
            // gD2C2019DataSet3
            // 
            this.gD2C2019DataSet3.DataSetName = "GD2C2019DataSet3";
            this.gD2C2019DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(98, 267);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(95, 41);
            this.VolverBtn.TabIndex = 7;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            // 
            // CargarBtn
            // 
            this.CargarBtn.Location = new System.Drawing.Point(238, 267);
            this.CargarBtn.Name = "CargarBtn";
            this.CargarBtn.Size = new System.Drawing.Size(95, 41);
            this.CargarBtn.TabIndex = 8;
            this.CargarBtn.Text = "Cargar";
            this.CargarBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI:";
            // 
            // DniCB
            // 
            this.DniCB.DataSource = this.clienteBindingSource;
            this.DniCB.DisplayMember = "Cli_Dni";
            this.DniCB.FormattingEnabled = true;
            this.DniCB.Location = new System.Drawing.Point(236, 198);
            this.DniCB.Name = "DniCB";
            this.DniCB.Size = new System.Drawing.Size(166, 21);
            this.DniCB.TabIndex = 10;
            this.DniCB.Text = "Elegir un Cliente...";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.gD2C2019DataSet2;
            // 
            // gD2C2019DataSet2
            // 
            this.gD2C2019DataSet2.DataSetName = "GD2C2019DataSet2";
            this.gD2C2019DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDePagoTableAdapter
            // 
            this.tipoDePagoTableAdapter.ClearBeforeFill = true;
            // 
            // Cargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 346);
            this.Controls.Add(this.DniCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CargarBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.TipoPago);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.DatoTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cargar";
            this.Text = "Carga de Crédito";
            this.Load += new System.EventHandler(this.Cargar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Monto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DatoTarjeta;
        private System.Windows.Forms.NumericUpDown Monto;
        private System.Windows.Forms.ComboBox TipoPago;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button CargarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DniCB;
        private GD2C2019DataSet2 gD2C2019DataSet2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private GD2C2019DataSet2TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private GD2C2019DataSet3 gD2C2019DataSet3;
        private System.Windows.Forms.BindingSource tipoDePagoBindingSource;
        private GD2C2019DataSet3TableAdapters.TipoDePagoTableAdapter tipoDePagoTableAdapter;
    }
}