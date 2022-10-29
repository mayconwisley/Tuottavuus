using Controle;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmBarraCarregamento : Form
    {
        Utilitarios utilitarios;
        EmpregadoControle empregadoControle;
        PesquisaControle pesquisaControle;
        ChamadoControle chamadoControle;
        PossoMaisControle possoMaisControle;

        int idCompetencia = 0, idEmpresa = 0, idDepartamento = 0;

        string strCaminho;
        char opc;

        bool booImportar = true;

        public FrmBarraCarregamento()
        {
            InitializeComponent();

        }

        public FrmBarraCarregamento(char impOpc, int competenciaId = 0, int empresaId = 0, int departamentoId = 0, string caminho = "") : this()
        {
            opc = impOpc;
            idCompetencia = competenciaId;
            idEmpresa = empresaId;
            idDepartamento = departamentoId;
            strCaminho = caminho;
        }

        public FrmBarraCarregamento(char impOpc, int competenciaId, int empresaId) : this()
        {
            opc = impOpc;
            idCompetencia = competenciaId;
            idEmpresa = empresaId;
        }

        private void FrmBarraCarregamento_Enter(object sender, EventArgs e)
        {
            if (opc == 'X')
            {
                this.Text = "Calculando Posso Mais";
                CalculoPossoMais();
            }
            else
            {
                Importar();
            }

        }
        private void CalculoPossoMais()
        {
            possoMaisControle = new PossoMaisControle(ref PbBarraCarregamento);

            try
            {
                possoMaisControle.Calcular(idCompetencia, idEmpresa);
                MessageBox.Show("Posso Mais Calculado.", "Aviso");
                this.BeginInvoke(new MethodInvoker(Close));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }


        }
        private void Importar()
        {
            utilitarios = new Utilitarios();
            empregadoControle = new EmpregadoControle(ref PbBarraCarregamento);
            pesquisaControle = new PesquisaControle(ref PbBarraCarregamento);
            chamadoControle = new ChamadoControle(ref PbBarraCarregamento);
            ArrayList itensErros = new ArrayList();
            int qtdAtualizados = 0, qtdGravados = 0;
            string caminhoErro = Application.StartupPath + @"\ErroImportacao";
            try
            {
                if (opc == 'P')
                {
                    booImportar = pesquisaControle.ImportarAquivo(idCompetencia, idEmpresa, strCaminho, out itensErros, out qtdAtualizados, out qtdGravados);
                    if (pesquisaControle.ErroLista(caminhoErro, itensErros))
                    {
                        MessageBox.Show($"Erros ao gravar arquivo\n\n\nGravados: {qtdGravados.ToString("00")} empregado(s).\n" +
                                        $"Atualizados: {qtdAtualizados.ToString("00")} empregado(s)", "Aviso");
                    }
                    else
                    {
                        MessageBox.Show($"Gravados: {qtdGravados.ToString("00")} empregado(s).\n" +
                                        $"Atualizados: {qtdAtualizados.ToString("00")} empregado(s)", "Aviso");

                    }
                }
                else if (opc == 'E')
                {
                    booImportar = empregadoControle.ImportarEmpregado(idEmpresa, idDepartamento, strCaminho, out qtdAtualizados, out qtdGravados);

                    MessageBox.Show($"Gravados: {qtdGravados.ToString("00")} empregado(s).\n" +
                                    $"Atualizados: {qtdAtualizados.ToString("00")} empregado(s)", "Aviso");

                }
                else if (opc == 'C')
                {
                    booImportar = chamadoControle.ImportarAquivo(idCompetencia, idEmpresa, strCaminho, out itensErros, out qtdAtualizados, out qtdGravados);
                    if (chamadoControle.ErroLista(caminhoErro, itensErros))
                    {
                        MessageBox.Show($"Erros ao gravar arquivo\n\n\nGravados: {qtdGravados.ToString("00")} empregado(s).\n" +
                                        $"Atualizados: {qtdAtualizados.ToString("00")} empregado(s)", "Aviso");
                    }
                    else
                    {
                        MessageBox.Show($"Gravados: {qtdGravados.ToString("00")} empregado(s).\n" +
                                        $"Atualizados: {qtdAtualizados.ToString("00")} empregado(s)", "Aviso");

                    }
                }
                this.BeginInvoke(new MethodInvoker(Close));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
