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

        int idEmpresa = 0, idDepartamento = 0;
        public FrmBarraCarregamento()
        {
            InitializeComponent();
        }

        public FrmBarraCarregamento(int empresaId, int departamentoId)
        {
            idEmpresa = empresaId;
            idDepartamento = departamentoId;
        }

        private void BWProcessamento_DoWork(object sender, DoWorkEventArgs e)
        {
            ImportarEmpregado();
        }

        private void BWProcessamento_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void ImportarEmpregado()
        {
            utilitarios = new Utilitarios();
            empregadoControle = new EmpregadoControle();
            ArrayList arquivo = new ArrayList();
            int qtdAtualizados = 0, qtdGravados = 0;
            try
            {
                string caminhoArquivo = utilitarios.CaminhoArquivo();

                empregadoControle.ImportarEmpregado(idEmpresa, idDepartamento, caminhoArquivo, out qtdAtualizados, out qtdGravados);

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
