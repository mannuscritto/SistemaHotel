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
    public partial class frmPesquisarCliente : Form
    {
        public cliente escolhido;

        public frmPesquisarCliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid(string termos = "")
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var dados = ef.cliente
                    .Where(c => c.ativo == true)
                    .Select(c => new 
                    { 
                        ID = c.id, 
                        PrimeiroNome = c.primeiro_nome, 
                        UltimoNome = c.ultimo_nome, 
                        RG = c.doc_rg
                    })
                    .ToList();
                var autoCompleteDados = ef.cliente
                    .Where(c => c.ativo == true)
                    .Select(c => c.primeiro_nome)
                    .ToArray<string>();
                if (!termos.Equals(""))
                {
                    dados = dados.FindAll(c => c.PrimeiroNome.ToUpper().StartsWith(termos.ToUpper())
                        || c.UltimoNome.ToUpper().StartsWith(termos.ToUpper())
                        || c.RG.Replace(",", string.Empty).StartsWith(termos));
                }
                dgvClientes.DataSource = dados;

                var source = new AutoCompleteStringCollection();
                source.AddRange(autoCompleteDados);

                txtTermo.AutoCompleteMode = AutoCompleteMode.Append;
                txtTermo.AutoCompleteCustomSource = source;
                txtTermo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int escolhido_id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id"].Value.ToString());
                using (hotelEntities ef = new hotelEntities())
                {
                    this.escolhido = ef.cliente.Find(escolhido_id);
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Nenhum cliente foi selecionado!",
                    "Pesquisar Cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk.PerformClick();
        }

        private void txtTermo_TextChanged(object sender, EventArgs e)
        {
            string termos = txtTermo.Text;
            CarregarGrid(termos);
        }
    }
}
