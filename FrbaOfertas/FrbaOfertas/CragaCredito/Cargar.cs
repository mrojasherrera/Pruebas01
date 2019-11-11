using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CragaCredito
{
    public partial class Cargar : Form
    {
        public Cargar()
        {
            InitializeComponent();
        }

        private void Cargar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet3.TipoDePago' Puede moverla o quitarla según sea necesario.
            this.tipoDePagoTableAdapter.Fill(this.gD2C2019DataSet3.TipoDePago);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet2.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.gD2C2019DataSet2.Cliente);

        }


    }
}
