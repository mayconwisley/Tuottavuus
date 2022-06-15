namespace Tuottavuus
{
    partial class FrmCadastroEmpregado
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.CbxAtivo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvEmpregado = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartamentoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblInfoEmpregado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxDepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpregado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Location = new System.Drawing.Point(14, 123);
            this.TxtNome.MaxLength = 255;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(281, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // CbxAtivo
            // 
            this.CbxAtivo.AutoSize = true;
            this.CbxAtivo.Checked = true;
            this.CbxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxAtivo.Location = new System.Drawing.Point(17, 149);
            this.CbxAtivo.Name = "CbxAtivo";
            this.CbxAtivo.Size = new System.Drawing.Size(50, 17);
            this.CbxAtivo.TabIndex = 4;
            this.CbxAtivo.Text = "Ativo";
            this.CbxAtivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.IntegralHeight = false;
            this.CbxEmpresa.Location = new System.Drawing.Point(14, 27);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(281, 21);
            this.CbxEmpresa.TabIndex = 1;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(314, 25);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 4;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(314, 54);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(314, 83);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvEmpregado
            // 
            this.DgvEmpregado.AllowUserToAddRows = false;
            this.DgvEmpregado.AllowUserToDeleteRows = false;
            this.DgvEmpregado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvEmpregado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvEmpregado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvEmpregado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvEmpregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpregado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DepartamentoDescricao,
            this.Ativo,
            this.NomeEmpresa});
            this.DgvEmpregado.Location = new System.Drawing.Point(14, 195);
            this.DgvEmpregado.MultiSelect = false;
            this.DgvEmpregado.Name = "DgvEmpregado";
            this.DgvEmpregado.ReadOnly = true;
            this.DgvEmpregado.RowHeadersWidth = 5;
            this.DgvEmpregado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpregado.Size = new System.Drawing.Size(375, 150);
            this.DgvEmpregado.TabIndex = 7;
            this.DgvEmpregado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpregado_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // DepartamentoDescricao
            // 
            this.DepartamentoDescricao.DataPropertyName = "DepartamentoDescricao";
            this.DepartamentoDescricao.HeaderText = "Departamento";
            this.DepartamentoDescricao.Name = "DepartamentoDescricao";
            this.DepartamentoDescricao.ReadOnly = true;
            this.DepartamentoDescricao.Width = 99;
            // 
            // Ativo
            // 
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
            // NomeEmpresa
            // 
            this.NomeEmpresa.DataPropertyName = "EmpresaNome";
            this.NomeEmpresa.HeaderText = "Empresa";
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.ReadOnly = true;
            this.NomeEmpresa.Width = 73;
            // 
            // LblInfoEmpregado
            // 
            this.LblInfoEmpregado.AutoSize = true;
            this.LblInfoEmpregado.Location = new System.Drawing.Point(14, 179);
            this.LblInfoEmpregado.Name = "LblInfoEmpregado";
            this.LblInfoEmpregado.Size = new System.Drawing.Size(148, 13);
            this.LblInfoEmpregado.TabIndex = 8;
            this.LblInfoEmpregado.Text = "Empregados cadastrados - 00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departamento";
            // 
            // CbxDepartamento
            // 
            this.CbxDepartamento.DisplayMember = "Descricao";
            this.CbxDepartamento.FormattingEnabled = true;
            this.CbxDepartamento.IntegralHeight = false;
            this.CbxDepartamento.Location = new System.Drawing.Point(14, 70);
            this.CbxDepartamento.Name = "CbxDepartamento";
            this.CbxDepartamento.Size = new System.Drawing.Size(281, 21);
            this.CbxDepartamento.TabIndex = 10;
            this.CbxDepartamento.ValueMember = "Id";
            this.CbxDepartamento.SelectedIndexChanged += new System.EventHandler(this.CbxDepartamento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dois cliques sobre o item para alterar ou excluir";
            // 
            // FrmCadastroEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblInfoEmpregado);
            this.Controls.Add(this.DgvEmpregado);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxAtivo);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCadastroEmpregado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Empregado";
            this.Load += new System.EventHandler(this.FrmCadastroEmpregado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpregado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.CheckBox CbxAtivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvEmpregado;
        private System.Windows.Forms.Label LblInfoEmpregado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartamentoDescricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpresa;
        private System.Windows.Forms.Label label2;
    }
}