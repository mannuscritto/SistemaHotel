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
        reserva escolhido { get; set; }
        public frmPesquisarReserva()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
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
                    dgvReservas.DataSource = listaReservas.ToList();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow.Index != -1)
            {
                int _id = Convert.ToInt32(dgvReservas.CurrentRow.Cells["ID"].Value.ToString());
                using (hotelEntities ef = new hotelEntities())
                {
                    this.escolhido = ef.reserva.Find(_id);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cbMostrarEncerradas_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
