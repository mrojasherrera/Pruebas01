using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            NombreTB.Text = String.Empty;
            ApellidoTB.Text = String.Empty;
            DniTB.Text = String.Empty;
            MailTB.Text = String.Empty;
            TelefonoTB.Text = String.Empty;
            DireccionTB.Text = String.Empty;
            CiudadTB.Text = String.Empty;
            CodPostTB.Text = String.Empty;
            FechNacTB.Text = String.Empty;
        }
    }
}
