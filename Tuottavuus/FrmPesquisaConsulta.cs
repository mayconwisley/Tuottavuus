using Controle;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmPesquisaConsulta : Form
    {

        EmpregadoControle empregadoControle;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0;

        DateTime dtCompetencia;

        public FrmPesquisaConsulta()
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

        private void FrmPesquisaConsulta_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaEmpregado(idEmpresa);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpregado = int.Parse(CbxEmpregado.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private bool ListaEmpregado(int empresaId)
        {
            empregadoControle = new EmpregadoControle();

            try
            {
                CbxEmpregado.DataSource = empregadoControle.EmpregadoComboBox(empresaId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }
        private bool ListaCompetencia()
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
