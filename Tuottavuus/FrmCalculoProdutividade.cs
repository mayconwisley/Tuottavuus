using Controle;
using Modelo;
using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCalculoProdutividade : Form
    {
        #region Objetos e Variaveis
        DateTime dtUltimoDia, dtPrimeiroDia, dtCompetenciaAtiva;
        int numDiasUteis = 0, numFeriados = 0, numDomingos = 0, totalDomFer = 0, totalAvaliacaoPorEmpregado = 0;
        int idEmpregado, idEmpresa, idCompetencia, idProdutividade;
        double valorBase = 0, dbMedia = 0, valor = 0, reflexo = 0;
        decimal valorProdutividade, reflexoProdutividade, totalProdutividade;
        object obj;
        FeriadoControle feriadoControle;
        CompetenciaControle competenciaControle;
        ProdutividadeValorBaseControle produtividadeValorBaseControle;
        EmpresaControle empresaControle;
        EmpregadoControle empregadoControle;
        AtividadeAvaliacaoControle atividadeAvaliacaoControle;
        CalculoProdutividade calculoProdutividade;

        Produtividade produtividade;
        ProdutividadeControle produtividadeControle;
        #endregion
        public FrmCalculoProdutividade()
        {
            InitializeComponent();
        }
        private void InfomarcaoMes()
        {
            feriadoControle = new FeriadoControle();
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetenciaAtiva = competenciaControle.CompetenciaAtiva();
                numFeriados = feriadoControle.TotalFeriadoCompetencia(dtCompetenciaAtiva);

                dtPrimeiroDia = competenciaControle.PrimeiroDia(dtCompetenciaAtiva);
                dtUltimoDia = competenciaControle.UltimoDia(dtCompetenciaAtiva);

                int dias = int.Parse(dtUltimoDia.ToString("dd"));

                idCompetencia = competenciaControle.Id(dtCompetenciaAtiva);
                numDiasUteis = competenciaControle.DiasUteis(dtPrimeiroDia, dtUltimoDia, numFeriados);
                numDomingos = competenciaControle.Domingos(dtPrimeiroDia, dtUltimoDia);

                LblCompetencia.Text = "Competência: " + dtCompetenciaAtiva.ToString("MM/yyyy");
                LblInfo.Text = "Dias Uteis: " + numDiasUteis.ToString("00") +
                " - Domingos: " + numDomingos.ToString("00") +
                " - Feriados: " + numFeriados.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ValorBase(DateTime competencia)
        {
            produtividadeValorBaseControle = new ProdutividadeValorBaseControle();
            try
            {
                valorBase = produtividadeValorBaseControle.Valor_Data(competencia);
                LblValorBase.Text = "Valor Base: " + valorBase.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ListaEmpresa()
        {
            empresaControle = new EmpresaControle();
            try
            {
                CbxEmpresa.DataSource = empresaControle.EmpresaComboBox();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void CompararCalculoEmpregado()
        {
            empregadoControle = new EmpregadoControle();
            int totalEmpregado, totalCalculado, diferenca;
            try
            {

                Invoke((Action)(() =>
                {

                    DataTable tblEmpregado = empregadoControle.EmpregadoTabelaCalculo(idEmpresa);
                    totalEmpregado = tblEmpregado.Rows.Count;
                    totalCalculado = DgvCalculo.Rows.Count;
                    diferenca = totalEmpregado - totalCalculado;
                    LblInfoCalculoExclusao.Visible = false;

                    if (totalCalculado == totalEmpregado)
                    {
                        BtnCalcular.Enabled = false;
                        BtnExcluir.Enabled = true;
                    }
                    else if (totalCalculado < totalEmpregado && totalCalculado > 0)
                    {
                        BtnCalcular.Enabled = true;
                        BtnExcluir.Enabled = true;
                        LblInfoCalculoExclusao.Visible = true;
                        LblInfoCalculoExclusao.Text = "Total de Empregados: " + totalEmpregado.ToString("00") +
                        "\nEmpregado não calculados: " + diferenca.ToString("00");
                    }
                    else
                    {
                        BtnCalcular.Enabled = true;
                        BtnExcluir.Enabled = false;
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool ListaCalculo(int competenciaId, int empresaId)
        {
            produtividadeControle = new ProdutividadeControle();
            valorProdutividade = 0;
            reflexoProdutividade = 0;
            totalProdutividade = 0;
            try
            {
                Invoke((Action)(() =>
                {
                    DgvCalculo.DataSource = produtividadeControle.ProdutividadeTabela(competenciaId, empresaId);

                    foreach (DataGridViewRow row in DgvCalculo.Rows)
                    {
                        valorProdutividade = valorProdutividade + decimal.Parse(row.Cells["Produtividade_Valorr"].Value.ToString());
                        reflexoProdutividade = reflexoProdutividade + decimal.Parse(row.Cells["Produtividade_Reflexoo"].Value.ToString());
                        totalProdutividade = totalProdutividade + decimal.Parse(row.Cells["Total_Geral"].Value.ToString());
                    }
                    LblInfoGeral.Text = "Total Valor.........: " + valorProdutividade.ToString("#,##0.00") + "\n" +
                    "Total Reflexos...: " + reflexoProdutividade.ToString("#,##0.00") + "\n\n" +
                    "Total Geral......: " + totalProdutividade.ToString("#,##0.00");

                }));

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void ExclusaoIndividual(int produtividadeId)
        {
            produtividadeControle = new ProdutividadeControle();
            try
            {
                //Exclusao individual de empregado
                produtividadeControle.ExcluirIndividual(produtividadeId);
                ListaCalculo(idCompetencia, idEmpresa);
                CompararCalculoEmpregado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CalculoIndividual()
        {
            calculoProdutividade = new CalculoProdutividade();
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();
            produtividade = new Produtividade();
            produtividadeControle = new ProdutividadeControle();
            empregadoControle = new EmpregadoControle();
            int x = 0;
            bool ausente = false;

            Invoke((Action)(() =>
            {
                LblInfoCalculoExclusao.Visible = true;
            }));
            try
            {
                DataTable tblEmpregado = empregadoControle.EmpregadoTabelaCalculo(idEmpresa);
                foreach (DataRow item in tblEmpregado.Rows)
                {
                    idEmpregado = int.Parse(item["Id"].ToString());
                    foreach (DataGridViewRow rows in DgvCalculo.Rows)
                    {
                        if (idEmpregado == int.Parse(rows.Cells["Id_Empregadoo"].Value.ToString()))
                        {
                            ausente = false;
                            break;
                        }
                        else
                        {
                            ausente = true;
                        }
                    }
                    if (ausente)
                    {

                        produtividade.Data_Calculo = DateTime.Now.Date;
                        produtividade.Competencia = new Competencia();
                        produtividade.Competencia.Id = idCompetencia;
                        produtividade.Empresa = new Empresa();
                        produtividade.Empresa.Id = idEmpresa;
                        produtividade.Empregado = new Empregado();
                        produtividade.Empregado.Id = idEmpregado;

                        totalAvaliacaoPorEmpregado = atividadeAvaliacaoControle.TotalAvaliacaoEmpregado(idEmpresa, idEmpregado, idCompetencia);

                        dbMedia = 0;
                        totalDomFer = numDomingos + numFeriados;
                        //Calcular a media
                        if (totalAvaliacaoPorEmpregado != 0)
                        {
                            x++;
                            BwProcesso.ReportProgress(x);
                            dbMedia = atividadeAvaliacaoControle.Media(idEmpresa, idEmpregado, idCompetencia);
                        }
                        else
                        {
                            continue;
                        }

                        valor = calculoProdutividade.Valor(valorBase, dbMedia);
                        reflexo = calculoProdutividade.Reflexo(valor, numDiasUteis, totalDomFer);
                        produtividade.Media = Math.Round(dbMedia, 2);
                        produtividade.Produtividade_Valor = Math.Round(valor, 2);
                        produtividade.Produtividade_Reflexo = Math.Round(reflexo, 2);
                        produtividade.DiasUteis = numDiasUteis;
                        produtividade.DomingosFeriados = totalDomFer;
                        produtividadeControle.Gravar(produtividade);
                    }
                }
                Invoke((Action)(() =>
                {
                    LblInfoCalculoExclusao.Visible = false;
                }));
                MessageBox.Show("Calculo individual finalizado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaCalculo(idCompetencia, idEmpresa);
                CompararCalculoEmpregado();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Calculo Geral
        private bool CalcularGeral()
        {
            calculoProdutividade = new CalculoProdutividade();
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();
            produtividade = new Produtividade();
            produtividadeControle = new ProdutividadeControle();
            empregadoControle = new EmpregadoControle();
            int x = 0;

            Invoke((Action)(() =>
            {
                LblInfoCalculoExclusao.Visible = true;
            }));
            try
            {
                DataTable tblEmpregado = empregadoControle.EmpregadoTabelaCalculo(idEmpresa);
                foreach (DataRow item in tblEmpregado.Rows)
                {

                    idEmpregado = int.Parse(item["Id"].ToString());
                    produtividade.Data_Calculo = DateTime.Now.Date;
                    produtividade.Competencia = new Competencia();
                    produtividade.Competencia.Id = idCompetencia;
                    produtividade.Empresa = new Empresa();
                    produtividade.Empresa.Id = idEmpresa;
                    produtividade.Empregado = new Empregado();
                    produtividade.Empregado.Id = idEmpregado;

                    totalAvaliacaoPorEmpregado = atividadeAvaliacaoControle.TotalAvaliacaoEmpregado(idEmpresa, idEmpregado, idCompetencia);

                    dbMedia = 0;
                    totalDomFer = numDomingos + numFeriados;
                    //Calcular a media
                    if (totalAvaliacaoPorEmpregado != 0)
                    {
                        x++;
                        BwProcesso.ReportProgress(x);
                        dbMedia = atividadeAvaliacaoControle.Media(idEmpresa, idEmpregado, idCompetencia);
                    }
                    else
                    {
                        continue;
                    }

                    valor = calculoProdutividade.Valor(valorBase, dbMedia);
                    reflexo = calculoProdutividade.Reflexo(valor, numDiasUteis, totalDomFer);

                    produtividade.Media = Math.Round(dbMedia, 2);
                    produtividade.Produtividade_Valor = Math.Round(valor, 2);
                    produtividade.Produtividade_Reflexo = Math.Round(reflexo, 2);
                    produtividade.DiasUteis = numDiasUteis;
                    produtividade.DomingosFeriados = totalDomFer;

                    produtividadeControle.Gravar(produtividade);
                }
                Invoke((Action)(() =>
                {
                    LblInfoCalculoExclusao.Visible = false;
                }));
                MessageBox.Show("Calculo geral finalizado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaCalculo(idCompetencia, idEmpresa);
                CompararCalculoEmpregado();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Exclusao geral do calculo
        private bool ExcluirGeral()
        {
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();
            produtividade = new Produtividade();
            produtividadeControle = new ProdutividadeControle();
            empregadoControle = new EmpregadoControle();
            int x = 0;

            Invoke((Action)(() =>
            {
                LblInfoCalculoExclusao.Visible = true;
            }));
            try
            {
                DataTable tblEmpregado = empregadoControle.EmpregadoTabelaCalculo(idEmpresa);
                foreach (DataRow item in tblEmpregado.Rows)
                {

                    idEmpregado = int.Parse(item["Id"].ToString());
                    produtividade.Competencia = new Competencia();
                    produtividade.Competencia.Id = idCompetencia;
                    produtividade.Empresa = new Empresa();
                    produtividade.Empresa.Id = idEmpresa;

                    totalAvaliacaoPorEmpregado = atividadeAvaliacaoControle.TotalAvaliacaoEmpregado(idEmpresa, idEmpregado, idCompetencia);

                    if (totalAvaliacaoPorEmpregado != 0)
                    {
                        x++;
                        BwProcesso.ReportProgress(x);
                        produtividadeControle.Excluir(produtividade);
                    }
                    else
                    {
                        continue;
                    }

                }
                Invoke((Action)(() =>
                {
                    LblInfoCalculoExclusao.Visible = false;
                }));
                MessageBox.Show("Exclusão finalizada!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaCalculo(idCompetencia, idEmpresa);
                CompararCalculoEmpregado();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void Calcular()
        {
            int numLancamento = 0;
            numLancamento = DgvCalculo.Rows.Count;

            if (numLancamento > 0)
            {
                CalculoIndividual();
            }
            else
            {
                CalcularGeral();
            }
        }
        private void FrmCalculoProdutividade_Load(object sender, EventArgs e)
        {
            InfomarcaoMes();
            ValorBase(dtCompetenciaAtiva);
            ListaEmpresa();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            obj = "Calcular";
            BwProcesso.RunWorkerAsync();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            obj = "Excluir";
            if (MessageBox.Show("Excluindo dados, deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                BwProcesso.RunWorkerAsync();
            }
        }
        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
            ListaCalculo(idCompetencia, idEmpresa);
            CompararCalculoEmpregado();
        }
        private void BwProcesso_DoWork(object sender, DoWorkEventArgs e)
        {
            if (obj.Equals("Calcular"))
            {
                Calcular();
            }
            else if (obj.Equals("Excluir"))
            {
                ExcluirGeral();
            }
        }
        private void BwProcesso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (obj.Equals("Calcular"))
            {
                LblInfoCalculoExclusao.Text = "Calculando Empregado: " + e.ProgressPercentage.ToString("00");
            }
            else if (obj.Equals("Excluir"))
            {
                LblInfoCalculoExclusao.Text = "Excluindo Empregado: " + e.ProgressPercentage.ToString("00");
            }
        }
        private void DgvCalculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            produtividadeControle = new ProdutividadeControle();
            try
            {
                idProdutividade = int.Parse(DgvCalculo.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                if (MessageBox.Show("Deseja excluir o calculo deste empregado?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExclusaoIndividual(idProdutividade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
