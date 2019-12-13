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
    public partial class frmReserva : Form
    {
        private char Operacao { get; set; }
        private cliente temp_cliente = null;
        private quarto temp_quarto = null;

        public frmReserva()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var reservas = ef.reserva
                    .Where(r => r.ativo == true)
                    .Select(r => new { r.id, r.dt_inicio, r.dt_termino, r.quarto.numero })
                    .ToList();

                dgvQuartos.DataSource = reservas;
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (frmPesquisarCliente pesquisa = new frmPesquisarCliente())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    this.temp_cliente = pesquisa.escolhido;
                    this.txtCliente.Text = pesquisa.escolhido.primeiro_nome + " " + pesquisa.escolhido.ultimo_nome;
                }
            }
        }

        private void btnPesquisarQuarto_Click(object sender, EventArgs e)
        {
            using (frmPesquisarQuarto pesquisa = new frmPesquisarQuarto())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    this.temp_quarto = pesquisa.escolhido;
                    this.txtQuarto.Text = pesquisa.escolhido.numero.ToString();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Operacao = 'n';
            tcReserva.SelectedTab = tpgCriarReserva;
            txtCliente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            reserva r;
            bool valido = checarCampos(out r);

            if (valido && this.Operacao == 'n')
            {
                using (hotelEntities ef = new hotelEntities())
                {
                    r.cliente = ef.cliente.Find(this.temp_cliente.id);
                    r.quarto = ef.quarto.Find(this.temp_quarto.id);

                    ef.reserva.Add(r);
                    ef.SaveChanges();
                }
            }
            if (valido && this.Operacao == 'e')
            {
                int _id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                using (hotelEntities ef = new hotelEntities())
                {
                    reserva novo = ef.reserva.Find(_id);
                    novo.cliente = ef.cliente.Find(this.temp_cliente.id);
                    novo.quarto = ef.quarto.Find(this.temp_quarto.id);
                    novo.dt_inicio = r.dt_inicio;
                    novo.dt_termino = r.dt_termino;

                    ef.SaveChanges();
                }
            }
            if (valido)
            {
                limparCampos();
                tcReserva.SelectedTab = tpgReservas;
                CarregarGrid();
            }
        }

        private void limparCampos()
        {
            txtCliente.Text = "";
            this.temp_cliente = null;
            txtQuarto.Text = "";
            this.temp_quarto = null;
            txtDtInicio.Text = "";
            txtDtTermino.Text = "";
        }

        private bool checarCampos(out reserva r)
        {
            DateTime dt_inicio = DateTime.MinValue, dt_termino = DateTime.MinValue;
            string mensagem = "";

            if (txtCliente.Text.Equals("") || this.temp_cliente == null)
            {
                mensagem += "Cliente\n";
            }
            if (txtQuarto.Text.Equals("") || this.temp_quarto == null)
            {
                mensagem += "Quarto";
            }
            if (!DateTime.TryParse(txtDtInicio.Text, out dt_inicio))
            {
                mensagem += "Data de Início\n";
            }
            if (!DateTime.TryParse(txtDtTermino.Text, out dt_termino))
            {
                mensagem += "Data de Término\n";
            }

            if (!mensagem.Equals(""))
            {
                MessageBox.Show(
                    "As seguintes informações estão inválidas:\n" + mensagem,
                    "Salvar Reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                r = null;
                return false;
            }
            else
            {
                using (hotelEntities ef = new hotelEntities())
                {
                    r = new reserva();
                    r.dt_cadastro = DateTime.Now;
                    r.dt_inicio = dt_inicio;
                    r.dt_termino = dt_termino;
                    r.ativo = true;
                }

                return true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Operacao = 'e';
            int _id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
            preencherCampos(_id);
            tcReserva.SelectedTab = tpgCriarReserva;
            txtCliente.Focus();
        }

        private void preencherCampos(int _id)
        {
            using (hotelEntities ef = new hotelEntities())
            {
                reserva r = ef.reserva.Find(_id);
                txtCliente.Text = r.cliente.primeiro_nome + r.cliente.ultimo_nome;
                this.temp_cliente = r.cliente;
                txtQuarto.Text = r.quarto.numero.ToString();
                this.temp_quarto = r.quarto;
                txtDtInicio.Text = r.dt_inicio.ToString();
                txtDtTermino.Text = r.dt_termino.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow.Index != -1)
            {
                DialogResult opcao = MessageBox.Show(
                    "Tem certeza que deseja excluir essa reserva?",
                    "Excluir reserva",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (opcao.Equals(DialogResult.Yes))
                {
                    int _id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                    using (hotelEntities ef = new hotelEntities())
                    {
                        var escolhido = ef.reserva.Find(_id);
                        ef.reserva.Remove(escolhido);
                        ef.SaveChanges();
                    }
                    CarregarGrid();
                }
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow.Index != -1)
            {
                DialogResult conf = MessageBox.Show(
                    "Realmente deseja realizar check-in?",
                    "Atualizar Reserva",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (conf == DialogResult.Yes)
                {
                    int _id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                    using (hotelEntities ef = new hotelEntities())
                    {
                        var escolhido = ef.reserva.Find(_id);
                        escolhido.dt_entrada = DateTime.Now;
                        ef.SaveChanges();
                    }
                    CarregarGrid();
                }
            }
        }
    }
}
