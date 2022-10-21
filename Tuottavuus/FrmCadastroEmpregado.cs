using Controle;
using Modelo;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroEmpregado : Form
    {
        Empregado empregado;
        EmpregadoControle empregadoControle;
        Empresa empresa;
        EmpresaControle empresaControle;
        Utilitarios utilitarios;
        LayoutImportacao layoutImportacao;
        DepartamentoControle departamentoControle;
        AtividadeAvaliacao atividadeAvaliacao;
        AtividadeAvaliacaoControle atividadeAvaliacaoControle;
        Produtividade produtividade;
        ProdutividadeControle produtividadeControle;
        CompetenciaControle competenciaControle;
        DateTime dtCompetencia;
        int idEmpregado = 0, idEmpresa = 0, idDepartamento = 0, idCompetencia = 0;

        public FrmCadastroEmpregado()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            TxtNome.Clear();
            TxtCodigo.Clear();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtNome.Focus();
        }

        private bool ListaEmpregado()
        {
            empregadoControle = new EmpregadoControle();
            int totalEmpregado = 0;
            try
            {
                DgvEmpregado.DataSource = empregadoControle.EmpregadoTabela();
                totalEmpregado = DgvEmpregado.Rows.Count;
                LblInfoEmpregado.Text = "Empregados cadastrados - " + totalEmpregado.ToString("00");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
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
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private bool Manipular(TipoManipulacao tipoManipulacao)
        {
            empregado = new Empregado();
            empregadoControle = new EmpregadoControle();
            atividadeAvaliacao = new AtividadeAvaliacao();
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();
            produtividade = new Produtividade();
            produtividadeControle = new ProdutividadeControle();
            competenciaControle = new CompetenciaControle();
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
                    return false;
                }

                //Trava a manutencao para que o usuario exclua o calculo da produtividade antes de alterar qualquer dados.
                int numCalculo = produtividadeControle.NumCalculados(idCompetencia, idEmpresa);
                int numEmpregados = DgvEmpregado.Rows.Count;
                if (numCalculo == numEmpregados && numEmpregados != 0)
                {
                    MessageBox.Show("Empresa com produtividade calculada para competência: " + dtCompetencia.ToString("MM/yyyy") +
                                    "\nEfetue o cancelamento do calculo para fazer alterações no cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    return false;
                }

                empregado.Id = idEmpregado;
                empregado.Nome = TxtNome.Text.Trim();
                empregado.Codigo = TxtCodigo.Text.Trim();
                if (CbxAtivo.Checked)
                {
                    empregado.Ativo = true;
                }
                else
                {
                    empregado.Ativo = false;
                }
                empregado.Empresa = new Empresa();
                empregado.Empresa.Id = idEmpresa;
                empregado.Departamento = new Departamento();
                empregado.Departamento.Id = idDepartamento;

                atividadeAvaliacao.Empresa = new Empresa();
                atividadeAvaliacao.Empresa.Id = idEmpresa;
                atividadeAvaliacao.Empregado = new Empregado();
                atividadeAvaliacao.Empregado.Id = idEmpregado;

                produtividade.Empresa = new Empresa();
                produtividade.Empresa.Id = idEmpresa;
                produtividade.Empregado = new Empregado();
                produtividade.Empregado.Id = idEmpregado;

                bool isCodigo = empregadoControle.IsCodigo(int.Parse(TxtCodigo.Text), idEmpregado);

                if (isCodigo)
                {
                    MessageBox.Show("Código de Empregado já informado para outro Empregado.\nRevise as informações", "Aviso");
                    return false;
                }


                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    empregadoControle.Gravar(empregado);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    empregadoControle.Alterar(empregado);
                    atividadeAvaliacaoControle.AlterarAtividadeEmpregado(atividadeAvaliacao);
                    produtividadeControle.AlterarEmpresaProdutividade(produtividade);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    empregadoControle.Excluir(empregado);
                }

                ListaEmpregado();
                Reset();
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
            Manipular(TipoManipulacao.Gravar);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Manipular(TipoManipulacao.Alterar);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            Manipular(TipoManipulacao.Excluir);
        }

        private void DgvEmpregado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idEmpregado = int.Parse(DgvEmpregado.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtNome.Text = DgvEmpregado.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                CbxEmpresa.Text = DgvEmpregado.Rows[e.RowIndex].Cells["NomeEmpresa"].Value.ToString();
                CbxDepartamento.Text = DgvEmpregado.Rows[e.RowIndex].Cells["DepartamentoDescricao"].Value.ToString();
                TxtCodigo.Text = DgvEmpregado.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                bool ativo = bool.Parse(DgvEmpregado.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());

                if (ativo)
                {
                    CbxAtivo.Checked = true;
                }
                else
                {
                    CbxAtivo.Checked = false;
                }
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {

            utilitarios = new Utilitarios();
            string caminhoArquivo = utilitarios.CaminhoArquivo();

            FrmBarraCarregamento frm = new FrmBarraCarregamento('E', 0, idEmpresa, idDepartamento, caminhoArquivo.Trim());
            frm.MdiParent = FrmPrincipal.ActiveForm;
            frm.Show();
        }

        private void LblLayoutImportacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilitarios = new Utilitarios();
            layoutImportacao = new LayoutImportacao();

            try
            {
                utilitarios.SalvarArquivo(layoutImportacao.Empregado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            empresa = new Empresa();
            try
            {
                empresa.Nome = CbxEmpresa.Text;
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idDepartamento = int.Parse(CbxDepartamento.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FrmCadastroEmpregado_Load(object sender, EventArgs e)
        {
            ListaEmpresa();
            ListaDepartamento();
            ListaEmpregado();
        }
    }
}
