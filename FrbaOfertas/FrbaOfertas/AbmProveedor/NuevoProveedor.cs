using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class NuevoProveedor : Form
    {
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            RaSoTB.Text = String.Empty;
            CuitTB.Text = String.Empty;
            MailTB.Text = String.Empty;
            TelefonoTB.Text = String.Empty;
            DirTB.Text = String.Empty;
            CodPosTB.Text = String.Empty;
            CiudadTB.Text = String.Empty;
            RubroTB.Text = String.Empty;
            NomConTB.Text = String.Empty;
        }
    }
}
