using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCalcularPossoMais : Form
    {
        PossoMaisControle possoMaisControle;
        CompetenciaControle competenciaControle;
        EmpresaControle empresaControle;

        int idCompetencia, idEmpresa;
        DateTime dtCompetencia;

        public FrmCalcularPossoMais()
        {
            InitializeComponent();
        }
        private void ListaCompetencia()
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetencia = competenciaControle.CompetenciaAtiva();
                idCompetencia = competenciaControle.Id(dtCompetencia);
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

            }
        }

        private void ListaEmpresa()
        {
            empresaControle = new EmpresaControle();
            try
            {
                CbxEmpresa.DataSource = empresaControle.EmpresaComboBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

            }
        }

        private void ListaPossoMaisTabela(int competenciaId, int empresaId)
        {
            possoMaisControle = new PossoMaisControle();
            try
            {
                DgvPossoMais.DataSource = possoMaisControle.PossoMaisTabela(competenciaId, empresaId);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            FrmBarraCarregamento frmBarraCarregamento = new FrmBarraCarregamento('X', idCompetencia, idEmpresa)
            {
                MdiParent = FrmPrincipal.ActiveForm
            };
            frmBarraCarregamento.Show();
        }

        private void FrmCalcularPossoMais_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaPossoMaisTabela(idCompetencia, idEmpresa);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
