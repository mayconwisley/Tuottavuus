using Controle;
using Modelo;
using System;
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

        private bool ListaIndicador()
        {
            indicadorControle = new IndicadorControle();
            int totalIndicador = 0;
            try
            {
                DgvIndicadors.DataSource = indicadorControle.IndicadorTabela();
                totalIndicador = DgvIndicadors.Rows.Count;
                LblInfoIndicador.Text = "Indicadores - " + totalIndicador.ToString("00");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                ListaIndicador();
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void FrmCadastroIndicador_Load(object sender, EventArgs e)
        {
            ListaIndicador();
        }

        private void DgvIndicadors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idIndicador = int.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtDescricao.Text = DgvIndicadors.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                bool ativo = bool.Parse(DgvIndicadors.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
                if (ativo == true)
                {
                    CbAtivo.Checked = true;
                }
                else
                {
                    CbAtivo.Checked = false;
                }

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
