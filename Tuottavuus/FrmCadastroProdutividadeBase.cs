using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroProdutividadeBase : Form
    {
        ProdutividadeValorBase produtividadeValorBase;
        ProdutividadeValorBaseControle produtividadeValorBaseControle;
        ValidarNumero validarNumero;
        int idProdutividadeValorBase;

        public FrmCadastroProdutividadeBase()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            TxtValor.Clear();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
        }

        private bool ListaValores()
        {
            produtividadeValorBaseControle = new ProdutividadeValorBaseControle();
            try
            {
                DgvValores.DataSource = produtividadeValorBaseControle.ProdutividadeValorBasesTabela();
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
            produtividadeValorBase = new ProdutividadeValorBase();
            produtividadeValorBaseControle = new ProdutividadeValorBaseControle();
            try
            {
                produtividadeValorBase.Id = idProdutividadeValorBase;
                produtividadeValorBase.DataCadastro = DtDataCadastro.Value;
                produtividadeValorBase.Valor = double.Parse(TxtValor.Text.Trim());

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    produtividadeValorBaseControle.Gravar(produtividadeValorBase);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    produtividadeValorBaseControle.Alterar(produtividadeValorBase);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    produtividadeValorBaseControle.Excluir(produtividadeValorBase);
                }
                ListaValores();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void FrmCadastroProdutividadeBase_Load(object sender, EventArgs e)
        {
            ListaValores();
        }

        private void DgvValores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idProdutividadeValorBase = int.Parse(DgvValores.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DtDataCadastro.Text = DgvValores.Rows[e.RowIndex].Cells["DataCadastro"].Value.ToString();
                decimal valor = decimal.Parse(DgvValores.Rows[e.RowIndex].Cells["Valor"].Value.ToString());
                TxtValor.Text = valor.ToString("#,##0.00");
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

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();
            TxtValor.Text = validarNumero.Validar(TxtValor.Text);
            TxtValor.Select(TxtValor.Text.Length, 0);
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();
            TxtValor.Text = validarNumero.Zero(TxtValor.Text);
            TxtValor.Text = validarNumero.Formatar(TxtValor.Text);
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            if (TxtValor.Text == "0,00")
            {
                TxtValor.Text = "";
            }
        }
    }
}
