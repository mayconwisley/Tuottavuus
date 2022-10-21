using Controle;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmConsultaPesquisa : Form
    {

        EmpregadoControle empregadoControle;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        PesquisaControle pesquisaControle;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0;

        DateTime dtCompetencia;

        public FrmConsultaPesquisa()
        {
            InitializeComponent();
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
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void ListaPesquisa(int idCompetencia, int idEmpresa)
        {
            pesquisaControle = new PesquisaControle();
            try
            {
                DgvPesquisa.DataSource = pesquisaControle.PesquisaTabelaEmpresa(idCompetencia, idEmpresa);
                int totalPesquisa = DgvPesquisa.Rows.Count;
                LblInfoPesquisa.Text = "Pesquisa - " + totalPesquisa.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void FrmPesquisaConsulta_Load(object sender, EventArgs e)
        {
            ListaCompetenciaAtiva();
            ListaEmpresa();
        }

        private void MktCompetencia_Leave(object sender, EventArgs e)
        {
            try
            {
                ListaCompetenciaId();
                ListaPesquisa(idCompetencia, idEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                ListaPesquisa(0, 0);
            }
        }
        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaCompetenciaId();
                ListaPesquisa(idCompetencia, idEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private void ListaCompetenciaId()
        {
            competenciaControle = new CompetenciaControle();
            DateTime competencia = DateTime.Parse(MktCompetencia.Text);
            try
            {
                idCompetencia = competenciaControle.Id(competencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private bool ListaCompetenciaAtiva()
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetencia = competenciaControle.CompetenciaAtiva();
                idCompetencia = competenciaControle.Id(dtCompetencia);
                MktCompetencia.Text = dtCompetencia.ToString("MM/yyyy");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }
    }
}
