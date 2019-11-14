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
    public partial class PantallaAdmin : Form
    {
        public PantallaAdmin(String unAdm)
        {
            InitializeComponent();
            AdmTB.Text = unAdm;
        }

        private void FuncionalidadesBtn_Click(object sender, EventArgs e)
        {
            Administrativo.ListadoAcciones listado = new Administrativo.ListadoAcciones();
            listado.Show();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
