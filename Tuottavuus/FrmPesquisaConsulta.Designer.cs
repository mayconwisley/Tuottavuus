namespace Tuottavuus
{
    partial class FrmPesquisaConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.GbInformacao = new System.Windows.Forms.GroupBox();
            this.DgvPesquisa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbGeral = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competência";
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(12, 25);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(69, 20);
            this.MktCompetencia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 77);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(276, 21);
            this.CbxEmpresa.TabIndex = 3;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empregado";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.Location = new System.Drawing.Point(12, 126);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(276, 21);
            this.CbxEmpregado.TabIndex = 3;
            this.CbxEmpregado.ValueMember = "Id";
            this.CbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // GbInformacao
            // 
            this.GbInformacao.Location = new System.Drawing.Point(308, 12);
            this.GbInformacao.Name = "GbInformacao";
            this.GbInformacao.Size = new System.Drawing.Size(444, 150);
            this.GbInformacao.TabIndex = 6;
            this.GbInformacao.TabStop = false;
            this.GbInformacao.Text = "Informações";
            // 
            // DgvPesquisa
            // 
            this.DgvPesquisa.AllowUserToAddRows = false;
            this.DgvPesquisa.AllowUserToDeleteRows = false;
            this.DgvPesquisa.AllowUserToOrderColumns = true;
            this.DgvPesquisa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdCompetencia,
            this.IdEmpregado,
            this.DataAbertura,
            this.CodigoAtendente,
            this.Nome,
            this.Nota,
            this.Chamado});
            this.DgvPesquisa.Location = new System.Drawing.Point(12, 183);
            this.DgvPesquisa.MultiSelect = false;
            this.DgvPesquisa.Name = "DgvPesquisa";
            this.DgvPesquisa.ReadOnly = true;
            this.DgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPesquisa.Size = new System.Drawing.Size(740, 240);
            this.DgvPesquisa.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdCompetencia
            // 
            this.IdCompetencia.HeaderText = "IdCompetencia";
            this.IdCompetencia.Name = "IdCompetencia";
            this.IdCompetencia.ReadOnly = true;
            this.IdCompetencia.Visible = false;
            // 
            // IdEmpregado
            // 
            this.IdEmpregado.HeaderText = "IdEmpregado";
            this.IdEmpregado.Name = "IdEmpregado";
            this.IdEmpregado.ReadOnly = true;
            // 
            // DataAbertura
            // 
            this.DataAbertura.HeaderText = "Data Abertura";
            this.DataAbertura.Name = "DataAbertura";
            this.DataAbertura.ReadOnly = true;
            // 
            // CodigoAtendente
            // 
            this.CodigoAtendente.HeaderText = "Código Atendente";
            this.CodigoAtendente.Name = "CodigoAtendente";
            this.CodigoAtendente.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Chamado
            // 
            this.Chamado.HeaderText = "Chamado";
            this.Chamado.Name = "Chamado";
            this.Chamado.ReadOnly = true;
            // 
            // CbGeral
            // 
            this.CbGeral.AutoSize = true;
            this.CbGeral.Location = new System.Drawing.Point(237, 28);
            this.CbGeral.Name = "CbGeral";
            this.CbGeral.Size = new System.Drawing.Size(51, 17);
            this.CbGeral.TabIndex = 8;
            this.CbGeral.Text = "Geral";
            this.CbGeral.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 435);
            this.Controls.Add(this.CbGeral);
            this.Controls.Add(this.DgvPesquisa);
            this.Controls.Add(this.GbInformacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxEmpregado);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaConsulta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Consulta";
            this.Load += new System.EventHandler(this.FrmPesquisaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.GroupBox GbInformacao;
        private System.Windows.Forms.DataGridView DgvPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chamado;
        private System.Windows.Forms.CheckBox CbGeral;
    }
}