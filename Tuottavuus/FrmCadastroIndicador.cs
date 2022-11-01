using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroIndicador : Form
    {
        Indicador indicador;
        IndicadorControle indicadorControle;
        int idIndicador = 0;

        public FrmCadastroIndicador()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            TxtDescricao.Clear();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtDescricao.Focus();
        }

        private bool ListaIndicador(string descricao)
        {
            indicadorControle = new IndicadorControle();
            int totalIndicador = 0;
            try
            {
                string strDecricao = $"%{descricao}%";
                DgvIndicadors.DataSource = indicadorControle.IndicadorTabela(strDecricao);
                totalIndicador = DgvIndicadors.Rows.Count;
                LblInfoIndicador.Text = "Indicadores - " + totalIndicador.ToString("00");
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
            indicador = new Indicador();
            indicadorControle = new IndicadorControle();

            try
            {
                indicador.Id = idIndicador;
                indicador.Descricao = TxtDescricao.Text.Trim();
                if (CbAtivo.Checked)
                {
                    indicador.Ativo = true;
                }
                else
                {
                    indicador.Ativo = false;
                }

                if (CbPesquisa.Checked)
                {
                    indicador.Pesquisa = true;
                }
                else
                {
                    indicador.Pesquisa = false;
                }

                if (CbChamado.Checked)
                {
                    indicador.Chamado = true;
                }
                else
                {
                    indicador.Chamado = false;
                }

                if (CbAssiduidade.Checked)
                {
                    indicador.Assiduidade = true;
                }
                else
                {
                    indicador.Assiduidade = false;
                }

                if (CbCaptura.Checked)
                {
                    indicador.Captura = true;
                }
                else
                {
                    indicador.Captura = false;
                }

                if (CbFeedback.Checked)
                {
                    indicador.Feedback = true;
                }
                else
                {
                    indicador.Feedback = false;
                }

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    indicadorControle.Gravar(indicador);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    indicadorControle.Alterar(indicador);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    indicadorControle.Excluir(indicador);
                }
                ListaIndicador(TxtPesquisa.Text.Trim());
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }

        }

        private void FrmCadastroIndicador_Load(object sender, EventArgs e)
        {
            ListaIndicador(TxtPesquisa.Text.Trim());
        }

        private void DgvIndicadors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idIndicador = int.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtDescricao.Text = DgvIndicadors.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                bool ativo = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
                bool pesquisa = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["PesquisaIndicador"].Value.ToString());
                bool chamado = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Chamado"].Value.ToString());
                bool assiduidade = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Assiduidade"].Value.ToString());
                bool captura = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Captura"].Value.ToString());
                bool feedback = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Feedback"].Value.ToString());
                if (ativo == true)
                {
                    CbAtivo.Checked = true;
                }
                else
                {
                    CbAtivo.Checked = false;
                }

                if (pesquisa)
                {
                    CbPesquisa.Checked = true;
                }
                else
                {
                    CbPesquisa.Checked = false;
                }
                if (chamado)
                {
                    CbChamado.Checked = true;
                }
                else
                {
                    CbChamado.Checked = false;
                }
                if (assiduidade)
                {
                    CbAssiduidade.Checked = true;
                }
                else
                {
                    CbAssiduidade.Checked = false;
                }
                if (captura)
                {
                    CbCaptura.Checked = true;
                }
                else
                {
                    CbCaptura.Checked = false;
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

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListaIndicador(TxtPesquisa.Text.Trim());
        }
    }
}
