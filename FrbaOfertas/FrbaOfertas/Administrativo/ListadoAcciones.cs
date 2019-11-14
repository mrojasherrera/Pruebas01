﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Administrativo
{
    public partial class ListadoAcciones : Form
    {
        public ListadoAcciones()
        {
            InitializeComponent();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            AbmCliente.AccionesCliente abmCliente = new AbmCliente.AccionesCliente();
            abmCliente.Show();
        }

        private void ProveedorBtn_Click(object sender, EventArgs e)
        {
            AbmProveedor.AccionesProveedor proveedor = new AbmProveedor.AccionesProveedor();
            proveedor.Show();
        }

        private void CreditoBtn_Click(object sender, EventArgs e)
        {
            CargaCredito.Cargar cargar = new CargaCredito.Cargar();
            cargar.Show();
        }
    }
}
