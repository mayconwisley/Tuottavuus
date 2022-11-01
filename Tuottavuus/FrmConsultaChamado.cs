using Controle;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmConsultaChamado : Form
    {
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        ChamadoControle chamadoControle;

        int idEmpresa = 0, idCompetencia = 0;

        DateTime dtCompetencia;

        public FrmConsultaChamado()
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
        private void ListaQtdChamado(int idCompetencia, int idEmpresa)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                DgvTotalChamados.DataSource = chamadoControle.QtdChamadoTabela(idCompetencia, idEmpresa);
                int totalChamado = DgvTotalChamados.Rows.Count;
                LblInfoTotalChamado.Text = "Total de Chamados  - " + totalChamado.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }
        private void ListaQtdChamadoCaptura(int idCompetencia, int idEmpresa)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                DgvTotalChamadosCap.DataSource = chamadoControle.QtdChamadoCapturadoTabela(idCompetencia, idEmpresa);
                int totalChamado = DgvTotalChamadosCap.Rows.Count;
                LblInfoTotalCaptura.Text = "Total de Chamados Capturados - " + totalChamado.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }
        private void ListaQtdChamadoFeedback(int idCompetencia, int idEmpresa)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                DgvTotalChamadoFeed.DataSource = chamadoControle.QtdFeedbackTabela(idCompetencia, idEmpresa);
                int totalChamado = DgvTotalChamadoFeed.Rows.Count;
                LblInfoTotalFeed.Text = "Total de Chamados Feedback - " + totalChamado.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }
        private void FrmConsultaChamado_Load(object sender, EventArgs e)
        {
            ListaCompetenciaAtiva();
            ListaEmpresa();
        }
        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaCompetenciaId();
                ListaQtdChamado(idCompetencia, idEmpresa);
                ListaQtdChamadoCaptura(idCompetencia, idEmpresa);
                ListaQtdChamadoFeedback(idCompetencia, idEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private void MktCompetencia_Leave(object sender, EventArgs e)
        {
            try
            {
                ListaCompetenciaId();
                ListaQtdChamado(idCompetencia, idEmpresa);
                ListaQtdChamadoCaptura(idCompetencia, idEmpresa);
                ListaQtdChamadoFeedback(idCompetencia, idEmpresa);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                ListaQtdChamado(0, 0);
                ListaQtdChamadoCaptura(0, 0);
                ListaQtdChamadoFeedback(0, 0);
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
