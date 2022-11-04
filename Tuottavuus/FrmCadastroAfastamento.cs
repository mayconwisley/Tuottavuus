using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroAfastamento : Form
    {
        EmpresaControle empresaControle;
        EmpregadoControle empregadoControle;
        CompetenciaControle competenciaControle;
        AfastamentoControle afastamentoControle;
        Afastamento afastamento;
        DateTime dtCompetencia;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0, idAfastamento = 0;

        private void FrmCadastroAfastamento_Load(object sender, EventArgs e)
        {

            ListaCompetencia();
            ListaEmpresa();
            ListarAfastamento(TxtPesquisa.Text.Trim());
        }

        public FrmCadastroAfastamento()
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
            empregadoControle = new EmpregadoControle();
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

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Maninupar(TipoManipulacao.Gravar);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Maninupar(TipoManipulacao.Alterar);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Maninupar(TipoManipulacao.Excluir);
        }

        private bool ListaCompetencia()
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetencia = competenciaControle.CompetenciaAtiva();
                idCompetencia = competenciaControle.Id(dtCompetencia);
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListarAfastamento(TxtPesquisa.Text.Trim());
        }

        private void DgvAfastamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idAfastamento = int.Parse(DgvAfastamento.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                idEmpregado = int.Parse(DgvAfastamento.Rows[e.RowIndex].Cells["Id_Empregado"].Value.ToString());

                CbxEmpregado.SelectedValue = idEmpregado;

                TxtTotalDias.Text = DgvAfastamento.Rows[e.RowIndex].Cells["Total_Dias"].Value.ToString();

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtTotalDias.Clear();
        }

        public void ListarAfastamento(string pesquisa)
        {
            afastamentoControle = new AfastamentoControle();

            try
            {
                string strPesquisa = $"%{pesquisa}%";
                DgvAfastamento.DataSource = afastamentoControle.AfastamentoTabela(strPesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Maninupar(TipoManipulacao tipoManipulacao)
        {
            afastamento = new Afastamento();
            afastamentoControle = new AfastamentoControle();

            try
            {
                try
                {
                    dtCompetencia = competenciaControle.CompetenciaAtiva();
                    idCompetencia = competenciaControle.Id(dtCompetencia.Date);
                }
                catch
                {
                    MessageBox.Show("Cadastrar competência!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                afastamento.Id = idAfastamento;
                afastamento.Competencia = new Competencia();
                afastamento.Competencia.Id = idCompetencia;
                afastamento.Empresa = new Empresa();
                afastamento.Empresa.Id = idEmpresa;
                afastamento.Empregado = new Empregado();
                afastamento.Empregado.Id = idEmpregado;

                afastamento.TotalDias = int.Parse(TxtTotalDias.Text.Trim());

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    afastamentoControle.Gravar(afastamento);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    afastamentoControle.Alterar(afastamento);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    afastamentoControle.Excluir(afastamento);
                }

                ListarAfastamento(TxtPesquisa.Text.Trim());
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
