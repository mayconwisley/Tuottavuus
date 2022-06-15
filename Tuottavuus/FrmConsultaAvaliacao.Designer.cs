namespace Tuottavuus
{
    partial class FrmConsultaAvaliacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxEmpregado = new System.Windows.Forms.ComboBox();
            this.DgvAvaliacao = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtividadeDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpregadoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblMedia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvaliacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competência";
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(15, 28);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(66, 20);
            this.MktCompetencia.TabIndex = 1;
            this.MktCompetencia.ValidatingType = typeof(System.DateTime);
            this.MktCompetencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MktCompetencia_KeyDown);
            this.MktCompetencia.Leave += new System.EventHandler(this.MktCompetencia_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.IntegralHeight = false;
            this.CbxEmpresa.Location = new System.Drawing.Point(15, 67);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(397, 21);
            this.CbxEmpresa.TabIndex = 3;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empregado";
            // 
            // CbxEmpregado
            // 
            this.CbxEmpregado.DisplayMember = "Nome";
            this.CbxEmpregado.FormattingEnabled = true;
            this.CbxEmpregado.IntegralHeight = false;
            this.CbxEmpregado.Location = new System.Drawing.Point(15, 107);
            this.CbxEmpregado.Name = "CbxEmpregado";
            this.CbxEmpregado.Size = new System.Drawing.Size(397, 21);
            this.CbxEmpregado.TabIndex = 5;
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
            this.Nota,
            this.DataCompetencia,
            this.NomeEmpresa,
            this.IdEmpregadoo,
            this.NomeEmpregado});
            this.DgvAvaliacao.Location = new System.Drawing.Point(15, 152);
            this.DgvAvaliacao.MultiSelect = false;
            this.DgvAvaliacao.Name = "DgvAvaliacao";
            this.DgvAvaliacao.ReadOnly = true;
            this.DgvAvaliacao.RowHeadersWidth = 5;
            this.DgvAvaliacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAvaliacao.Size = new System.Drawing.Size(397, 210);
            this.DgvAvaliacao.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // AtividadeDescricao
            // 
            this.AtividadeDescricao.DataPropertyName = "AtividadeDescricao";
            this.AtividadeDescricao.HeaderText = "Atividade";
            this.AtividadeDescricao.Name = "AtividadeDescricao";
            this.AtividadeDescricao.ReadOnly = true;
            this.AtividadeDescricao.Width = 300;
            // 
            // Nota
            // 
            this.Nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nota.DataPropertyName = "Nota";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Nota.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 55;
            // 
            // DataCompetencia
            // 
            this.DataCompetencia.DataPropertyName = "DataCompetencia";
            this.DataCompetencia.HeaderText = "DataCompetencia";
            this.DataCompetencia.Name = "DataCompetencia";
            this.DataCompetencia.ReadOnly = true;
            this.DataCompetencia.Visible = false;
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.DataPropertyName = "NomeEmpresa";
            this.NomeEmpresa.HeaderText = "NomeEmpresa";
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.ReadOnly = true;
            this.NomeEmpresa.Visible = false;
            // 
            // IdEmpregadoo
            // 
            this.IdEmpregadoo.DataPropertyName = "IdEmpregado";
            this.IdEmpregadoo.HeaderText = "IdEmpregado";
            this.IdEmpregadoo.Name = "IdEmpregadoo";
            this.IdEmpregadoo.ReadOnly = true;
            this.IdEmpregadoo.Visible = false;
            // 
            // NomeEmpregado
            // 
            this.NomeEmpregado.DataPropertyName = "NomeEmpregado";
            this.NomeEmpregado.HeaderText = "NomeEmpregado";
            this.NomeEmpregado.Name = "NomeEmpregado";
            this.NomeEmpregado.ReadOnly = true;
            this.NomeEmpregado.Visible = false;
            // 
            // LblMedia
            // 
            this.LblMedia.AutoSize = true;
            this.LblMedia.Location = new System.Drawing.Point(15, 365);
            this.LblMedia.Name = "LblMedia";
            this.LblMedia.Size = new System.Drawing.Size(63, 13);
            this.LblMedia.TabIndex = 9;
            this.LblMedia.Text = "Média: 0,00";
            // 
            // FrmConsultaAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 387);
            this.Controls.Add(this.LblMedia);
            this.Controls.Add(this.DgvAvaliacao);
            this.Controls.Add(this.CbxEmpregado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaAvaliacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Avaliação";
            this.Load += new System.EventHandler(this.FrmConsultaAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvaliacao)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvAvaliacao;
        private System.Windows.Forms.Label LblMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtividadeDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpregadoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpregado;
    }
}