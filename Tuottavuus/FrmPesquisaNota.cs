using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmPesquisaNota : Form
    {
        PesquisaNota pesquisaNota;
        PesquisaNotaControle pesquisaNotaControle;

        int idNota = 0;

        public FrmPesquisaNota()
        {
            InitializeComponent();
        }

        private void ListarNota()
        {
            pesquisaNotaControle = new PesquisaNotaControle();

            try
            {
                DgvNota.DataSource = pesquisaNotaControle.PesquisaNotaTabela();
                int totalNota = DgvNota.Rows.Count;
                LblInfoNota.Text = "Nota - " + totalNota.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Manipular(TipoManipulacao tipoManipulacao)
        {
            pesquisaNota = new PesquisaNota();
            pesquisaNotaControle = new PesquisaNotaControle();

            try
            {
                pesquisaNota.Id = idNota;
                pesquisaNota.Nota = int.Parse(TxtNota.Text.Trim());
                pesquisaNota.Data = DateTime.Parse(MktData.Text);

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    pesquisaNotaControle.Gravar(pesquisaNota);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    pesquisaNotaControle.Alterar(pesquisaNota);
                }
                else
                {
                    pesquisaNotaControle.Excluir(pesquisaNota);
                }

                ListarNota();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtNota.Clear();
            MktData.Clear();
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

        private void FrmPesquisaNota_Load(object sender, EventArgs e)
        {
            ListarNota();
        }

        private void DgvNota_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idNota = int.Parse(DgvNota.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtNota.Text = DgvNota.Rows[e.RowIndex].Cells["Nota"].Value.ToString();
                MktData.Text = DgvNota.Rows[e.RowIndex].Cells["Data"].Value.ToString();

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
