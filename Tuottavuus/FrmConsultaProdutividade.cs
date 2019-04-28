using Controle;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmConsultaProdutividade : Form
    {

        #region Objetos e Variaveis
        DateTime dtUltimoDia, dtPrimeiroDia, dtCompetenciaAtiva;
        int numDiasUteis = 0, numFeriados = 0, numDomingos = 0;
        int idEmpresa, idCompetencia;
        double valorBase = 0;
        decimal valorProdutividade, reflexoProdutividade, totalProdutividade;
        FeriadoControle feriadoControle;
        CompetenciaControle competenciaControle;
        ProdutividadeValorBaseControle produtividadeValorBaseControle;
        EmpresaControle empresaControle;
        ProdutividadeControle produtividadeControle;
        #endregion
        public FrmConsultaProdutividade()
        {
            InitializeComponent();
        }

        private void InfomarcaoMes(DateTime dtComp)
        {
            feriadoControle = new FeriadoControle();
            competenciaControle = new CompetenciaControle();
            try
            {
                numFeriados = feriadoControle.TotalFeriadoCompetencia(dtComp);
                dtPrimeiroDia = competenciaControle.PrimeiroDia(dtComp);
                dtUltimoDia = competenciaControle.UltimoDia(dtComp);
                int dias = int.Parse(dtUltimoDia.ToString("dd"));
                idCompetencia = competenciaControle.Id(dtComp);
                numDiasUteis = competenciaControle.DiasUteis(dtPrimeiroDia, dtUltimoDia, numFeriados);
                numDomingos = competenciaControle.Domingos(dtPrimeiroDia, dtUltimoDia);
                LblInfo.Text = "Dias Uteis: " + numDiasUteis.ToString("00") +
                " - Domingos: " + numDomingos.ToString("00") +
                " - Feriados: " + numFeriados.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValorBase(int competenciaId, int empresaId)
        {
            produtividadeValorBaseControle = new ProdutividadeValorBaseControle();
            produtividadeControle = new ProdutividadeControle();
            try
            {
                DateTime dtCalculoData = DateTime.Parse(MktCompetencia.Text); //produtividadeControle.Calculo_Data(competenciaId, empresaId);

                valorBase = produtividadeValorBaseControle.Valor_Data(dtCalculoData);
                LblValorBase.Text = "Valor Base: " + valorBase.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                LblInfo.Text = "Dias Uteis: 00 " +
                " - Domingos: 00" +
                " - Feriados: 00";
                LblValorBase.Text = "Valor Base: 0,00";
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

        private bool ListaCalculo(int competenciaId, int empresaId)
        {
            produtividadeControle = new ProdutividadeControle();
            valorProdutividade = 0;
            reflexoProdutividade = 0;
            totalProdutividade = 0;
            try
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void FrmConsultaProdutividade_Load(object sender, EventArgs e)
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetenciaAtiva = competenciaControle.CompetenciaAtiva();
                MktCompetencia.Text = dtCompetenciaAtiva.ToString("MM/yyyy");
                ListaEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.Text.Substring(0, CbxEmpresa.Text.IndexOf(' ')));
                dtCompetenciaAtiva = DateTime.Parse(MktCompetencia.Text);
                InfomarcaoMes(dtCompetenciaAtiva);
                ListaCalculo(idCompetencia, idEmpresa);
                ValorBase(idCompetencia, idEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MktCompetencia_Leave(object sender, EventArgs e)
        {
            try
            {
                CbxEmpresa_SelectedIndexChanged(e, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MktCompetencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbxEmpresa_SelectedIndexChanged(e, e);
            }
        }
        private void FrmConsultaProdutividade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tirar o som da tecla enter
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }

        }
    }
}
