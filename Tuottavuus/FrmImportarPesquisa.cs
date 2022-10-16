using Controle;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Tuottavuus
{
    public partial class FrmImportarPesquisa : Form
    {
        Empresa empresa;
        EmpresaControle empresaControle;
        CompetenciaControle competenciaControle;

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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
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
            string caminhoErro;
            caminhoErro = Application.StartupPath + @"\ErroImportacao\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt";
            try
            {
                pesquisaControle.ImportarAquivo(idCompetencia, idEmpresa, TxtCaminhoArquivo.Text, out itensErros);

                if (itensErros.Count > 0)
                {

                    string diretorio = Application.StartupPath + @"\ErroImportacao";

                    if (!Directory.Exists(diretorio))
                    {
                        Directory.CreateDirectory(diretorio);
                    }

                    StreamWriter sw = File.CreateText(caminhoErro);

                    sw.WriteLine("Erro: Codigo do atendente não encontrado no sistema");
                    for (int i = 0; i < itensErros.Count; i++)
                    {
                        sw.WriteLine(itensErros[i].ToString());

                    }

                    sw.Close();
                    MessageBox.Show("Houve erros de importação","Erro");

                }
                else
                {
                    MessageBox.Show("Arquivo importado com sucesso", "Sucesso");
                }

                Process.Start(caminhoErro);
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
