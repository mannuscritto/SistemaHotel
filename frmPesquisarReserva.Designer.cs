namespace SistemaHotel
{
    partial class frmPesquisarReserva
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
            this.lblPesquisarQuarto = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMostrarEncerradas = new System.Windows.Forms.CheckBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisarQuarto
            // 
            this.lblPesquisarQuarto.AutoSize = true;
            this.lblPesquisarQuarto.Location = new System.Drawing.Point(9, 9);
            this.lblPesquisarQuarto.Name = "lblPesquisarQuarto";
            this.lblPesquisarQuarto.Size = new System.Drawing.Size(109, 13);
            this.lblPesquisarQuarto.TabIndex = 1;
            this.lblPesquisarQuarto.Text = "Digite para pesquisar:";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(12, 25);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(325, 20);
            this.txtQuarto.TabIndex = 0;
            this.txtQuarto.TextChanged += new System.EventHandler(this.txtQuarto_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 30);
            this.panel2.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(305, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(386, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMostrarEncerradas);
            this.panel1.Controls.Add(this.lblPesquisarQuarto);
            this.panel1.Controls.Add(this.txtQuarto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 53);
            this.panel1.TabIndex = 5;
            // 
            // cbMostrarEncerradas
            // 
            this.cbMostrarEncerradas.AutoSize = true;
            this.cbMostrarEncerradas.Location = new System.Drawing.Point(343, 27);
            this.cbMostrarEncerradas.Name = "cbMostrarEncerradas";
            this.cbMostrarEncerradas.Size = new System.Drawing.Size(118, 17);
            this.cbMostrarEncerradas.TabIndex = 2;
            this.cbMostrarEncerradas.Text = "Mostrar Encerradas";
            this.cbMostrarEncerradas.UseVisualStyleBackColor = true;
            this.cbMostrarEncerradas.CheckedChanged += new System.EventHandler(this.cbMostrarEncerradas_CheckedChanged);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(0, 59);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(473, 355);
            this.dgvReservas.TabIndex = 7;
            this.dgvReservas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReservas_CellMouseDoubleClick);
            // 
            // frmPesquisarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPesquisarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Reserva";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisarQuarto;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.CheckBox cbMostrarEncerradas;
    }
}