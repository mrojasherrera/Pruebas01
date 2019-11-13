using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.PantallaUsuarios
{
    public partial class PantallaProveedor : Form
    {
        public PantallaProveedor()
        {
            InitializeComponent();
        }

        private void PublicarBtn_Click(object sender, EventArgs e)
        {
            CrearOferta.Oferta oferta = new CrearOferta.Oferta();
            oferta.Show();
        }
    }
}
