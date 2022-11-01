using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroChamado : Form
    {
        EmpresaControle empresaControle;
        EmpregadoControle empregadoControle;
        CompetenciaControle competenciaControle;
        ChamadoControle chamadoControle;
        Chamado chamado;
        DateTime dtCompetencia;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0, idChamado = 0, codigoEmpregado;
        string nomeEmpregado = string.Empty;

        public FrmCadastroChamado()
        {
            InitializeComponent();
        }

        private void ListaChamado(string nomeAtendente)
        {
            chamadoControle = new ChamadoControle();

            try
            {
                string strNomeAtendente = $"%{nomeAtendente}%";
                DgvChamado.DataSource = chamadoControle.ChamadoTabela(strNomeAtendente);
                int totalPesquisa = DgvChamado.Rows.Count;
                LblInfoChamado.Text = "Chamados - " + totalPesquisa.ToString("00");
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
                codigoEmpregado = empregadoControle.CodigoPorId(idEmpregado);
                nomeEmpregado = empregadoControle.NomePorId(idEmpregado);

                LblInfoCodigoAtendente.Text = "Código Atendente: " + codigoEmpregado.ToString("00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FrmCadastroChamado_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
            ListaChamado(TxtPesquisa.Text.Trim());
        }

        private void DgvChamado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idChamado = int.Parse(DgvChamado.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                idEmpregado = int.Parse(DgvChamado.Rows[e.RowIndex].Cells["Id_Empregado"].Value.ToString());
                idEmpresa = int.Parse(DgvChamado.Rows[e.RowIndex].Cells["Id_Empresa"].Value.ToString());

                TxtChamado.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoChamado"].Value.ToString();
                TxtCodGpSolucao.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoGrupoSolucao"].Value.ToString();
                TxtCodNatureza.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoNatureza"].Value.ToString();
                TxtCodTpAtividade.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoTpAtividade"].Value.ToString();

                TxtDescGrupoSolucao.Text = DgvChamado.Rows[e.RowIndex].Cells["DescGrupoSolucao"].Value.ToString();
                TxtDescNatureza.Text = DgvChamado.Rows[e.RowIndex].Cells["DescNatureza"].Value.ToString();
                TxtDescTpAtividade.Text = DgvChamado.Rows[e.RowIndex].Cells["DescTpAtividade"].Value.ToString();

                MktDataAbertura.Text = DgvChamado.Rows[e.RowIndex].Cells["DataAbertura"].Value.ToString();

                CbxEmpregado.SelectedValue = idEmpregado;
                CbxEmpresa.SelectedValue = idEmpresa;

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
            TxtChamado.Text = "0";

            TxtCodGpSolucao.Text = "0";
            TxtCodNatureza.Text = "0";
            TxtCodTpAtividade.Text = "0";

            TxtDescGrupoSolucao.Clear();
            TxtDescNatureza.Clear();
            TxtDescTpAtividade.Clear();
            MktDataAbertura.Text = "";
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

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListaChamado(TxtPesquisa.Text.Trim());
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
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void Maninupar(TipoManipulacao tipoManipulacao)
        {
            chamado = new Chamado();
            chamadoControle = new ChamadoControle();

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
                chamado.Id = idChamado;
                chamado.Competencia = new Competencia();
                chamado.Competencia.Id = idCompetencia;
                chamado.Empresa = new Empresa();
                chamado.Empresa.Id = idEmpresa;
                chamado.Empregado = new Empregado();
                chamado.Empregado.Id = idEmpregado;

                chamado.DataAbertura = DateTime.Parse(MktDataAbertura.Text);
                chamado.CodigoChamado = int.Parse(TxtChamado.Text.Trim());
                chamado.CodigoGrupoSolucao = int.Parse(TxtCodGpSolucao.Text.Trim());
                chamado.DescGrupoSolucao = TxtDescGrupoSolucao.Text.Trim();
                chamado.CodigoAtendente = codigoEmpregado;
                chamado.NomeAtendente = CbxEmpregado.Text.Trim();
                chamado.CodigoNatureza = int.Parse(TxtDescNatureza.Text.Trim());
                chamado.DescNatureza = TxtDescNatureza.Text;
                chamado.CodigoTpAtividade = int.Parse(TxtCodTpAtividade.Text.Trim());
                chamado.DescTpAtividade = TxtDescTpAtividade.Text.Trim();

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    chamadoControle.Gravar(chamado);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    chamadoControle.Alterar(chamado);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    chamadoControle.Excluir(chamado);
                }

                ListaChamado(TxtPesquisa.Text.Trim());
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
