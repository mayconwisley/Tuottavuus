using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmPrincipal : Form
    {
        #region Formularios
        FrmCadastroEmpresa cadastroEmpresa;  // 0
        FrmCadastroEmpregado cadastroEmpregado; // 1
        FrmCadastroCompetencia cadastroCompetencia; // 2
        FrmCadastroFeriado cadastroFeriado; // 3
        FrmCadastroAtividade cadastroAtividade; // 4
        FrmCadastroAvaliacao cadastroAvaliacao; // 5
        FrmCadastroProdutividadeBase produtividadeBase; // 6
        FrmCadastroDepartamento cadastroDepartamento; // 7
        FrmCalculoProdutividade calculoProdutividade; //8
        FrmRelatorio relatorio; // 9
        FrmConsultaAvaliacao consultaAvaliacao; // 10
        FrmConsultaProdutividade consultaProdutividade; //11
        FrmConsultaAtividade consultaAtividade; //12
        FrmCadastroIndicador cadastroIndicador; //13
        FrmCadastroMetaPeso cadastroMetaPeso; //14
        FrmPesquisaAvaliacao pesquisaAvaliacao; //15
        FrmImportarPesquisa importarPesquisa; //16
        FrmPesquisaConsulta pesquisaConsulta; //17
        bool aberto = true;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(int formulario)
        {
            foreach (Form item in Application.OpenForms)
            {
                switch (formulario)
                {
                    case 0:
                        cadastroEmpresa = new FrmCadastroEmpresa();
                        cadastroEmpresa.MdiParent = this;
                        if (item is FrmCadastroEmpresa)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 1:
                        cadastroEmpregado = new FrmCadastroEmpregado();
                        cadastroEmpregado.MdiParent = this;
                        if (item is FrmCadastroEmpregado)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 2:
                        cadastroCompetencia = new FrmCadastroCompetencia();
                        cadastroCompetencia.MdiParent = this;
                        if (item is FrmCadastroCompetencia)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 3:
                        cadastroFeriado = new FrmCadastroFeriado();
                        cadastroFeriado.MdiParent = this;
                        if (item is FrmCadastroFeriado)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 4:
                        cadastroAtividade = new FrmCadastroAtividade();
                        cadastroAtividade.MdiParent = this;
                        if (item is FrmCadastroAtividade)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 5:
                        cadastroAvaliacao = new FrmCadastroAvaliacao();
                        cadastroAvaliacao.MdiParent = this;
                        if (item is FrmCadastroAvaliacao)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 6:
                        produtividadeBase = new FrmCadastroProdutividadeBase();
                        produtividadeBase.MdiParent = this;
                        if (item is FrmCadastroProdutividadeBase)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 7:
                        cadastroDepartamento = new FrmCadastroDepartamento();
                        cadastroDepartamento.MdiParent = this;
                        if (item is FrmCadastroDepartamento)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 8:
                        calculoProdutividade = new FrmCalculoProdutividade();
                        calculoProdutividade.MdiParent = this;
                        if (item is FrmCalculoProdutividade)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 9:
                        relatorio = new FrmRelatorio();
                        relatorio.MdiParent = this;
                        if (item is FrmRelatorio)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 10:
                        consultaAvaliacao = new FrmConsultaAvaliacao();
                        consultaAvaliacao.MdiParent = this;
                        if (item is FrmConsultaAvaliacao)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 11:
                        consultaProdutividade = new FrmConsultaProdutividade();
                        consultaProdutividade.MdiParent = this;
                        if (item is FrmConsultaProdutividade)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 12:
                        consultaAtividade = new FrmConsultaAtividade();
                        consultaAtividade.MdiParent = this;
                        if (item is FrmConsultaAtividade)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 13:
                        cadastroIndicador = new FrmCadastroIndicador();
                        cadastroIndicador.MdiParent = this;
                        if (item is FrmCadastroIndicador)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 14:
                        cadastroMetaPeso = new FrmCadastroMetaPeso();
                        cadastroMetaPeso.MdiParent = this;
                        if (item is FrmCadastroMetaPeso)
                        {
                            item.Focus();
                            aberto = false;
                        }

                        break;
                    case 15:
                        pesquisaAvaliacao = new FrmPesquisaAvaliacao();
                        pesquisaAvaliacao.MdiParent = this;
                        if (item is FrmPesquisaAvaliacao)
                        {
                            item.Focus();
                            aberto = false;
                        }

                        break;
                    case 16:
                        importarPesquisa = new FrmImportarPesquisa();
                        importarPesquisa.MdiParent = this;
                        if (item is FrmImportarPesquisa)
                        {
                            item.Focus();
                            aberto = false;
                        }
                        break;
                    case 17:
                        pesquisaConsulta = new FrmPesquisaConsulta();
                        pesquisaConsulta.MdiParent = this;
                        if (item is FrmPesquisaConsulta)
                        {
                            item.Focus();
                            aberto = false;
                        }


                        break;

                    default:
                        break;
                }
            }
            if (aberto)
            {
                switch (formulario)
                {
                    case 0:
                        cadastroEmpresa.Show();
                        break;
                    case 1:
                        cadastroEmpregado.Show();
                        break;
                    case 2:
                        cadastroCompetencia.Show();
                        break;
                    case 3:
                        cadastroFeriado.Show();
                        break;
                    case 4:
                        cadastroAtividade.Show();
                        break;
                    case 5:
                        cadastroAvaliacao.Show();
                        break;
                    case 6:
                        produtividadeBase.Show();
                        break;
                    case 7:
                        cadastroDepartamento.Show();
                        break;
                    case 8:
                        calculoProdutividade.Show();
                        break;
                    case 9:
                        relatorio.Show();
                        break;
                    case 10:
                        consultaAvaliacao.Show();
                        break;
                    case 11:
                        consultaProdutividade.Show();
                        break;
                    case 12:
                        consultaAtividade.Show();
                        break;
                    case 13:
                        cadastroIndicador.Show();
                        break;
                    case 14:
                        cadastroMetaPeso.Show();
                        break;
                    case 15:
                        pesquisaAvaliacao.Show();
                        break;
                    case 16:
                        importarPesquisa.Show();
                        break;
                    case 17:
                        pesquisaConsulta.Show();
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        private void SubMenuCadastroEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(0);
        }

        private void SubMenuCadastroEmpregado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(1);
        }

        private void SubMenuCadastroAtividade_Click(object sender, EventArgs e)
        {
            AbrirFormulario(4);
        }

        private void SubMenuCadastroCompetencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario(2);
        }

        private void SubMenuCadastroFeriado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(3);
        }

        private void SubMenuAvaliacaoAvaliar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(5);
        }

        private void SubMenuCadastroValorBaseProdutividade_Click(object sender, EventArgs e)
        {
            AbrirFormulario(6);
        }

        private void SubMenuCadastroDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(7);
        }

        private void SubMenuProdutividadeCalcular_Click(object sender, EventArgs e)
        {
            AbrirFormulario(8);
        }

        private void SubMenuRelatoriosRelatorio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(9);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is MdiClient)
                {
                    item.BackgroundImage = Properties.Resources.Tuattavuus;
                    item.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubMenuAvaliacaoConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(10);
        }

        private void SubMenuProdutividadeConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(11);
        }

        private void SubMenuAvaliacaoConsultaAtividade_Click(object sender, EventArgs e)
        {
            AbrirFormulario(12);
        }

        private void SubMenuCadastroIndicador_Click(object sender, EventArgs e)
        {
            AbrirFormulario(13);
        }

        private void SubMenuCadastroMetaPeso_Click(object sender, EventArgs e)
        {
            AbrirFormulario(14);
        }

        private void SubMenuPesquisaCadastrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(15);
        }

        private void SubMenuPesquisaImportar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(16);
        }

        private void SubMenuPesquisaConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(17);
        }
    }
}
