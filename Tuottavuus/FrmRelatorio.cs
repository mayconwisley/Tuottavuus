using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmRelatorio : Form
    {
        EmpresaControle empresaControle;
        EmpregadoControle empregadoControle;
        CompetenciaControle competenciaControle;
        Departamento departamento;
        DepartamentoControle departamentoControle;
        DateTime dtCompetencia;
        int idEmpregado, idEmpresa, idCompetencia, idDepartamento;

        FrmVisualizarRelatorio visualizarRelatorio;

        public FrmRelatorio()
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
                CbxEmpregado.DataSource = empregadoControle.EmpregadoComboBox(empresaId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void CompetenciaAtiva()
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                MktCompetencia.Text = competenciaControle.CompetenciaAtiva().ToString("MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ListaDepartamento()
        {
            departamentoControle = new DepartamentoControle();
            try
            {
                CbxDepartamento.DataSource = departamentoControle.DepartamentoTabela();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void TipoRelatorio()
        {
            int index = CbxItensRelatorio.SelectedIndex;
            int numRelatorio = 0;
            competenciaControle = new CompetenciaControle();

            try
            {
                dtCompetencia = DateTime.Parse(MktCompetencia.Text);
                idCompetencia = competenciaControle.Id(dtCompetencia);

                if (RbEmpresa.Checked && index == 0)
                {
                    numRelatorio = 1;
                }
                else if (RbEmpresa.Checked && index == 1)
                {
                    numRelatorio = 2;
                }
                else if (RbEmpresa.Checked && index == 2)
                {
                    numRelatorio = 0;
                    MessageBox.Show("Relatório indisponível para esta opção.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else if (RbEmpregado.Checked && index == 0)
                {
                    numRelatorio = 7;
                }
                else if (RbEmpregado.Checked && index == 1)
                {
                    numRelatorio = 5;
                }
                else if (RbEmpregado.Checked && index == 2)
                {
                    numRelatorio = 6;
                }
                else if (RbDepartamento.Checked && index == 0)
                {
                    numRelatorio = 4;
                }
                else if (RbDepartamento.Checked && index == 1)
                {
                    numRelatorio = 8;
                }
                else if (RbDepartamento.Checked && index == 2)
                {
                    numRelatorio = 3;
                }
                visualizarRelatorio = new FrmVisualizarRelatorio(numRelatorio, idEmpresa, idEmpregado, idDepartamento, idCompetencia, dtCompetencia.Date);
                visualizarRelatorio.MdiParent = FrmPrincipal.ActiveForm;
                visualizarRelatorio.Show();
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

        private void CbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamento = new Departamento();
            departamentoControle = new DepartamentoControle();
            try
            {
                departamento.Descricao = CbxDepartamento.Text;
                idDepartamento = departamentoControle.Id(departamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (RbEmpresa.Checked)
            {
                CbxEmpresa.Enabled = true;
                CbxEmpregado.Enabled = false;
                CbxDepartamento.Enabled = false;
            }
        }

        private void RbEmpregado_CheckedChanged(object sender, EventArgs e)
        {
            if (RbEmpregado.Checked)
            {
                CbxEmpregado.Enabled = true;
                CbxEmpresa.Enabled = true;
                CbxDepartamento.Enabled = false;
            }
        }

        private void RbDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDepartamento.Checked)
            {
                CbxDepartamento.Enabled = true;
                CbxEmpresa.Enabled = true;
                CbxEmpregado.Enabled = false;
            }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            TipoRelatorio();
        }

        private void CbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpregado = int.Parse(CbxEmpregado.Text.Substring(0, CbxEmpregado.Text.IndexOf(' ')));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            CbxItensRelatorio.SelectedIndex = 0;
            ListaEmpresa();
            CompetenciaAtiva();
            ListaDepartamento();
        }
    }
}
