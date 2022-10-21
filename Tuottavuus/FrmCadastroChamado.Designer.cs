namespace Tuottavuus
{
    partial class FrmCadastroChamado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblInfoCodigoAtendente = new System.Windows.Forms.Label();
            this.LblInfoChamado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvChamado = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtChamado = new System.Windows.Forms.TextBox();
            this.TxtCodGpSolucao = new System.Windows.Forms.TextBox();
            this.MktDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCompetencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescGrupoSolucao = new System.Windows.Forms.TextBox();
            this.TxtCodArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDescArea = new System.Windows.Forms.TextBox();
            this.TxtCodNatureza = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDescNatureza = new System.Windows.Forms.TextBox();
            this.TxtCodTpAtividade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDescTpAtividade = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoGrupoSolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescGrupoSolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTpAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTpAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfoCodigoAtendente
            // 
            this.LblInfoCodigoAtendente.AutoSize = true;
            this.LblInfoCodigoAtendente.Location = new System.Drawing.Point(12, 128);
            this.LblInfoCodigoAtendente.Name = "LblInfoCodigoAtendente";
            this.LblInfoCodigoAtendente.Size = new System.Drawing.Size(116, 13);
            this.LblInfoCodigoAtendente.TabIndex = 31;
            this.LblInfoCodigoAtendente.Text = "Código Atendente: 000";
            // 
            // LblInfoChamado
            // 
            this.LblInfoChamado.AutoSize = true;
            this.LblInfoChamado.Location = new System.Drawing.Point(319, 122);
            this.LblInfoChamado.Name = "LblInfoChamado";
            this.LblInfoChamado.Size = new System.Drawing.Size(78, 13);
            this.LblInfoChamado.TabIndex = 30;
            this.LblInfoChamado.Text = "Chamados - 00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Dois cliques sobre o item para alterar ou excluir";
            // 
            // DgvChamado
            // 
            this.DgvChamado.AllowUserToAddRows = false;
            this.DgvChamado.AllowUserToDeleteRows = false;
            this.DgvChamado.AllowUserToOrderColumns = true;
            this.DgvChamado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvChamado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvChamado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Competencia,
            this.Id_Empresa,
            this.Id_Empregado,
            this.DataAbertura,
            this.Chamado,
            this.CodigoAtendente,
            this.NomeAtendente,
            this.CodigoGrupoSolucao,
            this.DescGrupoSolucao,
            this.CodigoArea,
            this.DescArea,
            this.CodigoNatureza,
            this.DescNatureza,
            this.CodigoTpAtividade,
            this.DescTpAtividade});
            this.DgvChamado.Location = new System.Drawing.Point(319, 138);
            this.DgvChamado.MultiSelect = false;
            this.DgvChamado.Name = "DgvChamado";
            this.DgvChamado.ReadOnly = true;
            this.DgvChamado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvChamado.Size = new System.Drawing.Size(469, 207);
            this.DgvChamado.TabIndex = 23;
            this.DgvChamado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChamado_CellDoubleClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(684, 85);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(104, 29);
            this.BtnExcluir.TabIndex = 28;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(684, 50);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(104, 29);
            this.BtnAlterar.TabIndex = 26;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(684, 15);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(104, 29);
            this.BtnGravar.TabIndex = 24;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Chamado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Desc. Grupo Solução";
            // 
            // TxtChamado
            // 
            this.TxtChamado.Location = new System.Drawing.Point(106, 164);
            this.TxtChamado.Name = "TxtChamado";
            this.TxtChamado.Size = new System.Drawing.Size(52, 20);
            this.TxtChamado.TabIndex = 22;
            this.TxtChamado.Text = "0";
            this.TxtChamado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtCodGpSolucao
            // 
            this.TxtCodGpSolucao.Location = new System.Drawing.Point(12, 208);
            this.TxtCodGpSolucao.Name = "TxtCodGpSolucao";
            this.TxtCodGpSolucao.Size = new System.Drawing.Size(88, 20);
            this.TxtCodGpSolucao.TabIndex = 21;
            this.TxtCodGpSolucao.Text = "0";
            this.TxtCodGpSolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MktDataAbertura
            // 
            this.MktDataAbertura.Location = new System.Drawing.Point(12, 164);
            this.MktDataAbertura.Mask = "00/00/0000";
            this.MktDataAbertura.Name = "MktDataAbertura";
            this.MktDataAbertura.Size = new System.Drawing.Size(88, 20);
            this.MktDataAbertura.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data de Abertura";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.Location = new System.Drawing.Point(12, 104);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(299, 21);
            this.CbxEmpregado.TabIndex = 17;
            this.CbxEmpregado.ValueMember = "Id";
            this.CbxEmpregado.SelectedIndexChanged += new System.EventHandler(this.CbxEmpregado_SelectedIndexChanged);
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 64);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(299, 21);
            this.CbxEmpresa.TabIndex = 15;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Empregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Empresa";
            // 
            // LblCompetencia
            // 
            this.LblCompetencia.AutoSize = true;
            this.LblCompetencia.Location = new System.Drawing.Point(12, 12);
            this.LblCompetencia.Name = "LblCompetencia";
            this.LblCompetencia.Size = new System.Drawing.Size(116, 13);
            this.LblCompetencia.TabIndex = 14;
            this.LblCompetencia.Text = "Competência: 00/0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cod. Gp Solução";
            // 
            // TxtDescGrupoSolucao
            // 
            this.TxtDescGrupoSolucao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescGrupoSolucao.Location = new System.Drawing.Point(106, 208);
            this.TxtDescGrupoSolucao.Name = "TxtDescGrupoSolucao";
            this.TxtDescGrupoSolucao.Size = new System.Drawing.Size(205, 20);
            this.TxtDescGrupoSolucao.TabIndex = 33;
            // 
            // TxtCodArea
            // 
            this.TxtCodArea.Location = new System.Drawing.Point(12, 247);
            this.TxtCodArea.Name = "TxtCodArea";
            this.TxtCodArea.Size = new System.Drawing.Size(88, 20);
            this.TxtCodArea.TabIndex = 21;
            this.TxtCodArea.Text = "0";
            this.TxtCodArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Desc. Área";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Cód. Área";
            // 
            // TxtDescArea
            // 
            this.TxtDescArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescArea.Location = new System.Drawing.Point(106, 247);
            this.TxtDescArea.Name = "TxtDescArea";
            this.TxtDescArea.Size = new System.Drawing.Size(205, 20);
            this.TxtDescArea.TabIndex = 33;
            // 
            // TxtCodNatureza
            // 
            this.TxtCodNatureza.Location = new System.Drawing.Point(12, 286);
            this.TxtCodNatureza.Name = "TxtCodNatureza";
            this.TxtCodNatureza.Size = new System.Drawing.Size(88, 20);
            this.TxtCodNatureza.TabIndex = 21;
            this.TxtCodNatureza.Text = "0";
            this.TxtCodNatureza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Desc. Natureza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Cód. Natureza";
            // 
            // TxtDescNatureza
            // 
            this.TxtDescNatureza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescNatureza.Location = new System.Drawing.Point(106, 286);
            this.TxtDescNatureza.Name = "TxtDescNatureza";
            this.TxtDescNatureza.Size = new System.Drawing.Size(205, 20);
            this.TxtDescNatureza.TabIndex = 33;
            // 
            // TxtCodTpAtividade
            // 
            this.TxtCodTpAtividade.Location = new System.Drawing.Point(12, 325);
            this.TxtCodTpAtividade.Name = "TxtCodTpAtividade";
            this.TxtCodTpAtividade.Size = new System.Drawing.Size(88, 20);
            this.TxtCodTpAtividade.TabIndex = 21;
            this.TxtCodTpAtividade.Text = "0";
            this.TxtCodTpAtividade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Desc. Tp Atividade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Cód. Tp Atividade";
            // 
            // TxtDescTpAtividade
            // 
            this.TxtDescTpAtividade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescTpAtividade.Location = new System.Drawing.Point(106, 325);
            this.TxtDescTpAtividade.Name = "TxtDescTpAtividade";
            this.TxtDescTpAtividade.Size = new System.Drawing.Size(205, 20);
            this.TxtDescTpAtividade.TabIndex = 33;
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "d";
            dataGridViewCellStyle29.NullValue = null;
            this.DataAbertura.DefaultCellStyle = dataGridViewCellStyle29;
            this.DataAbertura.HeaderText = "Data Abertura";
            this.DataAbertura.Name = "DataAbertura";
            this.DataAbertura.ReadOnly = true;
            // 
            // Chamado
            // 
            this.Chamado.DataPropertyName = "Chamado";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Chamado.DefaultCellStyle = dataGridViewCellStyle30;
            this.Chamado.HeaderText = "Chamado";
            this.Chamado.Name = "Chamado";
            this.Chamado.ReadOnly = true;
            // 
            // CodigoAtendente
            // 
            this.CodigoAtendente.DataPropertyName = "CodigoAtendente";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoAtendente.DefaultCellStyle = dataGridViewCellStyle31;
            this.CodigoAtendente.HeaderText = "Cód. Atendente";
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
            // CodigoGrupoSolucao
            // 
            this.CodigoGrupoSolucao.DataPropertyName = "CodigoGrupoSolucao";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoGrupoSolucao.DefaultCellStyle = dataGridViewCellStyle32;
            this.CodigoGrupoSolucao.HeaderText = "Cód Grupo Solução";
            this.CodigoGrupoSolucao.Name = "CodigoGrupoSolucao";
            this.CodigoGrupoSolucao.ReadOnly = true;
            // 
            // DescGrupoSolucao
            // 
            this.DescGrupoSolucao.DataPropertyName = "DescGrupoSolucao";
            this.DescGrupoSolucao.HeaderText = "Desc. Grupo Solução";
            this.DescGrupoSolucao.Name = "DescGrupoSolucao";
            this.DescGrupoSolucao.ReadOnly = true;
            // 
            // CodigoArea
            // 
            this.CodigoArea.DataPropertyName = "CodigoArea";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoArea.DefaultCellStyle = dataGridViewCellStyle33;
            this.CodigoArea.HeaderText = "Cód. Área";
            this.CodigoArea.Name = "CodigoArea";
            this.CodigoArea.ReadOnly = true;
            // 
            // DescArea
            // 
            this.DescArea.DataPropertyName = "DescArea";
            this.DescArea.HeaderText = "Desc. Área";
            this.DescArea.Name = "DescArea";
            this.DescArea.ReadOnly = true;
            // 
            // CodigoNatureza
            // 
            this.CodigoNatureza.DataPropertyName = "CodigoNatureza";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoNatureza.DefaultCellStyle = dataGridViewCellStyle34;
            this.CodigoNatureza.HeaderText = "Cód. Natureza";
            this.CodigoNatureza.Name = "CodigoNatureza";
            this.CodigoNatureza.ReadOnly = true;
            // 
            // DescNatureza
            // 
            this.DescNatureza.DataPropertyName = "DescNatureza";
            this.DescNatureza.HeaderText = "Desc. Natureza";
            this.DescNatureza.Name = "DescNatureza";
            this.DescNatureza.ReadOnly = true;
            // 
            // CodigoTpAtividade
            // 
            this.CodigoTpAtividade.DataPropertyName = "CodigoTpAtividade";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoTpAtividade.DefaultCellStyle = dataGridViewCellStyle35;
            this.CodigoTpAtividade.HeaderText = "Cód. Tp Atividade";
            this.CodigoTpAtividade.Name = "CodigoTpAtividade";
            this.CodigoTpAtividade.ReadOnly = true;
            // 
            // DescTpAtividade
            // 
            this.DescTpAtividade.DataPropertyName = "DescTpAtividade";
            this.DescTpAtividade.HeaderText = "Desc. Tp Atividade";
            this.DescTpAtividade.Name = "DescTpAtividade";
            this.DescTpAtividade.ReadOnly = true;
            // 
            // FrmCadastroChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.TxtDescTpAtividade);
            this.Controls.Add(this.TxtDescNatureza);
            this.Controls.Add(this.TxtDescArea);
            this.Controls.Add(this.TxtDescGrupoSolucao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblInfoCodigoAtendente);
            this.Controls.Add(this.LblInfoChamado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvChamado);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodTpAtividade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCodNatureza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCodArea);
            this.Controls.Add(this.TxtChamado);
            this.Controls.Add(this.TxtCodGpSolucao);
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
            this.Name = "FrmCadastroChamado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Chamado";
            this.Load += new System.EventHandler(this.FrmCadastroChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfoCodigoAtendente;
        private System.Windows.Forms.Label LblInfoChamado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvChamado;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtChamado;
        private System.Windows.Forms.TextBox TxtCodGpSolucao;
        private System.Windows.Forms.MaskedTextBox MktDataAbertura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxEmpregado;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCompetencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescGrupoSolucao;
        private System.Windows.Forms.TextBox TxtCodArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDescArea;
        private System.Windows.Forms.TextBox TxtCodNatureza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDescNatureza;
        private System.Windows.Forms.TextBox TxtCodTpAtividade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDescTpAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGrupoSolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescGrupoSolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoNatureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescNatureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTpAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTpAtividade;
    }
}