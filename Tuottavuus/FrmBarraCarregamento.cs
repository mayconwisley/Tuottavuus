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

namespace Tuottavuus
{
    public partial class FrmBarraCarregamento : Form
    {
        Utilitarios utilitarios;
        EmpregadoControle empregadoControle;

        PesquisaControle pesquisaControle;

        int idEmpresa = 0, idDepartamento = 0;
        string strCaminho;
        public FrmBarraCarregamento()
        {
            InitializeComponent();
          
        }

        public FrmBarraCarregamento(int empresaId, int departamentoId, string caminho) : this()
        {
            idEmpresa = empresaId;
            idDepartamento = departamentoId;
            strCaminho = caminho;
        }

        private void BWProcessamento_DoWork(object sender, DoWorkEventArgs e)
        {
            ImportarEmpregado();
        }

        private void BWProcessamento_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void FrmBarraCarregamento_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmBarraCarregamento_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmBarraCarregamento_Activated(object sender, EventArgs e)
        {
          
           
        }

        private void FrmBarraCarregamento_Enter(object sender, EventArgs e)
        {
           
            ImportarEmpregado();
          

        }

        private void ImportarEmpregado()
        {
            utilitarios = new Utilitarios();
            empregadoControle = new EmpregadoControle();
            pesquisaControle = new PesquisaControle(ref LblRegistro, ref LblPorcentagem, ref PbBarraCarregamento);
            ArrayList arquivo = new ArrayList();
            int qtdAtualizados = 0, qtdGravados = 0;

            try
            {

                pesquisaControle.ImportarAquivo(idEmpresa, idDepartamento, strCaminho, out arquivo, out qtdAtualizados, out qtdGravados);

                MessageBox.Show($"Gravados: {qtdGravados.ToString("00")} empregado(s).\n" +
                $"Atualizados: {qtdAtualizados.ToString("00")} empregado(s)", "Aviso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
