using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroConfigAfastamento : Form
    {
        ConfigAfastamento configAfastamento;
        ConfigAfastamentoControle configAfastamentoControle;

        int idConfigAfastamento = 0;

        public FrmCadastroConfigAfastamento()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;

            if (DgvConfigAfastamento.Rows.Count > 0)
            {
                BtnGravar.Enabled = false;
            }
            TxtTotalDias.Clear();
        }

        public void ListarConfigAfastamento()
        {
            configAfastamentoControle = new ConfigAfastamentoControle();

            try
            {
                DgvConfigAfastamento.DataSource = configAfastamentoControle.ConfigAfastamentoTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Maninupar(TipoManipulacao tipoManipulacao)
        {
            configAfastamento = new ConfigAfastamento();
            configAfastamentoControle = new ConfigAfastamentoControle();


            try
            {
                configAfastamento.Id = idConfigAfastamento;
                configAfastamento.TotalDias = int.Parse(TxtTotalDias.Text.Trim());


                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    configAfastamentoControle.Gravar(configAfastamento);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    configAfastamentoControle.Alterar(configAfastamento);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    configAfastamentoControle.Excluir(configAfastamento);
                }

                ListarConfigAfastamento();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FrmCadastroConfigAfastamento_Load(object sender, EventArgs e)
        {
            ListarConfigAfastamento();
            Reset();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Maninupar(TipoManipulacao.Gravar);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Maninupar(TipoManipulacao.Alterar);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Maninupar(TipoManipulacao.Excluir);
        }

        private void DgvConfigAfastamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idConfigAfastamento = int.Parse(DgvConfigAfastamento.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtTotalDias.Text = DgvConfigAfastamento.Rows[e.RowIndex].Cells["Total_Dias"].Value.ToString();

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
