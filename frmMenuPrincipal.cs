using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
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
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var listaReservas = ef.reserva
                    .Where(r => r.ativo == true
                        && r.dt_entrada == null
                        || r.dt_saida == null)
                    .Select(r => new
                    {
                        Cliente = r.cliente.ultimo_nome,
                        Quarto = r.quarto.numero,
                        Dias = EntityFunctions.DiffDays(r.dt_inicio, r.dt_termino)
                    })
                    .Take(10).ToList();
                dgvUltimasReservas.DataSource = listaReservas;
            }
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
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    //List<reserva> reservas = pesquisa.escolhido.reserva.ToList();
                    if (pesquisa.escolhido.reserva.ToList().Count > 0)
                    {
                        frmReserva reserva = new frmReserva(pesquisa.escolhido.reserva.ElementAt(0).id);
                        reserva.Show();
                    }
                    else
                    {
                        frmQuarto quarto = new frmQuarto(pesquisa.escolhido.id);
                        quarto.Show();
                    }
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
                    frmReserva reserva = new frmReserva(pesquisa.escolhido.id);
                    reserva.Show();
                }
            }
        }

        private void frmMenuPrincipal_MouseEnter(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
