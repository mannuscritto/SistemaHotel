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
    public partial class frmReserva : Form
    {
        private char Operacao { get; set; }
        private cliente temp_cliente = null;
        private quarto temp_quarto = null;
        private int escolhidoId { get; set; }

        public frmReserva()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public frmReserva(int _id)
        {
            InitializeComponent();
            CarregarGrid();
            this.Operacao = 'e';
            preencherCampos(_id);
            tcReserva.SelectedTab = tpgCriarReserva;
        }

        private void CarregarGrid()
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var reservas = ef.vw_reservas
                    .Select(r => new
                    {
                        ID = r.id,
                        DataInicio = r.dt_inicio,
                        DataEntrada = r.dt_entrada,
                        DataTermino = r.dt_termino,
                        DataSaida = r.dt_saida,
                        Cliente = r.primeiro_nome,
                        Quarto = r.numero,
                        Status = r.dt_entrada == null ? "Pendente" : "Em aberto"
                    })
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
                pesquisa.msg = "Este quarto já está ocupado!";
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
            bool valido;
            valido = checarCampos(out r);
            if (valido)
            {
                valido = checarDatas(r);
            }
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
                int _id = this.escolhidoId;
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

        private bool checarDatas(reserva n)
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var listaReservas = ef.vw_reservas
                    .Where(e => e.numero == this.temp_quarto.numero
                        && DateTime.Compare(e.dt_inicio, n.dt_termino) <= 0
                        && DateTime.Compare(e.dt_termino, n.dt_inicio) >= 0)
                    .ToList();
                int max = this.Operacao == 'n' ? 0 : 1;
                if (listaReservas.Count > max)
                {
                    MessageBox.Show(
                        "Há reservas em conflito!",
                        "Cadastrar Reserva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void limparCampos()
        {
            txtCliente.Text = "";
            this.temp_cliente = null;
            txtQuarto.Text = "";
            this.temp_quarto = null;
            txtDtInicio.Value = DateTime.Now;
            txtDtTermino.Value = DateTime.Now;
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
                mensagem += "Quarto\n";
            }
            if (!DateTime.TryParse(txtDtInicio.Value.ToString(), out dt_inicio))
            {
                mensagem += "Data de Início\n";
            }
            if (!DateTime.TryParse(txtDtTermino.Value.ToString(), out dt_termino))
            {
                mensagem += "Data de Término\n";
            }
            if (dt_inicio.CompareTo(dt_termino) > 0)
            {
                mensagem += "Data de término anterior a data de início\n";
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
            if (dgvQuartos.CurrentRow != null)
            {
                this.Operacao = 'e';
                int _id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                preencherCampos(_id);
                tcReserva.SelectedTab = tpgCriarReserva;
                txtCliente.Focus();
            }
            else
            {
                MessageBox.Show(
                   "Nenhuma reserva foi selecionada!",
                   "Editar reserva",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void preencherCampos(int _id)
        {
            this.escolhidoId = _id;
            using (hotelEntities ef = new hotelEntities())
            {
                reserva r = ef.reserva.Find(_id);
                txtCliente.Text = r.cliente.primeiro_nome + r.cliente.ultimo_nome;
                this.temp_cliente = r.cliente;
                txtQuarto.Text = r.quarto.numero.ToString();
                this.temp_quarto = r.quarto;
                txtDtInicio.Value = r.dt_inicio;
                txtDtTermino.Value = r.dt_termino;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow != null)
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
            else
            {
                MessageBox.Show(
                    "Nenhuma reserva foi selecionada!",
                    "Excluir reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow != null)
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
            else
            {
                MessageBox.Show(
                    "Nenhuma reserva foi selecionada!",
                    "Checkin de reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow != null)
            {                  
                int _id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                using (hotelEntities ef = new hotelEntities())
                {
                    var escolhido = ef.reserva.Find(_id);
                    if (escolhido.dt_entrada != null)
                    {
                        DialogResult conf = MessageBox.Show(
                            "Realmente deseja realizar check-out?",
                            "Atualizar Reserva",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);
                        if (conf == DialogResult.Yes)
                        {
                            escolhido.dt_saida = DateTime.Now;
                            ef.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Check-in ainda não realizado!",
                            "Atualizar Reserva",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    
                }
                CarregarGrid();
            }
            else
            {
                MessageBox.Show(
                    "Nenhuma reserva foi selecionada!",
                    "Checkout de reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
            tcReserva.SelectedTab = tpgReservas;
        }

        private void dgvQuartos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar.PerformClick();
        }
    }
}
