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

namespace FrbaOfertas.AbmCliente
{
    public partial class RestaurarCliente : Form
    {
        public RestaurarCliente()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void RestaurarCliente_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT u.User_name, c.Cli_Nombre, c.Cli_Apellido FROM LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Cliente c ON (u.User_name = c.Username) WHERE u.Habilitado = 0 ", conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
           /* CliBorradoCB.DisplayMember = "u.User_name";
            CliBorradoCB.DataSource = tabla;
            CliBorradoCB.ValueMember = "u.User_name";*/
        }

        private void CliBorradoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
