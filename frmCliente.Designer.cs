namespace SistemaHotel
{
    partial class frmCliente
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
            this.tcCliente = new System.Windows.Forms.TabControl();
            this.tpgClientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tpgCriarCliente = new System.Windows.Forms.TabPage();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUltimoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tcCliente.SuspendLayout();
            this.tpgClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel4.SuspendLayout();
            this.tpgCriarCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCliente
            // 
            this.tcCliente.Controls.Add(this.tpgClientes);
            this.tcCliente.Controls.Add(this.tpgCriarCliente);
            this.tcCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcCliente.Location = new System.Drawing.Point(0, 0);
            this.tcCliente.Name = "tcCliente";
            this.tcCliente.SelectedIndex = 0;
            this.tcCliente.Size = new System.Drawing.Size(800, 400);
            this.tcCliente.TabIndex = 0;
            // 
            // tpgClientes
            // 
            this.tpgClientes.Controls.Add(this.dgvClientes);
            this.tpgClientes.Controls.Add(this.panel4);
            this.tpgClientes.Location = new System.Drawing.Point(4, 22);
            this.tpgClientes.Name = "tpgClientes";
            this.tpgClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpgClientes.Size = new System.Drawing.Size(792, 374);
            this.tpgClientes.TabIndex = 0;
            this.tpgClientes.Text = "Clientes";
            this.tpgClientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(786, 339);
            this.dgvClientes.TabIndex = 3;
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
            this.panel4.TabIndex = 2;
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
            // tpgCriarCliente
            // 
            this.tpgCriarCliente.Controls.Add(this.txtRG);
            this.tpgCriarCliente.Controls.Add(this.txtCPF);
            this.tpgCriarCliente.Controls.Add(this.label5);
            this.tpgCriarCliente.Controls.Add(this.txtDtNasc);
            this.tpgCriarCliente.Controls.Add(this.label4);
            this.tpgCriarCliente.Controls.Add(this.label3);
            this.tpgCriarCliente.Controls.Add(this.txtUltimoNome);
            this.tpgCriarCliente.Controls.Add(this.label2);
            this.tpgCriarCliente.Controls.Add(this.txtPrimeiroNome);
            this.tpgCriarCliente.Controls.Add(this.label1);
            this.tpgCriarCliente.Controls.Add(this.panel2);
            this.tpgCriarCliente.Location = new System.Drawing.Point(4, 22);
            this.tpgCriarCliente.Name = "tpgCriarCliente";
            this.tpgCriarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCriarCliente.Size = new System.Drawing.Size(792, 374);
            this.tpgCriarCliente.TabIndex = 1;
            this.tpgCriarCliente.Text = "Novo";
            this.tpgCriarCliente.UseVisualStyleBackColor = true;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(121, 58);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(174, 20);
            this.txtRG.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(121, 84);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(174, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Nascimento:";
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Location = new System.Drawing.Point(121, 110);
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(174, 20);
            this.txtDtNasc.TabIndex = 5;
            this.txtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RG:";
            // 
            // txtUltimoNome
            // 
            this.txtUltimoNome.Location = new System.Drawing.Point(121, 32);
            this.txtUltimoNome.Name = "txtUltimoNome";
            this.txtUltimoNome.Size = new System.Drawing.Size(174, 20);
            this.txtUltimoNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Último Nome:";
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.Location = new System.Drawing.Point(121, 6);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(174, 20);
            this.txtPrimeiroNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primeiro Nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 116);
            this.panel2.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(5, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 60;
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
            this.panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 50;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcCliente);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Clientes";
            this.tcCliente.ResumeLayout(false);
            this.tpgClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tpgCriarCliente.ResumeLayout(false);
            this.tpgCriarCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCliente;
        private System.Windows.Forms.TabPage tpgClientes;
        private System.Windows.Forms.TabPage tpgCriarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDtNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUltimoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnCancelar;
    }
}