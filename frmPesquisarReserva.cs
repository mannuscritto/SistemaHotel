using System;
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
    public partial class frmPesquisarReserva : Form
    {
        public reserva escolhido { get; set; }
        public frmPesquisarReserva()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid(string termos = "")
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var listaReservas = ef.reserva
                    .Where(r => r.ativo == true)
                    .Select(r => new
                    {
                        ID = r.id,
                        Inicio = r.dt_inicio,
                        Termino = r.dt_termino,
                        Quarto = r.quarto.numero,
                        Cliente = r.cliente.primeiro_nome + " " + r.cliente.ultimo_nome,
                        Status = r.dt_entrada == null ? "Pendente" : r.dt_saida == null ? "Em aberto" : "Encerrada"
                    });
                if (!cbMostrarEncerradas.Checked)
                {
                    listaReservas = listaReservas
                        .Where(r => !r.Status.Equals("Encerrada"));
                }
                listaReservas = listaReservas.OrderBy(r => r.Inicio);
                var listaReservasList = listaReservas.ToList();
                if (!termos.Equals(""))
                {
                    listaReservasList = listaReservasList.FindAll(r =>
                        r.Cliente.ToUpper().StartsWith(termos.ToUpper())
                        || r.Quarto.ToString().StartsWith(termos));
                }
                dgvReservas.DataSource = listaReservasList;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                int _id = Convert.ToInt32(dgvReservas.CurrentRow.Cells["ID"].Value.ToString());
                using (hotelEntities ef = new hotelEntities())
                {
                    this.escolhido = ef.reserva.Find(_id);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Nenhuma reserva foi selecionada!",
                    "Pesquisar Reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbMostrarEncerradas_CheckedChanged(object sender, EventArgs e)
        {
            string termos = txtQuarto.Text;
            CarregarGrid(termos);
        }

        private void dgvReservas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnOk.PerformClick();
        }

        private void txtQuarto_TextChanged(object sender, EventArgs e)
        {
            string termos = txtQuarto.Text;
            CarregarGrid(termos);
        }
    }
}
