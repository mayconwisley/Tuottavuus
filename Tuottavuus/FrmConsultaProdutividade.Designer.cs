namespace Tuottavuus
{
    partial class FrmConsultaProdutividade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.LblInfoGeral = new System.Windows.Forms.Label();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblValorBase = new System.Windows.Forms.Label();
            this.DgvCalculo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empregadoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Media_Avaliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtividade_Valorr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtividade_Reflexoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Geral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Apurados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fer_Dom_Aputadoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalculo)).BeginInit();
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
            this.MktCompetencia.ValidatingType = typeof(System.DateTime);
            this.MktCompetencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MktCompetencia_KeyDown);
            this.MktCompetencia.Leave += new System.EventHandler(this.MktCompetencia_Leave);
            // 
            // LblInfoGeral
            // 
            this.LblInfoGeral.AutoSize = true;
            this.LblInfoGeral.Location = new System.Drawing.Point(12, 439);
            this.LblInfoGeral.Name = "LblInfoGeral";
            this.LblInfoGeral.Size = new System.Drawing.Size(135, 13);
            this.LblInfoGeral.TabIndex = 14;
            this.LblInfoGeral.Text = "Total: 0,00 - Reflexos: 0,00";
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.IntegralHeight = false;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 114);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(372, 21);
            this.CbxEmpresa.TabIndex = 13;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Empresa";
            // 
            // LblValorBase
            // 
            this.LblValorBase.AutoSize = true;
            this.LblValorBase.Location = new System.Drawing.Point(12, 70);
            this.LblValorBase.Name = "LblValorBase";
            this.LblValorBase.Size = new System.Drawing.Size(85, 13);
            this.LblValorBase.TabIndex = 11;
            this.LblValorBase.Text = "Valor Base: 0,00";
            // 
            // DgvCalculo
            // 
            this.DgvCalculo.AllowUserToAddRows = false;
            this.DgvCalculo.AllowUserToDeleteRows = false;
            this.DgvCalculo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCalculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCalculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Empregadoo,
            this.Nome,
            this.Media_Avaliacao,
            this.Produtividade_Valorr,
            this.Produtividade_Reflexoo,
            this.Total_Geral,
            this.Dias_Apurados,
            this.Fer_Dom_Aputadoss});
            this.DgvCalculo.Location = new System.Drawing.Point(12, 149);
            this.DgvCalculo.MultiSelect = false;
            this.DgvCalculo.Name = "DgvCalculo";
            this.DgvCalculo.ReadOnly = true;
            this.DgvCalculo.RowHeadersWidth = 8;
            this.DgvCalculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCalculo.Size = new System.Drawing.Size(637, 287);
            this.DgvCalculo.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // Id_Empregadoo
            // 
            this.Id_Empregadoo.DataPropertyName = "Id_Empregado";
            this.Id_Empregadoo.HeaderText = "Id_Empregado";
            this.Id_Empregadoo.Name = "Id_Empregadoo";
            this.Id_Empregadoo.ReadOnly = true;
            this.Id_Empregadoo.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 302;
            // 
            // Media_Avaliacao
            // 
            this.Media_Avaliacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Media_Avaliacao.DataPropertyName = "Media_Avaliacao";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Media_Avaliacao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Media_Avaliacao.HeaderText = "Média Avaliação";
            this.Media_Avaliacao.Name = "Media_Avaliacao";
            this.Media_Avaliacao.ReadOnly = true;
            this.Media_Avaliacao.Width = 111;
            // 
            // Produtividade_Valorr
            // 
            this.Produtividade_Valorr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Produtividade_Valorr.DataPropertyName = "Produtividade_Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Produtividade_Valorr.DefaultCellStyle = dataGridViewCellStyle2;
            this.Produtividade_Valorr.HeaderText = "Valor";
            this.Produtividade_Valorr.Name = "Produtividade_Valorr";
            this.Produtividade_Valorr.ReadOnly = true;
            this.Produtividade_Valorr.Width = 56;
            // 
            // Produtividade_Reflexoo
            // 
            this.Produtividade_Reflexoo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Produtividade_Reflexoo.DataPropertyName = "Produtividade_Reflexo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Produtividade_Reflexoo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Produtividade_Reflexoo.HeaderText = "Reflexo";
            this.Produtividade_Reflexoo.Name = "Produtividade_Reflexoo";
            this.Produtividade_Reflexoo.ReadOnly = true;
            this.Produtividade_Reflexoo.Width = 68;
            // 
            // Total_Geral
            // 
            this.Total_Geral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total_Geral.DataPropertyName = "Total_Geral";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.Total_Geral.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total_Geral.HeaderText = "Total Geral";
            this.Total_Geral.Name = "Total_Geral";
            this.Total_Geral.ReadOnly = true;
            this.Total_Geral.Width = 84;
            // 
            // Dias_Apurados
            // 
            this.Dias_Apurados.DataPropertyName = "Dias_Apurados";
            this.Dias_Apurados.HeaderText = "Dias_Apurados";
            this.Dias_Apurados.Name = "Dias_Apurados";
            this.Dias_Apurados.ReadOnly = true;
            this.Dias_Apurados.Visible = false;
            this.Dias_Apurados.Width = 104;
            // 
            // Fer_Dom_Aputadoss
            // 
            this.Fer_Dom_Aputadoss.DataPropertyName = "Fer_Dom_Apurados";
            this.Fer_Dom_Aputadoss.HeaderText = "Domingo_e_Feriados";
            this.Fer_Dom_Aputadoss.Name = "Fer_Dom_Aputadoss";
            this.Fer_Dom_Aputadoss.ReadOnly = true;
            this.Fer_Dom_Aputadoss.Visible = false;
            this.Fer_Dom_Aputadoss.Width = 132;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(12, 48);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(214, 13);
            this.LblInfo.TabIndex = 9;
            this.LblInfo.Text = "Dias Uteis: 00 - Domingos: 00 - Feriados: 00";
            // 
            // FrmConsultaProdutividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 494);
            this.Controls.Add(this.LblInfoGeral);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblValorBase);
            this.Controls.Add(this.DgvCalculo);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaProdutividade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produtividade";
            this.Load += new System.EventHandler(this.FrmConsultaProdutividade_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmConsultaProdutividade_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label LblInfoGeral;
        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblValorBase;
        private System.Windows.Forms.DataGridView DgvCalculo;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empregadoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Media_Avaliacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtividade_Valorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtividade_Reflexoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Geral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Apurados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fer_Dom_Aputadoss;
    }
}