using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class Oferta : Form
    {
        public Oferta()
        {
            InitializeComponent();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaUsuarios.PantallaProveedor pantallaProv = new PantallaUsuarios.PantallaProveedor();
            pantallaProv.Show();
        }
    }
}
