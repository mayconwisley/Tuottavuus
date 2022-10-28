namespace Tuottavuus
{
    partial class FrmCadastroIndicador
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblInfoIndicador = new System.Windows.Forms.Label();
            this.DgvIndicadors = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.CbAtivo = new System.Windows.Forms.CheckBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbPesquisa = new System.Windows.Forms.CheckBox();
            this.CbChamado = new System.Windows.Forms.CheckBox();
            this.CbAssiduidade = new System.Windows.Forms.CheckBox();
            this.CbCaptura = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PesquisaIndicador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Chamado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Assiduidade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Captura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIndicadors)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dois cliques sobre o item para alterar ou excluir";
            // 
            // LblInfoIndicador
            // 
            this.LblInfoIndicador.AutoSize = true;
            this.LblInfoIndicador.Location = new System.Drawing.Point(12, 105);
            this.LblInfoIndicador.Name = "LblInfoIndicador";
            this.LblInfoIndicador.Size = new System.Drawing.Size(83, 13);
            this.LblInfoIndicador.TabIndex = 14;
            this.LblInfoIndicador.Text = "Indicadores - 00";
            // 
            // DgvIndicadors
            // 
            this.DgvIndicadors.AllowUserToAddRows = false;
            this.DgvIndicadors.AllowUserToDeleteRows = false;
            this.DgvIndicadors.AllowUserToOrderColumns = true;
            this.DgvIndicadors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvIndicadors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvIndicadors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIndicadors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Ativo,
            this.PesquisaIndicador,
            this.Chamado,
            this.Assiduidade,
            this.Captura});
            this.DgvIndicadors.Location = new System.Drawing.Point(12, 121);
            this.DgvIndicadors.MultiSelect = false;
            this.DgvIndicadors.Name = "DgvIndicadors";
            this.DgvIndicadors.ReadOnly = true;
            this.DgvIndicadors.RowHeadersWidth = 8;
            this.DgvIndicadors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIndicadors.Size = new System.Drawing.Size(296, 128);
            this.DgvIndicadors.TabIndex = 8;
            this.DgvIndicadors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIndicadors_CellDoubleClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(204, 74);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(123, 74);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 6;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(42, 74);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 5;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // CbAtivo
            // 
            this.CbAtivo.AutoSize = true;
            this.CbAtivo.Checked = true;
            this.CbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAtivo.Location = new System.Drawing.Point(233, 28);
            this.CbAtivo.Name = "CbAtivo";
            this.CbAtivo.Size = new System.Drawing.Size(50, 17);
            this.CbAtivo.TabIndex = 1;
            this.CbAtivo.Text = "Ativo";
            this.CbAtivo.UseVisualStyleBackColor = true;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescricao.Location = new System.Drawing.Point(12, 25);
            this.TxtDescricao.MaxLength = 255;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(215, 20);
            this.TxtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição";
            // 
            // CbPesquisa
            // 
            this.CbPesquisa.AutoSize = true;
            this.CbPesquisa.Location = new System.Drawing.Point(12, 51);
            this.CbPesquisa.Name = "CbPesquisa";
            this.CbPesquisa.Size = new System.Drawing.Size(69, 17);
            this.CbPesquisa.TabIndex = 2;
            this.CbPesquisa.Text = "Pesquisa";
            this.CbPesquisa.UseVisualStyleBackColor = true;
            // 
            // CbChamado
            // 
            this.CbChamado.AutoSize = true;
            this.CbChamado.Location = new System.Drawing.Point(87, 51);
            this.CbChamado.Name = "CbChamado";
            this.CbChamado.Size = new System.Drawing.Size(71, 17);
            this.CbChamado.TabIndex = 3;
            this.CbChamado.Text = "Chamado";
            this.CbChamado.UseVisualStyleBackColor = true;
            // 
            // CbAssiduidade
            // 
            this.CbAssiduidade.AutoSize = true;
            this.CbAssiduidade.Location = new System.Drawing.Point(233, 51);
            this.CbAssiduidade.Name = "CbAssiduidade";
            this.CbAssiduidade.Size = new System.Drawing.Size(83, 17);
            this.CbAssiduidade.TabIndex = 4;
            this.CbAssiduidade.Text = "Assiduidade";
            this.CbAssiduidade.UseVisualStyleBackColor = true;
            // 
            // CbCaptura
            // 
            this.CbCaptura.AutoSize = true;
            this.CbCaptura.Location = new System.Drawing.Point(164, 51);
            this.CbCaptura.Name = "CbCaptura";
            this.CbCaptura.Size = new System.Drawing.Size(63, 17);
            this.CbCaptura.TabIndex = 16;
            this.CbCaptura.Text = "Captura";
            this.CbCaptura.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 190;
            // 
            // Ativo
            // 
            this.Ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.FalseValue = "Não";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ativo.TrueValue = "Sim";
            this.Ativo.Width = 56;
            // 
            // PesquisaIndicador
            // 
            this.PesquisaIndicador.DataPropertyName = "Pesquisa";
            this.PesquisaIndicador.HeaderText = "Pesquisa";
            this.PesquisaIndicador.Name = "PesquisaIndicador";
            this.PesquisaIndicador.ReadOnly = true;
            // 
            // Chamado
            // 
            this.Chamado.DataPropertyName = "Chamado";
            this.Chamado.HeaderText = "Chamado";
            this.Chamado.Name = "Chamado";
            this.Chamado.ReadOnly = true;
            this.Chamado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chamado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Assiduidade
            // 
            this.Assiduidade.DataPropertyName = "Assiduidade";
            this.Assiduidade.HeaderText = "Assiduidade";
            this.Assiduidade.Name = "Assiduidade";
            this.Assiduidade.ReadOnly = true;
            this.Assiduidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Assiduidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Captura
            // 
            this.Captura.DataPropertyName = "Captura";
            this.Captura.HeaderText = "Captura";
            this.Captura.Name = "Captura";
            this.Captura.ReadOnly = true;
            // 
            // FrmCadastroIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 282);
            this.Controls.Add(this.CbCaptura);
            this.Controls.Add(this.CbAssiduidade);
            this.Controls.Add(this.CbChamado);
            this.Controls.Add(this.CbPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblInfoIndicador);
            this.Controls.Add(this.DgvIndicadors);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.CbAtivo);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroIndicador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Indicador";
            this.Load += new System.EventHandler(this.FrmCadastroIndicador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIndicadors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblInfoIndicador;
        private System.Windows.Forms.DataGridView DgvIndicadors;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.CheckBox CbAtivo;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbPesquisa;
        private System.Windows.Forms.CheckBox CbChamado;
        private System.Windows.Forms.CheckBox CbAssiduidade;
        private System.Windows.Forms.CheckBox CbCaptura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PesquisaIndicador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chamado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Assiduidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Captura;
    }
}