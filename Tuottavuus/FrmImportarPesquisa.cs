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
            FrmBarraCarregamento frm = new FrmBarraCarregamento('P', idCompetencia, idEmpresa, 0, TxtCaminhoArquivo.Text.Trim());
            frm.MdiParent = FrmPrincipal.ActiveForm;
            frm.Show();
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
