namespace Tuottavuus
{
    partial class FrmCadastroAvaliacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.DgvAvaliacao = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtividadeDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpregadoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxAtividade = new System.Windows.Forms.ComboBox();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvaliacao)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.IntegralHeight = false;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 48);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(314, 21);
            this.CbxEmpresa.TabIndex = 2;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empregado";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.IntegralHeight = false;
            this.CbxEmpregado.Location = new System.Drawing.Point(12, 96);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(314, 21);
            this.CbxEmpregado.TabIndex = 4;
            this.CbxEmpregado.ValueMember = "Id";
            this.CbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // DgvAvaliacao
            // 
            this.DgvAvaliacao.AllowUserToAddRows = false;
            this.DgvAvaliacao.AllowUserToDeleteRows = false;
            this.DgvAvaliacao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAvaliacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvAvaliacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAvaliacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AtividadeDescricao,
            this.Notaa,
            this.DataCompetencia,
            this.NomeEmpresa,
            this.IdEmpregadoo,
            this.NomeEmpregado});
            this.DgvAvaliacao.Location = new System.Drawing.Point(12, 218);
            this.DgvAvaliacao.MultiSelect = false;
            this.DgvAvaliacao.Name = "DgvAvaliacao";
            this.DgvAvaliacao.ReadOnly = true;
            this.DgvAvaliacao.RowHeadersWidth = 8;
            this.DgvAvaliacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAvaliacao.Size = new System.Drawing.Size(412, 150);
            this.DgvAvaliacao.TabIndex = 5;
            this.DgvAvaliacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAvaliacao_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 22;
            // 
            // AtividadeDescricao
            // 
            this.AtividadeDescricao.DataPropertyName = "AtividadeDescricao";
            this.AtividadeDescricao.HeaderText = "Atividade";
            this.AtividadeDescricao.Name = "AtividadeDescricao";
            this.AtividadeDescricao.ReadOnly = true;
            this.AtividadeDescricao.Width = 335;
            // 
            // Notaa
            // 
            this.Notaa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Notaa.DataPropertyName = "Nota";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Notaa.DefaultCellStyle = dataGridViewCellStyle2;
            this.Notaa.HeaderText = "Nota";
            this.Notaa.Name = "Notaa";
            this.Notaa.ReadOnly = true;
            this.Notaa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Notaa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Notaa.Width = 36;
            // 
            // DataCompetencia
            // 
            this.DataCompetencia.DataPropertyName = "DataCompetencia";
            this.DataCompetencia.HeaderText = "Competencia";
            this.DataCompetencia.Name = "DataCompetencia";
            this.DataCompetencia.ReadOnly = true;
            this.DataCompetencia.Visible = false;
            this.DataCompetencia.Width = 94;
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.DataPropertyName = "NomeEmpresa";
            this.NomeEmpresa.HeaderText = "Empresa";
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.ReadOnly = true;
            this.NomeEmpresa.Visible = false;
            this.NomeEmpresa.Width = 73;
            // 
            // IdEmpregadoo
            // 
            this.IdEmpregadoo.DataPropertyName = "IdEmpregado";
            this.IdEmpregadoo.HeaderText = "IdEmpregado";
            this.IdEmpregadoo.Name = "IdEmpregadoo";
            this.IdEmpregadoo.ReadOnly = true;
            this.IdEmpregadoo.Visible = false;
            this.IdEmpregadoo.Width = 95;
            // 
            // NomeEmpregado
            // 
            this.NomeEmpregado.DataPropertyName = "NomeEmpregado";
            this.NomeEmpregado.HeaderText = "Empregado";
            this.NomeEmpregado.Name = "NomeEmpregado";
            this.NomeEmpregado.ReadOnly = true;
            this.NomeEmpregado.Visible = false;
            this.NomeEmpregado.Width = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Avaliação";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(349, 12);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 7;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(349, 41);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 7;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(349, 70);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(12, 371);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(34, 13);
            this.LblInfo.TabIndex = 8;
            this.LblInfo.Text = "Info...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Atividade";
            // 
            // CbxAtividade
            // 
            this.CbxAtividade.DisplayMember = "Descricao";
            this.CbxAtividade.FormattingEnabled = true;
            this.CbxAtividade.Location = new System.Drawing.Point(12, 152);
            this.CbxAtividade.Name = "CbxAtividade";
            this.CbxAtividade.Size = new System.Drawing.Size(232, 21);
            this.CbxAtividade.TabIndex = 10;
            this.CbxAtividade.ValueMember = "Descricao";
            this.CbxAtividade.SelectedIndexChanged += new System.EventHandler(this.CbxAtividade_SelectedIndexChanged);
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(250, 152);
            this.TxtNota.MaxLength = 6;
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(76, 20);
            this.TxtNota.TabIndex = 11;
            this.TxtNota.Text = "0,00";
            this.TxtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNota.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            this.TxtNota.Enter += new System.EventHandler(this.TxtValor_Enter);
            this.TxtNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValor_KeyDown);
            this.TxtNota.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dois cliques sobre o item para alterar ou excluir";
            // 
            // FrmCadastroAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.CbxAtividade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvAvaliacao);
            this.Controls.Add(this.CbxEmpregado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmCadastroAvaliacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Avaliação";
            this.Load += new System.EventHandler(this.FrmCadastroAvaliacao_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCadastroAvaliacao_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvaliacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.DataGridView DgvAvaliacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxAtividade;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtividadeDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpregadoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpregado;
        private System.Windows.Forms.Label label1;
    }
}