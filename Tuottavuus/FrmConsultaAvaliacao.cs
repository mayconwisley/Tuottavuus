using Controle;
using System;
using System.Windows.Forms;
namespace Tuottavuus
{
    public partial class FrmConsultaAvaliacao : Form
    {
        EmpregadoControle empregadoControle;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        DateTime dtCompetencia;
        AtividadeAvaliacaoControle atividadeAvaliacaoControle;
        int idEmpresa, idEmpregado, idCompetencia;

        public FrmConsultaAvaliacao()
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListaEmpregado(int empresaId)
        {
            empregadoControle = new EmpregadoControle();
            try
            {
                CbxEmpregado.Text = "";
                CbxEmpregado.DataSource = empregadoControle.EmpregadoComboBox(idEmpresa);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListaCompetencia(DateTime dtComp)
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                idCompetencia = competenciaControle.Id(dtComp);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void ListaAvalicao(int empresaId, int empregadoId, int competenciaId)
        {
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();
            LblMedia.Text = "Média: 0,00";
            int totalItens = 0;
            decimal media = 0, dcNota = 0;
            try
            {
                DgvAvaliacao.DataSource = atividadeAvaliacaoControle.AtividadeAvaliacaoTabela(empresaId, empregadoId, competenciaId);
                totalItens = DgvAvaliacao.Rows.Count;

                foreach (DataGridViewRow item in DgvAvaliacao.Rows)
                {
                    dcNota += decimal.Parse(item.Cells["Nota"].Value.ToString());
                }

                if (totalItens != 0)
                {
                    media = dcNota / totalItens;
                    LblMedia.Text = "Total: " + dcNota.ToString("#,##0.00") +
                                    " Média: " + media.ToString("#,##0.00");
                }

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
                CbxEmpregado_SelectedIndexChanged(e, e);
            }
        }

        private void MktCompetencia_Leave(object sender, EventArgs e)
        {
            try
            {
                CbxEmpregado_SelectedIndexChanged(e, e);
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
                ListaEmpregado(idEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpregado = int.Parse(CbxEmpregado.Text.Substring(0, CbxEmpregado.Text.IndexOf(' ')));
                dtCompetencia = DateTime.Parse(MktCompetencia.Text);
                ListaCompetencia(dtCompetencia);
                ListaAvalicao(idEmpresa, idEmpregado, idCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmConsultaAvaliacao_Load(object sender, EventArgs e)
        {
            competenciaControle = new CompetenciaControle();
            DateTime date = competenciaControle.CompetenciaAtiva();
            MktCompetencia.Text = date.ToString("MM/yyy");
            ListaEmpresa();
        }
    }
}
