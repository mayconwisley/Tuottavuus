using Controle;
using Modelo;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmImportarPesquisa : Form
    {
        Empresa empresa;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;
        Utilitarios utilitarios;
        LayoutImportacao layoutImportacao;

        PesquisaControle pesquisaControle;
        private int idCompetencia = 0, idEmpresa = 0;
        DateTime dtCompetencia;

        public FrmImportarPesquisa()
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
        private void ProcurarArquivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Selecione um arquivo";
            openFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TxtCaminhoArquivo.Text = openFileDialog.FileName;
            }
        }
        private void FrmImportarPesquisa_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
        }
        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            ProcurarArquivo();
        }
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            pesquisaControle = new PesquisaControle();
            ArrayList itensErros = new ArrayList();
            int qtdAtualizados = 0, qtdGravados = 0;

            try
            {

                //FrmBarraCarregamento frm = new FrmBarraCarregamento(idEmpresa, 1, TxtCaminhoArquivo.Text);
                ////frm.MdiParent = FrmPrincipal.ActiveForm;
                //frm.ShowDialog();


                pesquisaControle.ImportarAquivo(idCompetencia, idEmpresa, TxtCaminhoArquivo.Text, out itensErros, out qtdAtualizados, out qtdGravados);
                string diretorio = Application.StartupPath + @"\ErroImportacao";

                bool pesquisa = pesquisaControle.ErroLista(diretorio, itensErros);

                if (pesquisa)
                {
                    MessageBox.Show($"Alguns dados não foram importado\n\n\nGravados: {qtdGravados.ToString("00")} pesquisa(s).\n" +
                               $"Atualizados: {qtdAtualizados.ToString("00")} pesquisa(s)", "Aviso");
                }
                else
                {
                    MessageBox.Show($"Gravados: {qtdGravados.ToString("00")} pesquisa(s).\n" +
                                   $"Atualizados: {qtdAtualizados.ToString("00")} pesquisa(s)", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private void LblLayoutImportacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilitarios = new Utilitarios();
            layoutImportacao = new LayoutImportacao();

            try
            {
                utilitarios.SalvarArquivo(layoutImportacao.Pesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //FrmBarraCarregamento frm = new FrmBarraCarregamento(idEmpresa, 1, TxtCaminhoArquivo.Text);
            ////frm.MdiParent = FrmPrincipal.ActiveForm;
            //frm.ShowDialog();
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
    }
}
