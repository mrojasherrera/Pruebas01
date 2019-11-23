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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        DataSet resultados = new DataSet();
        DataView busqueda;
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
                
        public void leer_datos(String query, ref DataSet principal, String tabla) 
        {
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();
                SqlDataAdapter data = new SqlDataAdapter(comando);
                data.Fill(principal, tabla);
                data.Dispose();
                conexion.Close();
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT c.Cli_Nombre Cliente, c.Cli_Apellido Apellido, c.Cli_Dni Dni, c.Cli_Mail Email FROM LOS_BORBOTONES.Cliente c JOIN LOS_BORBOTONES.Usuario u ON (c.User_name = u.User_name) WHERE u.Habilitado = 1 ", ref resultados, "LOS_BORBOTONES.Cliente");
            this.busqueda = ((DataTable)resultados.Tables["LOS_BORBOTONES.Cliente"]).DefaultView;
            this.ClienteDGV.DataSource = busqueda;

        }

        private void BuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void BusquedaTB_TextChanged(object sender, EventArgs e)
        {
            if (BusquedaTB.Text!="")
            {
                ClienteDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in ClienteDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in ClienteDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(BusquedaTB.Text.ToUpper()) == 0)
                        {
                            ClienteDGV.ClearSelection();
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                this.leer_datos("SELECT c.Cli_Nombre Cliente, c.Cli_Apellido Apellido, c.Cli_Dni Dni, c.Cli_Mail Email FROM LOS_BORBOTONES.Cliente c JOIN LOS_BORBOTONES.Usuario u ON (c.User_name = u.User_name) WHERE u.Habilitado = 1 ", ref resultados, "LOS_BORBOTONES.Cliente");
                this.busqueda = ((DataTable)resultados.Tables["LOS_BORBOTONES.Cliente"]).DefaultView;
                this.ClienteDGV.DataSource = busqueda;
            }
        }

        private void VolverTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoTB_Click(object sender, EventArgs e)
        {
            AbmCliente.NuevoCliente nuevo = new AbmCliente.NuevoCliente();
            nuevo.Show();
        }

        private void EliminarTB_Click(object sender, EventArgs e)
        {
             
            String dni = ClienteDGV.CurrentRow.Cells[2].Value.ToString();
            SqlCommand comandoEliminar = new SqlCommand("UPDATE LOS_BORBOTONES.Usuario SET Habilitado = 0 WHERE User_name = @Dni", conexion);
            comandoEliminar.Parameters.AddWithValue("@Dni", dni);
            conexion.Open();
            int cant;
            cant = comandoEliminar.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("El cliente está bloqueado...");

            }
            conexion.Close();
            
        }
    }
}
