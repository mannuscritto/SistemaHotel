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
    public partial class frmCliente : Form
    {
        private char Operacao { get; set; }
        private int escolhidoId { get; set; }

        public frmCliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public frmCliente(int _id)
        {
            InitializeComponent();
            CarregarGrid();
            this.Operacao = 'e';
            this.escolhidoId = _id;
            tcCliente.SelectedTab = tpgCriarCliente;
            preencherCampos(_id);
            txtPrimeiroNome.Focus();
        }

        private void CarregarGrid()
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var dados = ef.cliente
                    .Where(c => c.ativo == true)
                    .Select(c => new { c.id, c.primeiro_nome, c.ultimo_nome, c.doc_rg })
                    .ToList();
                dgvClientes.DataSource = dados;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Operacao = 'n';
            tcCliente.SelectedTab = tpgCriarCliente;
            txtPrimeiroNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente c;
            bool valido = checarCampos(out c);
            if (this.Operacao.Equals('n') && valido)
            {
                using (hotelEntities ef = new hotelEntities())
                {
                    ef.cliente.Add(c);
                    ef.SaveChanges();
                }
            }
            if (this.Operacao.Equals('e') && valido)
            {
                int _id = this.escolhidoId;
                using (hotelEntities ef = new hotelEntities())
                {
                    
                    cliente novo = ef.cliente.Find(_id);
                    novo.primeiro_nome = c.primeiro_nome;
                    novo.ultimo_nome = c.ultimo_nome;
                    novo.doc_rg = c.doc_rg;
                    novo.doc_cpf = c.doc_cpf;
                    novo.dt_nasc = c.dt_nasc;

                    ef.SaveChanges();
                }
            }
            if (valido)
            {
                limparCampos();
                tcCliente.SelectedTab = tpgClientes;
                CarregarGrid();
            }
        }

        private void limparCampos()
        {
            txtPrimeiroNome.Text = "";
            txtUltimoNome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtDtNasc.Text = "";
        }

        private bool checarCampos(out cliente c)
        {
            string primeiroNome = "", ultimoNome = "", DocRg = "", DocCpf = "";
            DateTime dtNasc = DateTime.MinValue;
            string mensagem = "";

            if (txtPrimeiroNome.Text.Equals(""))
            {
                mensagem += "Primeiro Nome\n";
            }
            else
            {
                primeiroNome = txtPrimeiroNome.Text;
            }
            if (txtUltimoNome.Text.Equals(""))
            {
                mensagem += "Último Nome\n";
            }
            else
            {
                ultimoNome = txtUltimoNome.Text;
            }
            if (txtRG.Text.Length < 12)
            {
                mensagem += "RG\n";
            }
            else
            {
                DocRg = txtRG.Text;
            }
            if (txtCPF.Text.Length < 14)
            {
                mensagem += "CPF\n";
            }
            else
            {
                DocCpf = txtCPF.Text;
            }
            if (!txtDtNasc.Text.Equals(""))
            {
                if (!DateTime.TryParse(txtDtNasc.Text, out dtNasc))
                {
                    mensagem += "Data de Nascimento";
                }
            }
            //Mostrar Mensagem de Erro
            if (!mensagem.Equals(""))
            {
                MessageBox.Show(
                    "As seguintes informações estão inválidas: " + mensagem,
                    "Salvar Novo Cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                c = null;
                return false;
            }
            else
            {
                c = new cliente();
                c.primeiro_nome = primeiroNome;
                c.ultimo_nome = ultimoNome;
                c.doc_rg = DocRg;
                c.doc_cpf = DocCpf;
                c.dt_nasc = dtNasc;
                c.ativo = true;

                return true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            tcCliente.SelectedTab = tpgClientes;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Index != -1)
            {
                this.Operacao = 'e';
                this.escolhidoId = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id"].Value.ToString());
                preencherCampos(this.escolhidoId);
                tcCliente.SelectedTab = tpgCriarCliente;
                txtPrimeiroNome.Focus();
            }
        }

        private void preencherCampos(int _id)
        {
            using (hotelEntities ef = new hotelEntities())
            {
                cliente c = ef.cliente.Find(_id);
                txtPrimeiroNome.Text = c.primeiro_nome;
                txtUltimoNome.Text = c.ultimo_nome;
                txtRG.Text = c.doc_rg;
                txtCPF.Text = c.doc_cpf;
                txtDtNasc.Text = c.dt_nasc.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Index != -1)
            {
                DialogResult opcao = MessageBox.Show(
                    "Tem certeza que deseja excluir esse cliente?",
                    "Excluir cliente",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (opcao.Equals(DialogResult.Yes))
                {
                    int _id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id"].Value.ToString());
                    using (hotelEntities ef = new hotelEntities())
                    {
                        var escolhido = ef.cliente.Find(_id);
                        ef.cliente.Remove(escolhido);
                        ef.SaveChanges();
                    }
                    CarregarGrid();
                }
            }
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar.PerformClick();
        }
    }
}
