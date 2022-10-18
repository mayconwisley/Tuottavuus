namespace Tuottavuus
{
    partial class FrmPesquisaAvaliacao
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
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MktDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtChamado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvPesquisa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaConceito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.LblInfoPesquisa = new System.Windows.Forms.Label();
            this.LblInfoCodigoAtendente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCompetencia
            // 
            this.LblCompetencia.AutoSize = true;
            this.LblCompetencia.Location = new System.Drawing.Point(12, 9);
            this.LblCompetencia.Name = "LblCompetencia";
            this.LblCompetencia.Size = new System.Drawing.Size(116, 13);
            this.LblCompetencia.TabIndex = 0;
            this.LblCompetencia.Text = "Competência: 00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 61);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(299, 21);
            this.CbxEmpresa.TabIndex = 0;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Empregado";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.Location = new System.Drawing.Point(12, 101);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(299, 21);
            this.CbxEmpregado.TabIndex = 1;
            this.CbxEmpregado.ValueMember = "Id";
            this.CbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Abertura";
            // 
            // MktDataAbertura
            // 
            this.MktDataAbertura.Location = new System.Drawing.Point(12, 161);
            this.MktDataAbertura.Mask = "00/00/0000";
            this.MktDataAbertura.Name = "MktDataAbertura";
            this.MktDataAbertura.Size = new System.Drawing.Size(88, 20);
            this.MktDataAbertura.TabIndex = 2;
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(106, 161);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(49, 20);
            this.TxtNota.TabIndex = 4;
            this.TxtNota.Text = "0";
            this.TxtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nota";
            // 
            // TxtChamado
            // 
            this.TxtChamado.Location = new System.Drawing.Point(161, 161);
            this.TxtChamado.Name = "TxtChamado";
            this.TxtChamado.Size = new System.Drawing.Size(72, 20);
            this.TxtChamado.TabIndex = 5;
            this.TxtChamado.Text = "0";
            this.TxtChamado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chamado";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(331, 15);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(104, 29);
            this.BtnGravar.TabIndex = 7;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(331, 50);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(104, 29);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(331, 85);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(104, 29);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            this.Id_Competencia,
            this.Id_Empresa,
            this.Id_Empregado,
            this.DataAbertura,
            this.CodigoAtendente,
            this.NomeAtendente,
            this.NotaConceito,
            this.Chamado});
            this.DgvPesquisa.Location = new System.Drawing.Point(12, 223);
            this.DgvPesquisa.MultiSelect = false;
            this.DgvPesquisa.Name = "DgvPesquisa";
            this.DgvPesquisa.ReadOnly = true;
            this.DgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPesquisa.Size = new System.Drawing.Size(423, 207);
            this.DgvPesquisa.TabIndex = 6;
            this.DgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPesquisa_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Id_Competencia
            // 
            this.Id_Competencia.DataPropertyName = "Id_Competencia";
            this.Id_Competencia.HeaderText = "IdCompetencia";
            this.Id_Competencia.Name = "Id_Competencia";
            this.Id_Competencia.ReadOnly = true;
            this.Id_Competencia.Visible = false;
            // 
            // Id_Empresa
            // 
            this.Id_Empresa.DataPropertyName = "Id_Empresa";
            this.Id_Empresa.HeaderText = "IdEmpresa";
            this.Id_Empresa.Name = "Id_Empresa";
            this.Id_Empresa.ReadOnly = true;
            this.Id_Empresa.Visible = false;
            // 
            // Id_Empregado
            // 
            this.Id_Empregado.DataPropertyName = "Id_Empregado";
            this.Id_Empregado.HeaderText = "IdEmpregado";
            this.Id_Empregado.Name = "Id_Empregado";
            this.Id_Empregado.ReadOnly = true;
            this.Id_Empregado.Visible = false;
            // 
            // DataAbertura
            // 
            this.DataAbertura.DataPropertyName = "DataAbertura";
            this.DataAbertura.HeaderText = "Data Abertura";
            this.DataAbertura.Name = "DataAbertura";
            this.DataAbertura.ReadOnly = true;
            // 
            // CodigoAtendente
            // 
            this.CodigoAtendente.DataPropertyName = "CodigoAtendente";
            this.CodigoAtendente.HeaderText = "Código Atendente";
            this.CodigoAtendente.Name = "CodigoAtendente";
            this.CodigoAtendente.ReadOnly = true;
            // 
            // NomeAtendente
            // 
            this.NomeAtendente.DataPropertyName = "NomeAtendente";
            this.NomeAtendente.HeaderText = "Nome";
            this.NomeAtendente.Name = "NomeAtendente";
            this.NomeAtendente.ReadOnly = true;
            // 
            // NotaConceito
            // 
            this.NotaConceito.DataPropertyName = "NotaConceito";
            this.NotaConceito.HeaderText = "Nota";
            this.NotaConceito.Name = "NotaConceito";
            this.NotaConceito.ReadOnly = true;
            // 
            // Chamado
            // 
            this.Chamado.DataPropertyName = "Chamado";
            this.Chamado.HeaderText = "Chamado";
            this.Chamado.Name = "Chamado";
            this.Chamado.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dois cliques sobre o item para alterar ou excluir";
            // 
            // LblInfoPesquisa
            // 
            this.LblInfoPesquisa.AutoSize = true;
            this.LblInfoPesquisa.Location = new System.Drawing.Point(12, 207);
            this.LblInfoPesquisa.Name = "LblInfoPesquisa";
            this.LblInfoPesquisa.Size = new System.Drawing.Size(76, 13);
            this.LblInfoPesquisa.TabIndex = 12;
            this.LblInfoPesquisa.Text = "Pesquisas - 00";
            // 
            // LblInfoCodigoAtendente
            // 
            this.LblInfoCodigoAtendente.AutoSize = true;
            this.LblInfoCodigoAtendente.Location = new System.Drawing.Point(12, 125);
            this.LblInfoCodigoAtendente.Name = "LblInfoCodigoAtendente";
            this.LblInfoCodigoAtendente.Size = new System.Drawing.Size(116, 13);
            this.LblInfoCodigoAtendente.TabIndex = 13;
            this.LblInfoCodigoAtendente.Text = "Código Atendente: 000";
            // 
            // FrmPesquisaAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 455);
            this.Controls.Add(this.LblInfoCodigoAtendente);
            this.Controls.Add(this.LblInfoPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvPesquisa);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtChamado);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.MktDataAbertura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxEmpregado);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaAvaliacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Avaliação";
            this.Load += new System.EventHandler(this.FrmPesquisaAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MktDataAbertura;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtChamado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblInfoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaConceito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chamado;
        private System.Windows.Forms.Label LblInfoCodigoAtendente;
    }
}