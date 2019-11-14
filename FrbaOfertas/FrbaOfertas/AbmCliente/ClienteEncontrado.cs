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
    public partial class ClienteEncontrado : Form
    {
        public ClienteEncontrado()
        {
            InitializeComponent();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            AbmCliente.ModificarCliente modificar = new AbmCliente.ModificarCliente();
            modificar.Show();
        }
    }
}
