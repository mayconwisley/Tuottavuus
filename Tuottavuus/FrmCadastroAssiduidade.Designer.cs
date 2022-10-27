namespace Tuottavuus
{
    partial class FrmCadastroAssiduidade
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
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvAssiduidade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAtrasoFalta = new System.Windows.Forms.TextBox();
            this.LblInfoAssiduidade = new System.Windows.Forms.Label();
            this.LblInfoCodigoAtendente = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtrasoFalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssiduidade)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.Location = new System.Drawing.Point(13, 91);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(299, 21);
            this.CbxEmpregado.TabIndex = 1;
            this.CbxEmpregado.ValueMember = "Id";
            this.CbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(13, 51);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(299, 21);
            this.CbxEmpresa.TabIndex = 0;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empregado";
            // 
            // LblCompetencia
            // 
            this.LblCompetencia.AutoSize = true;
            this.LblCompetencia.Location = new System.Drawing.Point(13, 10);
            this.LblCompetencia.Name = "LblCompetencia";
            this.LblCompetencia.Size = new System.Drawing.Size(116, 13);
            this.LblCompetencia.TabIndex = 18;
            this.LblCompetencia.Text = "Competência: 00/0000";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(349, 83);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(104, 29);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(349, 48);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(104, 29);
            this.BtnAlterar.TabIndex = 4;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(349, 13);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(104, 29);
            this.BtnGravar.TabIndex = 3;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Empresa";
            // 
            // DgvAssiduidade
            // 
            this.DgvAssiduidade.AllowUserToAddRows = false;
            this.DgvAssiduidade.AllowUserToDeleteRows = false;
            this.DgvAssiduidade.AllowUserToOrderColumns = true;
            this.DgvAssiduidade.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAssiduidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvAssiduidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssiduidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Competencia,
            this.Id_Empresa,
            this.Id_Empregado,
            this.Nome,
            this.AtrasoFalta});
            this.DgvAssiduidade.Location = new System.Drawing.Point(13, 182);
            this.DgvAssiduidade.MultiSelect = false;
            this.DgvAssiduidade.Name = "DgvAssiduidade";
            this.DgvAssiduidade.ReadOnly = true;
            this.DgvAssiduidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAssiduidade.Size = new System.Drawing.Size(440, 142);
            this.DgvAssiduidade.TabIndex = 6;
            this.DgvAssiduidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssiduidade_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Atraso/Falta";
            // 
            // TxtAtrasoFalta
            // 
            this.TxtAtrasoFalta.Location = new System.Drawing.Point(13, 131);
            this.TxtAtrasoFalta.Name = "TxtAtrasoFalta";
            this.TxtAtrasoFalta.Size = new System.Drawing.Size(65, 20);
            this.TxtAtrasoFalta.TabIndex = 2;
            this.TxtAtrasoFalta.Text = "0";
            this.TxtAtrasoFalta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblInfoAssiduidade
            // 
            this.LblInfoAssiduidade.AutoSize = true;
            this.LblInfoAssiduidade.Location = new System.Drawing.Point(13, 166);
            this.LblInfoAssiduidade.Name = "LblInfoAssiduidade";
            this.LblInfoAssiduidade.Size = new System.Drawing.Size(85, 13);
            this.LblInfoAssiduidade.TabIndex = 36;
            this.LblInfoAssiduidade.Text = "Assiduidade - 00";
            // 
            // LblInfoCodigoAtendente
            // 
            this.LblInfoCodigoAtendente.AutoSize = true;
            this.LblInfoCodigoAtendente.Location = new System.Drawing.Point(196, 115);
            this.LblInfoCodigoAtendente.Name = "LblInfoCodigoAtendente";
            this.LblInfoCodigoAtendente.Size = new System.Drawing.Size(116, 13);
            this.LblInfoCodigoAtendente.TabIndex = 37;
            this.LblInfoCodigoAtendente.Text = "Codigo Atendente: 000";
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
            this.Id_Competencia.HeaderText = "Id_Competencia";
            this.Id_Competencia.Name = "Id_Competencia";
            this.Id_Competencia.ReadOnly = true;
            this.Id_Competencia.Visible = false;
            // 
            // Id_Empresa
            // 
            this.Id_Empresa.DataPropertyName = "Id_Empresa";
            this.Id_Empresa.HeaderText = "Id_Empresa";
            this.Id_Empresa.Name = "Id_Empresa";
            this.Id_Empresa.ReadOnly = true;
            this.Id_Empresa.Visible = false;
            // 
            // Id_Empregado
            // 
            this.Id_Empregado.DataPropertyName = "Id_Empregado";
            this.Id_Empregado.HeaderText = "Id_Empregado";
            this.Id_Empregado.Name = "Id_Empregado";
            this.Id_Empregado.ReadOnly = true;
            this.Id_Empregado.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // AtrasoFalta
            // 
            this.AtrasoFalta.DataPropertyName = "AtrasoFalta";
            this.AtrasoFalta.HeaderText = "Atraso/Falta";
            this.AtrasoFalta.Name = "AtrasoFalta";
            this.AtrasoFalta.ReadOnly = true;
            // 
            // FrmCadastroAssiduidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 335);
            this.Controls.Add(this.LblInfoCodigoAtendente);
            this.Controls.Add(this.LblInfoAssiduidade);
            this.Controls.Add(this.TxtAtrasoFalta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvAssiduidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.CbxEmpregado);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroAssiduidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Assiduidade";
            this.Load += new System.EventHandler(this.FrmCadastroAssiduidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssiduidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvAssiduidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAtrasoFalta;
        private System.Windows.Forms.Label LblInfoAssiduidade;
        private System.Windows.Forms.Label LblInfoCodigoAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtrasoFalta;
    }
}