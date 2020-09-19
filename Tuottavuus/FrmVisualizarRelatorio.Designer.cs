namespace Tuottavuus
{
    partial class FrmVisualizarRelatorio
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
            this.calculoProdutividadeTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.CalculoProdutividadeTableAdapter();
            this.relatoriosTuottavuus = new Tuottavuus.Relatorios.RelatoriosTuottavuus();
            this.avalicaoProdutividadeTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvalicaoProdutividadeTableAdapter();
            this.avaliarProdutividadeTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliarProdutividadeTableAdapter();
            this.RvGeral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.avaliacaoProdutividadeDPTOTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeDPTOTableAdapter();
            this.avaliacaoProdutividadeEmpregadoTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeEmpregadoTableAdapter();
            this.avaliarProdutividadeEmpregadoTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliarProdutividadeEmpregadoTableAdapter();
            this.calculoProdutividadeDPTOTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.CalculoProdutividadeDPTOTableAdapter();
            this.calculoProdutividadeEmpregadoTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.CalculoProdutividadeEmpregadoTableAdapter();
            this.avaliacaoProdutividadeMediaCompEmpresaTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeMediaCompEmpresaTableAdapter();
            this.avaliacaoProdutividadeMediaCompEmpregadoTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeMediaCompEmpregadoTableAdapter();
            this.avaliacaoProdutividadeMediaCompDPTOTableAdapter = new Tuottavuus.Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeMediaCompDPTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriosTuottavuus)).BeginInit();
            this.SuspendLayout();
            // 
            // calculoProdutividadeTableAdapter
            // 
            this.calculoProdutividadeTableAdapter.ClearBeforeFill = true;
            // 
            // relatoriosTuottavuus
            // 
            this.relatoriosTuottavuus.DataSetName = "RelatoriosTuottavuus";
            this.relatoriosTuottavuus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avalicaoProdutividadeTableAdapter
            // 
            this.avalicaoProdutividadeTableAdapter.ClearBeforeFill = true;
            // 
            // avaliarProdutividadeTableAdapter
            // 
            this.avaliarProdutividadeTableAdapter.ClearBeforeFill = true;
            // 
            // RvGeral
            // 
            this.RvGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvGeral.Location = new System.Drawing.Point(0, 0);
            this.RvGeral.Name = "RvGeral";
            this.RvGeral.ServerReport.BearerToken = null;
            this.RvGeral.ShowBackButton = false;
            this.RvGeral.ShowFindControls = false;
            this.RvGeral.ShowRefreshButton = false;
            this.RvGeral.ShowStopButton = false;
            this.RvGeral.Size = new System.Drawing.Size(841, 557);
            this.RvGeral.TabIndex = 0;
            // 
            // avaliacaoProdutividadeDPTOTableAdapter
            // 
            this.avaliacaoProdutividadeDPTOTableAdapter.ClearBeforeFill = true;
            // 
            // avaliacaoProdutividadeEmpregadoTableAdapter
            // 
            this.avaliacaoProdutividadeEmpregadoTableAdapter.ClearBeforeFill = true;
            // 
            // avaliarProdutividadeEmpregadoTableAdapter
            // 
            this.avaliarProdutividadeEmpregadoTableAdapter.ClearBeforeFill = true;
            // 
            // calculoProdutividadeDPTOTableAdapter
            // 
            this.calculoProdutividadeDPTOTableAdapter.ClearBeforeFill = true;
            // 
            // calculoProdutividadeEmpregadoTableAdapter
            // 
            this.calculoProdutividadeEmpregadoTableAdapter.ClearBeforeFill = true;
            // 
            // avaliacaoProdutividadeMediaCompEmpresaTableAdapter
            // 
            this.avaliacaoProdutividadeMediaCompEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // avaliacaoProdutividadeMediaCompEmpregadoTableAdapter
            // 
            this.avaliacaoProdutividadeMediaCompEmpregadoTableAdapter.ClearBeforeFill = true;
            // 
            // avaliacaoProdutividadeMediaCompDPTOTableAdapter
            // 
            this.avaliacaoProdutividadeMediaCompDPTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisualizarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 557);
            this.Controls.Add(this.RvGeral);
            this.Name = "FrmVisualizarRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Relatorio";
            this.Load += new System.EventHandler(this.FrmVisualizarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatoriosTuottavuus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Relatorios.RelatoriosTuottavuusTableAdapters.CalculoProdutividadeTableAdapter calculoProdutividadeTableAdapter;
        private Relatorios.RelatoriosTuottavuus relatoriosTuottavuus;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvalicaoProdutividadeTableAdapter avalicaoProdutividadeTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliarProdutividadeTableAdapter avaliarProdutividadeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer RvGeral;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeDPTOTableAdapter avaliacaoProdutividadeDPTOTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeEmpregadoTableAdapter avaliacaoProdutividadeEmpregadoTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliarProdutividadeEmpregadoTableAdapter avaliarProdutividadeEmpregadoTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.CalculoProdutividadeDPTOTableAdapter calculoProdutividadeDPTOTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.CalculoProdutividadeEmpregadoTableAdapter calculoProdutividadeEmpregadoTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeMediaCompEmpresaTableAdapter avaliacaoProdutividadeMediaCompEmpresaTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeMediaCompEmpregadoTableAdapter avaliacaoProdutividadeMediaCompEmpregadoTableAdapter;
        private Relatorios.RelatoriosTuottavuusTableAdapters.AvaliacaoProdutividadeMediaCompDPTOTableAdapter avaliacaoProdutividadeMediaCompDPTOTableAdapter;
    }
}