using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class frmQuarto : Form
    {
        private char Operacao { get; set; }
        private int escolhidoId { get; set; }

        public frmQuarto()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public frmQuarto(int _id)
        {
            InitializeComponent();
            CarregarGrid();
            this.Operacao = 'e';
            preencherCampos(_id);
            this.escolhidoId = _id;
            tcQuarto.SelectedTab = tpgCriarQuartos;
        }

        private void CarregarGrid()
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var dados = ef.quarto
                    .Where(q => q.ativo == true)
                    .Select(q => new { q.id, q.numero, q.andar, q.preco, q.tipo, q.tamanho })
                    .ToList();
                dgvQuartos.DataSource = dados;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Operacao = 'n';
            tcQuarto.SelectedTab = tpgCriarQuartos;
            txtNumero.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool valido = false;

            if (this.Operacao.Equals('n'))
            {
                quarto q = checarCampos(out valido);

                if (valido)
                {
                    quarto novo = new quarto();
                    novo.numero = q.numero;
                    novo.andar = q.andar;
                    novo.tipo = q.tipo + 1;
                    novo.tamanho = q.tamanho + 1;
                    novo.qtd_camas = q.qtd_camas;
                    novo.preco = q.preco;
                    novo.ativo = true;
                                        
                    using (hotelEntities ef = new hotelEntities())
                    {
                        foreach (int indexChecked in clbComodidades.CheckedIndices)
                        {
                            novo.comodidade.Add(
                                ef.comodidade.Find(indexChecked + 1));
                        }

                        ef.quarto.Add(novo);

                        ef.SaveChanges();
                    }
                }
            }
            else if (this.Operacao.Equals('e'))
            {
                quarto q = checarCampos(out valido);

                if (valido)
                {
                    using (hotelEntities ef = new hotelEntities())
                    {
                        int id = this.escolhidoId;
                        quarto novo = ef.quarto.Find(id);
                        novo.numero = q.numero;
                        novo.andar = q.andar;
                        novo.tipo = q.tipo + 1;
                        novo.tamanho = q.tamanho + 1;
                        novo.qtd_camas = q.qtd_camas;
                        novo.preco = q.preco;
                        novo.comodidade.Clear();

                        foreach (int indexChecked in clbComodidades.CheckedIndices)
                        {
                            novo.comodidade.Add(
                                ef.comodidade.Find(indexChecked + 1));
                        }

                        ef.SaveChanges();
                    }
                }
            }
            if (valido)
            {
                limparCampos();
                tcQuarto.SelectedTab = tpgQuartos;
                CarregarGrid();
            }
        }

        private void limparCampos()
        {
            txtNumero.Text = "";
            txtAndar.Text = "";
            txtCamas.Text = "";
            txtPreco.Text = "";
            cbTipo.SelectedIndex = -1;
            cbTamanho.SelectedIndex = -1;

            foreach (int itemIndex in clbComodidades.CheckedIndices)
            {
                clbComodidades.SetItemChecked(itemIndex, false);
            }
        }

        private quarto checarCampos(out bool valido)
        {
            int numero = 0, andar = 0, tipo = 0, tamanho = 0, camas = 0;
            decimal preco = 0;
            string mensagem = "";
            quarto q = new quarto();

            if (!txtNumero.Text.Equals(""))
            {
                if (!int.TryParse(txtNumero.Text, out numero))
                {
                    mensagem += "Número\n";
                }
            }
            if (!txtAndar.Text.Equals(""))
            {
                if (!int.TryParse(txtAndar.Text, out andar))
                {
                    mensagem += "Andar\n";
                }
            }
            if (!txtCamas.Text.Equals(""))
            {
                if (!int.TryParse(txtCamas.Text, out camas))
                {
                    mensagem += "Número de Camas\n";
                }
            }
            if (!txtPreco.Text.Equals(""))
            {
                if (!decimal.TryParse(txtPreco.Text, out preco))
                {
                    mensagem += "Preço\n";
                }
            }
            if (cbTipo.SelectedIndex != -1)
            {
                tipo = cbTipo.SelectedIndex;
            }
            else
            {
                mensagem += "Tipo\n";
            }
            if (cbTamanho.SelectedIndex != -1)
            {
                tamanho = cbTamanho.SelectedIndex;
            }
            else
            {
                mensagem += "Tamaho\n";
            }
            if (!mensagem.Equals(""))
            {
                MessageBox.Show("As seguintes informações estão inválidas:" + mensagem,
                    "Salvar Quarto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
                return null;
            }
            else
            {
                valido = true;
                q.numero = numero;
                q.andar = andar;
                q.qtd_camas = camas;
                q.preco = preco;
                q.tipo = tipo;
                q.tamanho = tamanho;
                return q;
            }
        }

        private void preencherCampos(int id)
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var escolhido = ef.quarto.Find(id);
                txtNumero.Text = escolhido.numero.ToString();
                txtAndar.Text = escolhido.andar.ToString();
                txtCamas.Text = escolhido.qtd_camas.ToString();
                txtPreco.Text = escolhido.preco.ToString();
                cbTipo.SelectedIndex = escolhido.tipo - 1;
                cbTamanho.SelectedIndex = escolhido.tamanho - 1;
                Console.WriteLine(escolhido.comodidade.Count);

                foreach (comodidade c in escolhido.comodidade)
                {
                    clbComodidades.SetItemChecked(c.id - 1, true);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvQuartos.CurrentRow.Index != -1)
            {
                this.Operacao = 'e';
                this.escolhidoId = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                preencherCampos(this.escolhidoId);
                tcQuarto.SelectedTab = tpgCriarQuartos;
                txtNumero.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow.Index != -1)
            {
                DialogResult opcao = MessageBox.Show(
                    "Tem certeza que deseja excluir esse quarto?",
                    "Excluir quarto",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (opcao.Equals(DialogResult.Yes))
                {
                    int id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value.ToString());
                    using (hotelEntities ef = new hotelEntities())
                    {
                        var escolhido = ef.quarto.Find(id);
                        ef.quarto.Remove(escolhido);
                        ef.SaveChanges();
                    }
                    CarregarGrid();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
            tcQuarto.SelectedTab = tpgQuartos;
        }
    }
}
