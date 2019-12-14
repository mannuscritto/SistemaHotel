namespace SistemaHotel
{
    partial class frmQuarto
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
            this.tcQuarto = new System.Windows.Forms.TabControl();
            this.tpgQuartos = new System.Windows.Forms.TabPage();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tpgCriarQuartos = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCamas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbComodidades = new System.Windows.Forms.CheckedListBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTamanho = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblAndar = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tcQuarto.SuspendLayout();
            this.tpgQuartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.panel4.SuspendLayout();
            this.tpgCriarQuartos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuarto
            // 
            this.tcQuarto.Controls.Add(this.tpgQuartos);
            this.tcQuarto.Controls.Add(this.tpgCriarQuartos);
            this.tcQuarto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcQuarto.Location = new System.Drawing.Point(0, 0);
            this.tcQuarto.Name = "tcQuarto";
            this.tcQuarto.SelectedIndex = 0;
            this.tcQuarto.Size = new System.Drawing.Size(800, 400);
            this.tcQuarto.TabIndex = 0;
            // 
            // tpgQuartos
            // 
            this.tpgQuartos.Controls.Add(this.dgvQuartos);
            this.tpgQuartos.Controls.Add(this.panel4);
            this.tpgQuartos.Location = new System.Drawing.Point(4, 22);
            this.tpgQuartos.Name = "tpgQuartos";
            this.tpgQuartos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgQuartos.Size = new System.Drawing.Size(792, 374);
            this.tpgQuartos.TabIndex = 0;
            this.tpgQuartos.Text = "Quartos";
            this.tpgQuartos.UseVisualStyleBackColor = true;
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AllowUserToAddRows = false;
            this.dgvQuartos.AllowUserToDeleteRows = false;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuartos.Location = new System.Drawing.Point(3, 3);
            this.dgvQuartos.MultiSelect = false;
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.ReadOnly = true;
            this.dgvQuartos.Size = new System.Drawing.Size(786, 339);
            this.dgvQuartos.TabIndex = 1;
            this.dgvQuartos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuartos_CellMouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.btnNovo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 29);
            this.panel4.TabIndex = 0;
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
            // tpgCriarQuartos
            // 
            this.tpgCriarQuartos.Controls.Add(this.panel2);
            this.tpgCriarQuartos.Controls.Add(this.panel1);
            this.tpgCriarQuartos.Location = new System.Drawing.Point(4, 22);
            this.tpgCriarQuartos.Name = "tpgCriarQuartos";
            this.tpgCriarQuartos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCriarQuartos.Size = new System.Drawing.Size(792, 374);
            this.tpgCriarQuartos.TabIndex = 1;
            this.tpgCriarQuartos.Text = "Novo";
            this.tpgCriarQuartos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 116);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(5, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCamas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clbComodidades);
            this.panel1.Controls.Add(this.lblTamanho);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.cbTamanho);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.txtAndar);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.lblAndar);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 243);
            this.panel1.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(311, 32);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(174, 20);
            this.txtPreco.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Preço:";
            // 
            // txtCamas
            // 
            this.txtCamas.Location = new System.Drawing.Point(311, 3);
            this.txtCamas.Name = "txtCamas";
            this.txtCamas.Size = new System.Drawing.Size(174, 20);
            this.txtCamas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Camas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comodidades:";
            // 
            // clbComodidades
            // 
            this.clbComodidades.CheckOnClick = true;
            this.clbComodidades.FormattingEnabled = true;
            this.clbComodidades.Items.AddRange(new object[] {
            "Wi-Fi",
            "Ar-condicionado",
            "TV",
            "TV a cabo",
            "Telefone",
            "Secador",
            "Banheira"});
            this.clbComodidades.Location = new System.Drawing.Point(83, 112);
            this.clbComodidades.Name = "clbComodidades";
            this.clbComodidades.Size = new System.Drawing.Size(174, 109);
            this.clbComodidades.TabIndex = 8;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(3, 88);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(55, 13);
            this.lblTamanho.TabIndex = 7;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 61);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbTamanho
            // 
            this.cbTamanho.FormattingEnabled = true;
            this.cbTamanho.Items.AddRange(new object[] {
            "Padrão",
            "Duplo",
            "Família"});
            this.cbTamanho.Location = new System.Drawing.Point(83, 85);
            this.cbTamanho.Name = "cbTamanho";
            this.cbTamanho.Size = new System.Drawing.Size(174, 21);
            this.cbTamanho.TabIndex = 5;
            this.cbTamanho.Text = "Selecione";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Solteiro",
            "Casal",
            "Dormitório",
            "Apartamento"});
            this.cbTipo.Location = new System.Drawing.Point(83, 58);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(174, 21);
            this.cbTipo.TabIndex = 4;
            this.cbTipo.Text = "Selecione";
            // 
            // txtAndar
            // 
            this.txtAndar.Location = new System.Drawing.Point(83, 32);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(174, 20);
            this.txtAndar.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(83, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(174, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Location = new System.Drawing.Point(3, 35);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(38, 13);
            this.lblAndar.TabIndex = 1;
            this.lblAndar.Text = "Andar:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(3, 6);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 44);
            this.panel3.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tcQuarto);
            this.MaximizeBox = false;
            this.Name = "frmQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Quartos";
            this.tcQuarto.ResumeLayout(false);
            this.tpgQuartos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tpgCriarQuartos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuarto;
        private System.Windows.Forms.TabPage tpgQuartos;
        private System.Windows.Forms.TabPage tpgCriarQuartos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbComodidades;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTamanho;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCamas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}