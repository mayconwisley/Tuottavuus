using Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmConsultaChamado : Form
    {

        EmpregadoControle empregadoControle;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        ChamadoControle chamadoControle;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0;

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

        private void ListaQuantidadeChamado(int idCompetencia, int idEmpresa)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                DgvTotalChamados.DataSource = chamadoControle.QuantidadeChamadoTabela(idCompetencia, idEmpresa);
                int totalChamado = DgvTotalChamados.Rows.Count;
                LblInfoTotalChamado.Text = "Total de Chamados  - " + totalChamado.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }
        private void ListaQuantidadeChamadoCaptura(int idCompetencia, int idEmpresa)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                DgvTotalChamadosCap.DataSource = chamadoControle.QuantidadeChamadoCapturadoTabela(idCompetencia, idEmpresa);
                int totalChamado = DgvTotalChamadosCap.Rows.Count;
                LblInfoTotalCaptura.Text = "Total de Chamados Capturados - " + totalChamado.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void ListaQuantidadeChamadoFeedback(int idCompetencia, int idEmpresa)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                DgvTotalChamadoFeed.DataSource = chamadoControle.QuantidadeFeedbackTabela(idCompetencia, idEmpresa);
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
                ListaQuantidadeChamado(idCompetencia, idEmpresa);
                ListaQuantidadeChamadoCaptura(idCompetencia, idEmpresa);
                ListaQuantidadeChamadoFeedback(idCompetencia, idEmpresa);
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
                ListaQuantidadeChamado(idCompetencia, idEmpresa);
                ListaQuantidadeChamadoCaptura(idCompetencia, idEmpresa);
                ListaQuantidadeChamadoFeedback(idCompetencia, idEmpresa);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                ListaQuantidadeChamado(0, 0);
                ListaQuantidadeChamadoCaptura(0, 0);
                ListaQuantidadeChamadoFeedback(0, 0);
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
