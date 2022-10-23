namespace Tuottavuus
{
    partial class FrmConsultaChamado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbxEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTotalChamados = new System.Windows.Forms.DataGridView();
            this.LblInfoTotalChamado = new System.Windows.Forms.Label();
            this.DgvTotalChamadosCap = new System.Windows.Forms.DataGridView();
            this.LblInfoTotalCaptura = new System.Windows.Forms.Label();
            this.DgvTotalChamadoFeed = new System.Windows.Forms.DataGridView();
            this.LblInfoTotalFeed = new System.Windows.Forms.Label();
            this.CharCapEnc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoAtendenteChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtendenteChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAtendenteCapturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtendenteCapturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCapturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAtendenteFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtendenteFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalChamados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalChamadosCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalChamadoFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharCapEnc)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxEmpresa
            // 
            this.CbxEmpresa.DisplayMember = "Nome";
            this.CbxEmpresa.FormattingEnabled = true;
            this.CbxEmpresa.Location = new System.Drawing.Point(12, 77);
            this.CbxEmpresa.Name = "CbxEmpresa";
            this.CbxEmpresa.Size = new System.Drawing.Size(276, 21);
            this.CbxEmpresa.TabIndex = 7;
            this.CbxEmpresa.ValueMember = "Id";
            this.CbxEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxEmpresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empresa";
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(12, 25);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(69, 20);
            this.MktCompetencia.TabIndex = 5;
            this.MktCompetencia.Leave += new System.EventHandler(this.MktCompetencia_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Competência";
            // 
            // DgvTotalChamados
            // 
            this.DgvTotalChamados.AllowUserToAddRows = false;
            this.DgvTotalChamados.AllowUserToDeleteRows = false;
            this.DgvTotalChamados.AllowUserToOrderColumns = true;
            this.DgvTotalChamados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTotalChamados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTotalChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTotalChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAtendenteChamado,
            this.NomeAtendenteChamado,
            this.TotalChamado});
            this.DgvTotalChamados.Location = new System.Drawing.Point(12, 145);
            this.DgvTotalChamados.MultiSelect = false;
            this.DgvTotalChamados.Name = "DgvTotalChamados";
            this.DgvTotalChamados.ReadOnly = true;
            this.DgvTotalChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTotalChamados.Size = new System.Drawing.Size(422, 188);
            this.DgvTotalChamados.TabIndex = 8;
            // 
            // LblInfoTotalChamado
            // 
            this.LblInfoTotalChamado.AutoSize = true;
            this.LblInfoTotalChamado.Location = new System.Drawing.Point(12, 129);
            this.LblInfoTotalChamado.Name = "LblInfoTotalChamado";
            this.LblInfoTotalChamado.Size = new System.Drawing.Size(120, 13);
            this.LblInfoTotalChamado.TabIndex = 9;
            this.LblInfoTotalChamado.Text = "Total de Chamados - 00";
            // 
            // DgvTotalChamadosCap
            // 
            this.DgvTotalChamadosCap.AllowUserToAddRows = false;
            this.DgvTotalChamadosCap.AllowUserToDeleteRows = false;
            this.DgvTotalChamadosCap.AllowUserToOrderColumns = true;
            this.DgvTotalChamadosCap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTotalChamadosCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTotalChamadosCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTotalChamadosCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAtendenteCapturado,
            this.NomeAtendenteCapturado,
            this.TotalCapturado});
            this.DgvTotalChamadosCap.Location = new System.Drawing.Point(440, 145);
            this.DgvTotalChamadosCap.MultiSelect = false;
            this.DgvTotalChamadosCap.Name = "DgvTotalChamadosCap";
            this.DgvTotalChamadosCap.ReadOnly = true;
            this.DgvTotalChamadosCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTotalChamadosCap.Size = new System.Drawing.Size(422, 188);
            this.DgvTotalChamadosCap.TabIndex = 8;
            // 
            // LblInfoTotalCaptura
            // 
            this.LblInfoTotalCaptura.AutoSize = true;
            this.LblInfoTotalCaptura.Location = new System.Drawing.Point(440, 129);
            this.LblInfoTotalCaptura.Name = "LblInfoTotalCaptura";
            this.LblInfoTotalCaptura.Size = new System.Drawing.Size(156, 13);
            this.LblInfoTotalCaptura.TabIndex = 9;
            this.LblInfoTotalCaptura.Text = "Total de Chamados Capturados";
            // 
            // DgvTotalChamadoFeed
            // 
            this.DgvTotalChamadoFeed.AllowUserToAddRows = false;
            this.DgvTotalChamadoFeed.AllowUserToDeleteRows = false;
            this.DgvTotalChamadoFeed.AllowUserToOrderColumns = true;
            this.DgvTotalChamadoFeed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvTotalChamadoFeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTotalChamadoFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTotalChamadoFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAtendenteFeedback,
            this.NomeAtendenteFeedback,
            this.TotalFeedback});
            this.DgvTotalChamadoFeed.Location = new System.Drawing.Point(12, 352);
            this.DgvTotalChamadoFeed.MultiSelect = false;
            this.DgvTotalChamadoFeed.Name = "DgvTotalChamadoFeed";
            this.DgvTotalChamadoFeed.ReadOnly = true;
            this.DgvTotalChamadoFeed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTotalChamadoFeed.Size = new System.Drawing.Size(422, 188);
            this.DgvTotalChamadoFeed.TabIndex = 8;
            // 
            // LblInfoTotalFeed
            // 
            this.LblInfoTotalFeed.AutoSize = true;
            this.LblInfoTotalFeed.Location = new System.Drawing.Point(12, 336);
            this.LblInfoTotalFeed.Name = "LblInfoTotalFeed";
            this.LblInfoTotalFeed.Size = new System.Drawing.Size(150, 13);
            this.LblInfoTotalFeed.TabIndex = 9;
            this.LblInfoTotalFeed.Text = "Total de Chamados Feedback";
            // 
            // CharCapEnc
            // 
            chartArea1.Name = "ChartArea1";
            this.CharCapEnc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CharCapEnc.Legends.Add(legend1);
            this.CharCapEnc.Location = new System.Drawing.Point(440, 352);
            this.CharCapEnc.Name = "CharCapEnc";
            this.CharCapEnc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CharCapEnc.Series.Add(series1);
            this.CharCapEnc.Size = new System.Drawing.Size(422, 188);
            this.CharCapEnc.TabIndex = 10;
            this.CharCapEnc.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Captura x Encaminhado";
            // 
            // CodigoAtendenteChamado
            // 
            this.CodigoAtendenteChamado.DataPropertyName = "CodigoAtendente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoAtendenteChamado.DefaultCellStyle = dataGridViewCellStyle1;
            this.CodigoAtendenteChamado.HeaderText = "Cód. Atendente";
            this.CodigoAtendenteChamado.Name = "CodigoAtendenteChamado";
            this.CodigoAtendenteChamado.ReadOnly = true;
            this.CodigoAtendenteChamado.Width = 80;
            // 
            // NomeAtendenteChamado
            // 
            this.NomeAtendenteChamado.DataPropertyName = "NomeAtendente";
            this.NomeAtendenteChamado.HeaderText = "Nome Atendente";
            this.NomeAtendenteChamado.Name = "NomeAtendenteChamado";
            this.NomeAtendenteChamado.ReadOnly = true;
            this.NomeAtendenteChamado.Width = 200;
            // 
            // TotalChamado
            // 
            this.TotalChamado.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalChamado.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalChamado.HeaderText = "Total";
            this.TotalChamado.Name = "TotalChamado";
            this.TotalChamado.ReadOnly = true;
            this.TotalChamado.Width = 80;
            // 
            // CodigoAtendenteCapturado
            // 
            this.CodigoAtendenteCapturado.DataPropertyName = "CodigoAtendente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoAtendenteCapturado.DefaultCellStyle = dataGridViewCellStyle3;
            this.CodigoAtendenteCapturado.HeaderText = "Cód. Atendente";
            this.CodigoAtendenteCapturado.Name = "CodigoAtendenteCapturado";
            this.CodigoAtendenteCapturado.ReadOnly = true;
            this.CodigoAtendenteCapturado.Width = 80;
            // 
            // NomeAtendenteCapturado
            // 
            this.NomeAtendenteCapturado.DataPropertyName = "NomeAtendente";
            this.NomeAtendenteCapturado.HeaderText = "Nome Atendente";
            this.NomeAtendenteCapturado.Name = "NomeAtendenteCapturado";
            this.NomeAtendenteCapturado.ReadOnly = true;
            this.NomeAtendenteCapturado.Width = 200;
            // 
            // TotalCapturado
            // 
            this.TotalCapturado.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalCapturado.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalCapturado.HeaderText = "Total";
            this.TotalCapturado.Name = "TotalCapturado";
            this.TotalCapturado.ReadOnly = true;
            this.TotalCapturado.Width = 80;
            // 
            // CodigoAtendenteFeedback
            // 
            this.CodigoAtendenteFeedback.DataPropertyName = "CodigoAtendente";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CodigoAtendenteFeedback.DefaultCellStyle = dataGridViewCellStyle5;
            this.CodigoAtendenteFeedback.HeaderText = "Cód. Atendente";
            this.CodigoAtendenteFeedback.Name = "CodigoAtendenteFeedback";
            this.CodigoAtendenteFeedback.ReadOnly = true;
            this.CodigoAtendenteFeedback.Width = 80;
            // 
            // NomeAtendenteFeedback
            // 
            this.NomeAtendenteFeedback.DataPropertyName = "NomeAtendente";
            this.NomeAtendenteFeedback.HeaderText = "Nome Atendente";
            this.NomeAtendenteFeedback.Name = "NomeAtendenteFeedback";
            this.NomeAtendenteFeedback.ReadOnly = true;
            this.NomeAtendenteFeedback.Width = 200;
            // 
            // TotalFeedback
            // 
            this.TotalFeedback.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalFeedback.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalFeedback.HeaderText = "Total";
            this.TotalFeedback.Name = "TotalFeedback";
            this.TotalFeedback.ReadOnly = true;
            this.TotalFeedback.Width = 80;
            // 
            // FrmConsultaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.CharCapEnc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblInfoTotalFeed);
            this.Controls.Add(this.LblInfoTotalCaptura);
            this.Controls.Add(this.DgvTotalChamadoFeed);
            this.Controls.Add(this.LblInfoTotalChamado);
            this.Controls.Add(this.DgvTotalChamadosCap);
            this.Controls.Add(this.DgvTotalChamados);
            this.Controls.Add(this.CbxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaChamado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Chamado";
            this.Load += new System.EventHandler(this.FrmConsultaChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalChamados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalChamadosCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotalChamadoFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharCapEnc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTotalChamados;
        private System.Windows.Forms.Label LblInfoTotalChamado;
        private System.Windows.Forms.DataGridView DgvTotalChamadosCap;
        private System.Windows.Forms.Label LblInfoTotalCaptura;
        private System.Windows.Forms.DataGridView DgvTotalChamadoFeed;
        private System.Windows.Forms.Label LblInfoTotalFeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart CharCapEnc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendenteChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtendenteChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendenteCapturado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtendenteCapturado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCapturado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtendenteFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtendenteFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFeedback;
    }
}