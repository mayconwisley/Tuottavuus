using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroMetaPeso : Form
    {
        IndicadorControle indicadorControle;
        MetaPesoControle metaPesoControle;
        ValidarNumero validarNumero;
        MetaPeso metaPeso;

        int idIndicador = 0, idMetaPeso = 0;

        public FrmCadastroMetaPeso()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtMeta.Text = "0,00";
            TxtPeso.Text = "0,00";
        }

        private bool ListaIndicador()
        {
            indicadorControle = new IndicadorControle();

            try
            {
                CbxIndicador.DataSource = indicadorControle.IndicadorComboBox();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }
        private void ListarMetaPeso()
        {
            metaPesoControle = new MetaPesoControle();
            int totalMetaPeso = 0;
            try
            {
                DgvMetaPeso.DataSource = metaPesoControle.MetaPesoTabela();
                totalMetaPeso = DgvMetaPeso.Rows.Count;
                LblInfoMetaPeso.Text = "Meta/Peso - " + totalMetaPeso.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void Manipular(TipoManipulacao tipoManipulacao)
        {
            metaPeso = new MetaPeso();
            metaPesoControle = new MetaPesoControle();

            try
            {
                metaPeso.Id = idMetaPeso;
                metaPeso.Meta = double.Parse(TxtMeta.Text.Trim());
                metaPeso.Peso = double.Parse(TxtPeso.Text.Trim());
                metaPeso.Indicador = new Indicador();
                metaPeso.Indicador.Id = idIndicador;

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    metaPesoControle.Gravar(metaPeso);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    metaPesoControle.Alterar(metaPeso);
                }
                else
                {
                    metaPesoControle.Excluir(metaPeso);
                }
                ListarMetaPeso();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FrmCadastroMetaPeso_Load(object sender, EventArgs e)
        {
            ListaIndicador();
            ListarMetaPeso();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Manipular(TipoManipulacao.Alterar);
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Manipular(TipoManipulacao.Gravar);

        }

        private void CbxIndicador_SelectedIndexChanged(object sender, EventArgs e)
        {
            idIndicador = int.Parse(CbxIndicador.SelectedValue.ToString());
        }

        private void DgvMetaPeso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idMetaPeso = int.Parse(DgvMetaPeso.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                double dMeta, dPeso;
                dMeta = double.Parse(DgvMetaPeso.Rows[e.RowIndex].Cells["Meta"].Value.ToString());
                dPeso = double.Parse(DgvMetaPeso.Rows[e.RowIndex].Cells["Peso"].Value.ToString());
                TxtMeta.Text = dMeta.ToString("#,##0.00");
                TxtPeso.Text = dPeso.ToString("#,##0.00");
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void TxtMeta_TextChanged(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();

            TxtMeta.Text = validarNumero.Validar(TxtMeta.Text);
            TxtMeta.Select(TxtMeta.Text.Length, 0);
        }

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();

            TxtPeso.Text = validarNumero.Validar(TxtPeso.Text);
            TxtPeso.Select(TxtPeso.Text.Length, 0);
        }

        private void TxtMeta_Leave(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();
            TxtMeta.Text = validarNumero.Zero(TxtMeta.Text);
            TxtMeta.Text = validarNumero.Formatar(TxtMeta.Text);
        }

        private void TxtPeso_Leave(object sender, EventArgs e)
        {
            validarNumero = new ValidarNumero();
            TxtPeso.Text = validarNumero.Zero(TxtPeso.Text);
            TxtPeso.Text = validarNumero.Formatar(TxtPeso.Text);
        }

        private void TxtMeta_Enter(object sender, EventArgs e)
        {
            if (TxtMeta.Text == "0,00")
            {
                TxtMeta.Text = "";
            }
        }

        private void TxtPeso_Enter(object sender, EventArgs e)
        {
            if (TxtPeso.Text == "0,00")
            {
                TxtPeso.Text = "";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Manipular(TipoManipulacao.Excluir);

        }


    }
}
