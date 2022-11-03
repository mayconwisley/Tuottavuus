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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PesquisaIndicador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Chamado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Assiduidade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Captura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Feedback = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.CbAtivo = new System.Windows.Forms.CheckBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbCaptura = new System.Windows.Forms.RadioButton();
            this.RbChamado = new System.Windows.Forms.RadioButton();
            this.RbAssiduidade = new System.Windows.Forms.RadioButton();
            this.RbFeedback = new System.Windows.Forms.RadioButton();
            this.RbPesquisa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIndicadors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dois cliques sobre o item para alterar ou excluir";
            // 
            // LblInfoIndicador
            // 
            this.LblInfoIndicador.AutoSize = true;
            this.LblInfoIndicador.Location = new System.Drawing.Point(9, 189);
            this.LblInfoIndicador.Name = "LblInfoIndicador";
            this.LblInfoIndicador.Size = new System.Drawing.Size(83, 13);
            this.LblInfoIndicador.TabIndex = 13;
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
            this.Captura,
            this.Feedback});
            this.DgvIndicadors.Location = new System.Drawing.Point(9, 205);
            this.DgvIndicadors.MultiSelect = false;
            this.DgvIndicadors.Name = "DgvIndicadors";
            this.DgvIndicadors.ReadOnly = true;
            this.DgvIndicadors.RowHeadersWidth = 8;
            this.DgvIndicadors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIndicadors.Size = new System.Drawing.Size(296, 128);
            this.DgvIndicadors.TabIndex = 14;
            this.DgvIndicadors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIndicadors_CellDoubleClick);
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
            // Feedback
            // 
            this.Feedback.DataPropertyName = "Feedback";
            this.Feedback.HeaderText = "Feedback";
            this.Feedback.Name = "Feedback";
            this.Feedback.ReadOnly = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(201, 123);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 10;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(120, 123);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 9;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(39, 123);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 8;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // CbAtivo
            // 
            this.CbAtivo.AutoSize = true;
            this.CbAtivo.Checked = true;
            this.CbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAtivo.Location = new System.Drawing.Point(252, 27);
            this.CbAtivo.Name = "CbAtivo";
            this.CbAtivo.Size = new System.Drawing.Size(50, 17);
            this.CbAtivo.TabIndex = 2;
            this.CbAtivo.Text = "Ativo";
            this.CbAtivo.UseVisualStyleBackColor = true;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescricao.Location = new System.Drawing.Point(9, 25);
            this.TxtDescricao.MaxLength = 255;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(237, 20);
            this.TxtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPesquisa.Location = new System.Drawing.Point(9, 166);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(296, 20);
            this.TxtPesquisa.TabIndex = 12;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesquisa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbChamado);
            this.groupBox1.Controls.Add(this.RbPesquisa);
            this.groupBox1.Controls.Add(this.RbFeedback);
            this.groupBox1.Controls.Add(this.RbAssiduidade);
            this.groupBox1.Controls.Add(this.RbCaptura);
            this.groupBox1.Location = new System.Drawing.Point(9, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 66);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // RbCaptura
            // 
            this.RbCaptura.AutoSize = true;
            this.RbCaptura.Location = new System.Drawing.Point(95, 13);
            this.RbCaptura.Name = "RbCaptura";
            this.RbCaptura.Size = new System.Drawing.Size(62, 17);
            this.RbCaptura.TabIndex = 0;
            this.RbCaptura.TabStop = true;
            this.RbCaptura.Text = "Captura";
            this.RbCaptura.UseVisualStyleBackColor = true;
            // 
            // RbChamado
            // 
            this.RbChamado.AutoSize = true;
            this.RbChamado.Location = new System.Drawing.Point(163, 13);
            this.RbChamado.Name = "RbChamado";
            this.RbChamado.Size = new System.Drawing.Size(70, 17);
            this.RbChamado.TabIndex = 0;
            this.RbChamado.TabStop = true;
            this.RbChamado.Text = "Chamado";
            this.RbChamado.UseVisualStyleBackColor = true;
            // 
            // RbAssiduidade
            // 
            this.RbAssiduidade.AutoSize = true;
            this.RbAssiduidade.Location = new System.Drawing.Point(7, 13);
            this.RbAssiduidade.Name = "RbAssiduidade";
            this.RbAssiduidade.Size = new System.Drawing.Size(82, 17);
            this.RbAssiduidade.TabIndex = 0;
            this.RbAssiduidade.TabStop = true;
            this.RbAssiduidade.Text = "Assiduidade";
            this.RbAssiduidade.UseVisualStyleBackColor = true;
            // 
            // RbFeedback
            // 
            this.RbFeedback.AutoSize = true;
            this.RbFeedback.Location = new System.Drawing.Point(7, 36);
            this.RbFeedback.Name = "RbFeedback";
            this.RbFeedback.Size = new System.Drawing.Size(73, 17);
            this.RbFeedback.TabIndex = 0;
            this.RbFeedback.TabStop = true;
            this.RbFeedback.Text = "Feedback";
            this.RbFeedback.UseVisualStyleBackColor = true;
            // 
            // RbPesquisa
            // 
            this.RbPesquisa.AutoSize = true;
            this.RbPesquisa.Location = new System.Drawing.Point(95, 36);
            this.RbPesquisa.Name = "RbPesquisa";
            this.RbPesquisa.Size = new System.Drawing.Size(68, 17);
            this.RbPesquisa.TabIndex = 0;
            this.RbPesquisa.TabStop = true;
            this.RbPesquisa.Text = "Pesquisa";
            this.RbPesquisa.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPesquisa);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PesquisaIndicador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chamado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Assiduidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Captura;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Feedback;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbChamado;
        private System.Windows.Forms.RadioButton RbPesquisa;
        private System.Windows.Forms.RadioButton RbFeedback;
        private System.Windows.Forms.RadioButton RbAssiduidade;
        private System.Windows.Forms.RadioButton RbCaptura;
    }
}