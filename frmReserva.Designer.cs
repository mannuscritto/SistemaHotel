namespace SistemaHotel
{
    partial class frmReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcReserva = new System.Windows.Forms.TabControl();
            this.tpgReservas = new System.Windows.Forms.TabPage();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tpgCriarReserva = new System.Windows.Forms.TabPage();
            this.txtDtTermino = new System.Windows.Forms.MaskedTextBox();
            this.txtDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarQuarto = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tcReserva.SuspendLayout();
            this.tpgReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.panel4.SuspendLayout();
            this.tpgCriarReserva.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcReserva
            // 
            this.tcReserva.Controls.Add(this.tpgReservas);
            this.tcReserva.Controls.Add(this.tpgCriarReserva);
            this.tcReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcReserva.Location = new System.Drawing.Point(0, 0);
            this.tcReserva.Name = "tcReserva";
            this.tcReserva.SelectedIndex = 0;
            this.tcReserva.Size = new System.Drawing.Size(800, 400);
            this.tcReserva.TabIndex = 0;
            // 
            // tpgReservas
            // 
            this.tpgReservas.Controls.Add(this.dgvQuartos);
            this.tpgReservas.Controls.Add(this.panel4);
            this.tpgReservas.Location = new System.Drawing.Point(4, 22);
            this.tpgReservas.Name = "tpgReservas";
            this.tpgReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tpgReservas.Size = new System.Drawing.Size(792, 374);
            this.tpgReservas.TabIndex = 0;
            this.tpgReservas.Text = "Reservas";
            this.tpgReservas.UseVisualStyleBackColor = true;
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AllowUserToAddRows = false;
            this.dgvQuartos.AllowUserToDeleteRows = false;
            this.dgvQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuartos.Location = new System.Drawing.Point(3, 3);
            this.dgvQuartos.MultiSelect = false;
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.ReadOnly = true;
            this.dgvQuartos.Size = new System.Drawing.Size(786, 339);
            this.dgvQuartos.TabIndex = 5;
            this.dgvQuartos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuartos_CellMouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCheckout);
            this.panel4.Controls.Add(this.btnCheckin);
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.btnNovo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 29);
            this.panel4.TabIndex = 4;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(706, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Check-out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(625, 3);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(75, 23);
            this.btnCheckin.TabIndex = 3;
            this.btnCheckin.Text = "Check-in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(167, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(86, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar...";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(5, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo...";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tpgCriarReserva
            // 
            this.tpgCriarReserva.Controls.Add(this.txtDtTermino);
            this.tpgCriarReserva.Controls.Add(this.txtDtInicio);
            this.tpgCriarReserva.Controls.Add(this.btnPesquisarQuarto);
            this.tpgCriarReserva.Controls.Add(this.btnPesquisarCliente);
            this.tpgCriarReserva.Controls.Add(this.label4);
            this.tpgCriarReserva.Controls.Add(this.label3);
            this.tpgCriarReserva.Controls.Add(this.label2);
            this.tpgCriarReserva.Controls.Add(this.label1);
            this.tpgCriarReserva.Controls.Add(this.txtQuarto);
            this.tpgCriarReserva.Controls.Add(this.txtCliente);
            this.tpgCriarReserva.Controls.Add(this.panel2);
            this.tpgCriarReserva.Location = new System.Drawing.Point(4, 22);
            this.tpgCriarReserva.Name = "tpgCriarReserva";
            this.tpgCriarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCriarReserva.Size = new System.Drawing.Size(792, 374);
            this.tpgCriarReserva.TabIndex = 1;
            this.tpgCriarReserva.Text = "Novo";
            this.tpgCriarReserva.UseVisualStyleBackColor = true;
            // 
            // txtDtTermino
            // 
            this.txtDtTermino.Location = new System.Drawing.Point(103, 87);
            this.txtDtTermino.Mask = "00/00/0000";
            this.txtDtTermino.Name = "txtDtTermino";
            this.txtDtTermino.Size = new System.Drawing.Size(174, 20);
            this.txtDtTermino.TabIndex = 15;
            this.txtDtTermino.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtInicio
            // 
            this.txtDtInicio.Location = new System.Drawing.Point(103, 58);
            this.txtDtInicio.Mask = "00/00/0000";
            this.txtDtInicio.Name = "txtDtInicio";
            this.txtDtInicio.Size = new System.Drawing.Size(174, 20);
            this.txtDtInicio.TabIndex = 14;
            this.txtDtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisarQuarto
            // 
            this.btnPesquisarQuarto.Location = new System.Drawing.Point(509, 32);
            this.btnPesquisarQuarto.Name = "btnPesquisarQuarto";
            this.btnPesquisarQuarto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarQuarto.TabIndex = 13;
            this.btnPesquisarQuarto.Text = "Procurar";
            this.btnPesquisarQuarto.UseVisualStyleBackColor = true;
            this.btnPesquisarQuarto.Click += new System.EventHandler(this.btnPesquisarQuarto_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(509, 4);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCliente.TabIndex = 12;
            this.btnPesquisarCliente.Text = "Procurar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data do Início:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quarto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data do Término:";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Enabled = false;
            this.txtQuarto.Location = new System.Drawing.Point(103, 32);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(400, 20);
            this.txtQuarto.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(103, 6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(400, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 116);
            this.panel2.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(5, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 50;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcReserva);
            this.MaximizeBox = false;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Reservas";
            this.tcReserva.ResumeLayout(false);
            this.tpgReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tpgCriarReserva.ResumeLayout(false);
            this.tpgCriarReserva.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReserva;
        private System.Windows.Forms.TabPage tpgReservas;
        private System.Windows.Forms.TabPage tpgCriarReserva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnPesquisarQuarto;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDtTermino;
        private System.Windows.Forms.MaskedTextBox txtDtInicio;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCancelar;
    }
}