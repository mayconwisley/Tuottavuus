using Controle;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmConsultaAssiduidade : Form
    {

        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        AssiduidadeControle assiduidadeControle;

        int idEmpresa = 0, idCompetencia = 0;

        DateTime dtCompetencia;

        public FrmConsultaAssiduidade()
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
        private void ListaAssiduidade()
        {
            assiduidadeControle = new AssiduidadeControle();

            try
            {
                DgvAssiduidade.DataSource = assiduidadeControle.AssiduidadeTabelaConsulta(idCompetencia, idEmpresa);
                int totalChamado = DgvAssiduidade.Rows.Count;
                LblInfoAssiduidade.Text = "Assiduidade - " + totalChamado.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void FrmConsultaAssiduidade_Load(object sender, EventArgs e)
        {
            ListaCompetenciaAtiva();
            ListaEmpresa();
            ListaAssiduidade();
        }

        private void MktCompetencia_Leave(object sender, EventArgs e)
        {
            try
            {
                ListaCompetenciaId();
                ListaAssiduidade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

            }
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaCompetenciaId();
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
