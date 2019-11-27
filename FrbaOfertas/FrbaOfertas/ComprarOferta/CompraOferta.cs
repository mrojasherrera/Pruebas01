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

namespace FrbaOfertas.ComprarOferta
{
    public partial class CompraOferta : Form
    {
        public CompraOferta(String usuario)
        {
            InitializeComponent();
            UsuarioTB.Text = usuario;
            cargarDatos();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void cargarDatos()
        {
            String cadena;
            cadena = "SELECT o.Oferta_Descripcion Descripción, o.Oferta_Codigo Código,  p.Provee_RS 'Razón Social', ";
            cadena += "o.Oferta_Precio_Ficticio 'Precio Lista', o.Oferta_Precio 'Precio Oferta', o.Oferta_Cantidad Disponible ";
            cadena += "FROM LOS_BORBOTONES.Oferta o JOIN LOS_BORBOTONES.Proveedor p ON (o.Provee_CUIT = p.Provee_CUIT) ";
            cadena += "ORDER BY 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            OfertaDGV.DataSource = dataSet.Tables[0];
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
