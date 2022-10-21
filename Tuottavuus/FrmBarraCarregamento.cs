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

        private void FrmBarraCarregamento_Activated(object sender, EventArgs e)
        {
            Importar();
        }

        public void Fechar()
        {
            this.Close();
        }

        private void Importar()
        {
            utilitarios = new Utilitarios();
            empregadoControle = new EmpregadoControle(ref PbBarraCarregamento);
            pesquisaControle = new PesquisaControle(ref PbBarraCarregamento);
            ArrayList itensErros = new ArrayList();
            int qtdAtualizados = 0, qtdGravados = 0;


            try
            {

                if (opc == 'P')
                {
                    booImportar = pesquisaControle.ImportarAquivo(idCompetencia, idEmpresa, strCaminho, out itensErros, out qtdAtualizados, out qtdGravados);

                }
                else if (opc == 'E')
                {
                    booImportar = empregadoControle.ImportarEmpregado(idEmpresa, idDepartamento, strCaminho, out qtdAtualizados, out qtdGravados);
                }

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
