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
    public partial class frmPesquisarQuarto : Form
    {
        public quarto escolhido { get; set; }
        public string msg { get; set; }

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
                if (cbDisponiveis.Checked)
                {
                    var listaQuartos = ef.vw_quartos
                        .Select(q => new
                        {
                            ID = q.id,
                            Numero = q.numero,
                            Andar = q.andar,
                            Preco = q.preco
                        })
                    .ToList();
                    dgvQuartos.DataSource = listaQuartos;
                }
                else
                {
                    var listaQuartos = ef.quarto
                   .Where(q => q.ativo == true)
                   .Select(q => new
                   {
                       ID = q.id,
                       Numero = q.numero,
                       Andar = q.andar,
                       Preco = q.preco
                   })
                   .ToList();
                    dgvQuartos.DataSource = listaQuartos;
                }
                
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

                    if (ef.vw_reservas.ToList().Exists(r => r.fk_quarto == escolhido_id))
                    {
                        if (msg == null)
                        {
                            msg = "Este quarto está ocupado.\nDeseja ver a reserva associada?";
                        }
                        DialogResult res = MessageBox.Show(
                            msg,
                            "Pesquisar Quarto",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (res == DialogResult.Yes)
                        {
                            List<reserva> reservas = ef.reserva
                                .Where(r => r.fk_quarto == this.escolhido.id
                                    && r.dt_saida == null)
                                .ToList();

                            foreach (reserva r in reservas)
                            {
                                this.escolhido.reserva.Add(r);
                            }
                        }
                        else
                        {
                            this.escolhido.reserva = new List<reserva>();
                            this.escolhido.reserva.Clear();
                        }
                    }
                    else
                    {
                        this.escolhido.reserva = new List<reserva>();
                        this.escolhido.reserva.Clear();
                    }
                    this.DialogResult = DialogResult.OK;
                }
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

        private void cbDisponiveis_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
