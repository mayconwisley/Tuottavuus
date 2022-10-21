using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroPesquisaAvaliacao : Form
    {
        EmpregadoControle empregadoControle;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        Pesquisa pesquisa;
        PesquisaControle pesquisaControle;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0, idPesquisa = 0, codigoEmpregado;
        string nomeEmpregado = string.Empty;

        DateTime dtCompetencia;

        public FrmCadastroPesquisaAvaliacao()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtNota.Text = "0";
            TxtChamado.Text = "0";
            MktDataAbertura.Text = "";
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
        private void FrmPesquisaAvaliacao_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
            ListaPesquisa();
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
        private void ListaPesquisa()
        {
            pesquisaControle = new PesquisaControle();
            int totalPesquisa = 0;
            try
            {
                DgvPesquisa.DataSource = pesquisaControle.PesquisaTabela();
                totalPesquisa = DgvPesquisa.Rows.Count;
                LblInfoPesquisa.Text = "Pesquisas - " + totalPesquisa.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private void DgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idPesquisa = int.Parse(DgvPesquisa.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                idEmpregado = int.Parse(DgvPesquisa.Rows[e.RowIndex].Cells["Id_Empregado"].Value.ToString());
                TxtChamado.Text = DgvPesquisa.Rows[e.RowIndex].Cells["Chamado"].Value.ToString();
                TxtNota.Text = DgvPesquisa.Rows[e.RowIndex].Cells["NotaConceito"].Value.ToString();
                MktDataAbertura.Text = DgvPesquisa.Rows[e.RowIndex].Cells["DataAbertura"].Value.ToString();

                CbxEmpregado.SelectedValue = idEmpregado;

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
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
            pesquisa = new Pesquisa();
            pesquisaControle = new PesquisaControle();

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
                pesquisa.Id = idPesquisa;
                pesquisa.Competencia = new Competencia();
                pesquisa.Competencia.Id = idCompetencia;
                pesquisa.Empresa = new Empresa();
                pesquisa.Empresa.Id = idEmpresa;
                pesquisa.Empregado = new Empregado();
                pesquisa.Empregado.Id = idEmpregado;
                pesquisa.CodigoAtendente = codigoEmpregado;
                pesquisa.NomeAtendente = nomeEmpregado;

                pesquisa.DataAbertura = DateTime.Parse(MktDataAbertura.Text);
                pesquisa.NomeAtendente = "";
                pesquisa.NotaConceito = int.Parse(TxtNota.Text.Trim());
                pesquisa.Chamado = int.Parse(TxtChamado.Text.Trim());

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    pesquisaControle.Gravar(pesquisa);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    pesquisaControle.Alterar(pesquisa);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    pesquisaControle.Excluir(pesquisa);
                }

                ListaPesquisa();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
