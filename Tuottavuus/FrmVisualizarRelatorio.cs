using Controle;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
namespace Tuottavuus
{
    public partial class FrmVisualizarRelatorio : Form
    {
        ProdutividadeValorBaseControle produtividadeValorBaseControle;
        ProdutividadeControle produtividadeControle;
        ReportDataSource reportDataSource;
        ReportParameter paramenterValorBase;
        ReportParameter paramenterCompetencia;
        int numRelatorio, idCompetencia, idEmpresa, idDepartamento, idEmpregado;
        string strValorBase = string.Empty;
        DateTime dtCompetencia, dtCalculoData;
        public FrmVisualizarRelatorio()
        {
            InitializeComponent();
        }
        public FrmVisualizarRelatorio(int tipoRelatorio, int empresaId, int empregadoId, int departamentoId, int competenciaId, DateTime competencia)
        {
            InitializeComponent();
            numRelatorio = tipoRelatorio;
            idEmpresa = empresaId;
            idEmpregado = empregadoId;
            idDepartamento = departamentoId;
            idCompetencia = competenciaId;
            dtCompetencia = competencia;
        }

        private void FrmVisualizarRelatorio_Load(object sender, EventArgs e)
        {
            produtividadeValorBaseControle = new ProdutividadeValorBaseControle();
            produtividadeControle = new ProdutividadeControle();
            paramenterValorBase = new ReportParameter();
            reportDataSource = new ReportDataSource();
            try
            {
                dtCalculoData = produtividadeControle.Calculo_Data(idCompetencia, idEmpresa);
                strValorBase = produtividadeValorBaseControle.Valor_Data(dtCalculoData).ToString("#,##0.00");
                paramenterValorBase = new ReportParameter("ValorBase", strValorBase);
                paramenterCompetencia = new ReportParameter("Competencia", dtCompetencia.Date.ToString());
                switch (numRelatorio)
                {
                    case 1: //Produtivade Calculado
                        reportDataSource.Name = "ProdutividadeCalculo";
                        reportDataSource.Value = relatoriosTuottavuus.CalculoProdutividade;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\CalculoProdutividade.rdlc";
                        RvGeral.LocalReport.SetParameters(paramenterValorBase);
                        calculoProdutividadeTableAdapter.Fill(relatoriosTuottavuus.CalculoProdutividade, idCompetencia, idEmpresa);
                        break;
                    case 2: //Avaliacao produtividade
                        reportDataSource.Name = "AvalicaoProdutividade";
                        reportDataSource.Value = relatoriosTuottavuus.AvalicaoProdutividade;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\AvaliacaoProdutividade.rdlc";
                        avalicaoProdutividadeTableAdapter.Fill(relatoriosTuottavuus.AvalicaoProdutividade, idCompetencia, idEmpresa);
                        break;
                    case 3: //Avaliar produtividade
                        reportDataSource.Name = "AvaliarProdutividade";
                        reportDataSource.Value = relatoriosTuottavuus.AvaliarProdutividade;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\AvaliarProdutividade.rdlc";
                        RvGeral.LocalReport.SetParameters(paramenterCompetencia);
                        avaliarProdutividadeTableAdapter.Fill(relatoriosTuottavuus.AvaliarProdutividade, idDepartamento);
                        break;
                    case 4: //Produtivade Calculado Departamento
                        reportDataSource.Name = "ProdutividadeCalculoDPTO";
                        reportDataSource.Value = relatoriosTuottavuus.CalculoProdutividadeDPTO;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\CalculoProdutividadeDPTO.rdlc";
                        RvGeral.LocalReport.SetParameters(paramenterValorBase);
                        calculoProdutividadeDPTOTableAdapter.Fill(relatoriosTuottavuus.CalculoProdutividadeDPTO, idCompetencia, idEmpresa, idDepartamento);
                        break;
                    case 5: //Avaliacao produtividade Empregado
                        reportDataSource.Name = "AvalicaoProdutividadeEmpregado";
                        reportDataSource.Value = relatoriosTuottavuus.AvaliacaoProdutividadeEmpregado;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\AvaliacaoProdutividadeEmpregado.rdlc";
                        avaliacaoProdutividadeEmpregadoTableAdapter.Fill(relatoriosTuottavuus.AvaliacaoProdutividadeEmpregado, idCompetencia, idEmpregado);
                        break;
                    case 6: //Avaliar produtividade Empregado ERRO 
                        reportDataSource.Name = "AvaliarProdutividadeEmpregado";
                        reportDataSource.Value = relatoriosTuottavuus.AvaliarProdutividadeEmpregado;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\AvaliarProdutividadeEmpregado.rdlc";
                        RvGeral.LocalReport.SetParameters(paramenterCompetencia);
                        avaliarProdutividadeEmpregadoTableAdapter.Fill(relatoriosTuottavuus.AvaliarProdutividadeEmpregado, idEmpregado);
                        break;
                    case 7: //Produtivadade Calculo Empregado
                        reportDataSource.Name = "ProdutividadeCalculoEmpregado";
                        reportDataSource.Value = relatoriosTuottavuus.CalculoProdutividadeEmpregado;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\CalculoProdutividadeEmpregado.rdlc";
                        RvGeral.LocalReport.SetParameters(paramenterValorBase);
                        calculoProdutividadeEmpregadoTableAdapter.Fill(relatoriosTuottavuus.CalculoProdutividadeEmpregado, idEmpregado, idCompetencia);
                        break;
                    case 8: //Avaliacao produtividade por DPTO
                        reportDataSource.Name = "AvalicaoProdutividadeDPTO";
                        reportDataSource.Value = relatoriosTuottavuus.AvaliacaoProdutividadeDPTO;
                        RvGeral.LocalReport.DataSources.Clear();
                        RvGeral.LocalReport.DataSources.Add(reportDataSource);
                        RvGeral.LocalReport.ReportPath = @"Relatorios\AvaliacaoProdutividadeDPTO.rdlc";
                        avaliacaoProdutividadeDPTOTableAdapter.Fill(relatoriosTuottavuus.AvaliacaoProdutividadeDPTO, idCompetencia, idEmpresa, idDepartamento);
                        break;
                    default:
                        break;
                }
                this.RvGeral.RefreshReport();
                this.RvGeral.SetDisplayMode(DisplayMode.PrintLayout);
                this.RvGeral.ZoomMode = ZoomMode.Percent;
                this.RvGeral.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
