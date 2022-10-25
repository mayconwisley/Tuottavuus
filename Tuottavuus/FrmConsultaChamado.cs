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
        PossoMaisControle possoMaisControle;
        MetaPesoControle metaPesoControle;

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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            possoMaisControle = new PossoMaisControle();
            metaPesoControle = new MetaPesoControle();

            decimal teste1 = possoMaisControle.PorcentagemChamado('C', idCompetencia, idEmpresa, 9, 3, 1);
            int testeId = metaPesoControle.IdPorMeta(teste1);
            
            
            linkLabel1.Text = $"Id: {testeId.ToString("00")} Porcentagem: {teste1.ToString("#,###,##0.00")}%" ;
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
