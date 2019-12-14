﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuarto quarto = new frmQuarto();
            quarto.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva reserva = new frmReserva();
            reserva.Show();
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarQuarto pesquisa = new frmPesquisarQuarto())
            {
                DialogResult res = pesquisa.ShowDialog();
                if (res == DialogResult.OK)
                {
                    frmQuarto quarto = new frmQuarto(pesquisa.escolhido.id);
                    quarto.Show();
                }
                else if (res == DialogResult.Yes)
                {
                    frmReserva reserva = new frmReserva();
                }
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarCliente pesquisa = new frmPesquisarCliente())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    frmCliente cliente = new frmCliente(pesquisa.escolhido.id);
                    cliente.Show();
                }
            }
        }

        private void reservaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmPesquisarReserva pesquisa = new frmPesquisarReserva())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    frmPesquisarReserva reserva = new frmPesquisarReserva();
                    reserva.Show();
                }
            }
        }
    }
}
