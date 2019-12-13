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
    public partial class frmPesquisarQuarto : Form
    {
        public quarto escolhido { get; set; }

        public frmPesquisarQuarto()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid(string termos = "")
        //TODO: criar procedure que selecione somente quartos disponíveis
        {
            using (hotelEntities ef = new hotelEntities())
            {
                var listaQuartos = ef.quarto
                    .Where(q => q.ativo == true)
                    .Select(q => new { q.id, q.numero, q.andar, q.tipo, q.tamanho })
                    .ToList();

                dgvQuartos.DataSource = listaQuartos;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow.Index != -1)
            {
                int escolhido_id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id"].Value);
                
                using (hotelEntities ef = new hotelEntities())
                {
                    this.escolhido = ef.quarto.Find(escolhido_id);
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Nenhum quarto foi selecionado!",
                    "Pesquisar Quarto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtQuarto_TextChanged(object sender, EventArgs e)
        {
            string termos = txtTermo.Text;
            CarregarGrid(termos);
        }

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOk.PerformClick();
        }
    }
}
