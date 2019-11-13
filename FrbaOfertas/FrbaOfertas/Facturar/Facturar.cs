using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;

namespace FrbaOfertas.Facturar
{
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet4.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.gD2C2019DataSet4.Proveedor);

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            String comandoSql = String.Format("SELECT o.Oferta_codigo, o.Oferta_Descripcion, SUM(o.Oferta_Precio) FROM LOS_BORBOTONES.Oferta o join LOS_BORBOTONES.Cupon c on (o.Oferta_Codigo = c.Oferta_Codigo) where o.Provee_CUIT={1} ", ListProv.Text);
            DataSet datoSql = Utilidades.EjecutarSql(comandoSql);
            //DataTable ofertas = new DataTable();
            tablaOfertasDG.AutoGenerateColumns = false;
            tablaOfertasDG.DataSource = datoSql;

        }

       
    }
}
