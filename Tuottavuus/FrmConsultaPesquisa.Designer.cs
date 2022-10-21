namespace Tuottavuus
{
    partial class FrmConsultaPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.DgvPesquisa = new System.Windows.Forms.DataGridView();
            this.LblInfoPesquisa = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaConceito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvaliacaoMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competência";
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(10, 26);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(69, 20);
            this.MktCompetencia.TabIndex = 1;
            this.MktCompetencia.Leave += new System.EventHandler(this.MktCompetencia_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(10, 78);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(276, 21);
            this.CbxEmpresa.TabIndex = 3;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
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
            this.CodigoAtendente,
            this.NomeAtendente,
            this.QtdChamado,
            this.NotaConceito,
            this.AvaliacaoMedia});
            this.DgvPesquisa.Location = new System.Drawing.Point(10, 127);
            this.DgvPesquisa.MultiSelect = false;
            this.DgvPesquisa.Name = "DgvPesquisa";
            this.DgvPesquisa.ReadOnly = true;
            this.DgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPesquisa.Size = new System.Drawing.Size(693, 297);
            this.DgvPesquisa.TabIndex = 7;
            // 
            // LblInfoPesquisa
            // 
            this.LblInfoPesquisa.AutoSize = true;
            this.LblInfoPesquisa.Location = new System.Drawing.Point(10, 111);
            this.LblInfoPesquisa.Name = "LblInfoPesquisa";
            this.LblInfoPesquisa.Size = new System.Drawing.Size(71, 13);
            this.LblInfoPesquisa.TabIndex = 8;
            this.LblInfoPesquisa.Text = "Pesquisa - 00";
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
            // CodigoAtendente
            // 
            this.CodigoAtendente.DataPropertyName = "CodigoAtendente";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.CodigoAtendente.DefaultCellStyle = dataGridViewCellStyle5;
            this.CodigoAtendente.HeaderText = "Código Atendente";
            this.CodigoAtendente.Name = "CodigoAtendente";
            this.CodigoAtendente.ReadOnly = true;
            // 
            // NomeAtendente
            // 
            this.NomeAtendente.DataPropertyName = "NomeAtendente";
            this.NomeAtendente.HeaderText = "Nome Atendente";
            this.NomeAtendente.Name = "NomeAtendente";
            this.NomeAtendente.ReadOnly = true;
            this.NomeAtendente.Width = 250;
            // 
            // QtdChamado
            // 
            this.QtdChamado.DataPropertyName = "QtdChamado";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.QtdChamado.DefaultCellStyle = dataGridViewCellStyle6;
            this.QtdChamado.HeaderText = "Qtd. Chamado";
            this.QtdChamado.Name = "QtdChamado";
            this.QtdChamado.ReadOnly = true;
            // 
            // NotaConceito
            // 
            this.NotaConceito.DataPropertyName = "NotaConceito";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.NotaConceito.DefaultCellStyle = dataGridViewCellStyle7;
            this.NotaConceito.HeaderText = "Nota";
            this.NotaConceito.Name = "NotaConceito";
            this.NotaConceito.ReadOnly = true;
            // 
            // AvaliacaoMedia
            // 
            this.AvaliacaoMedia.DataPropertyName = "AvaliacaoMedia";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.AvaliacaoMedia.DefaultCellStyle = dataGridViewCellStyle8;
            this.AvaliacaoMedia.HeaderText = "Avalição Média";
            this.AvaliacaoMedia.Name = "AvaliacaoMedia";
            this.AvaliacaoMedia.ReadOnly = true;
            // 
            // FrmPesquisaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 435);
            this.Controls.Add(this.LblInfoPesquisa);
            this.Controls.Add(this.DgvPesquisa);
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
        private System.Windows.Forms.DataGridView DgvPesquisa;
        private System.Windows.Forms.Label LblInfoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaConceito;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvaliacaoMedia;
    }
}