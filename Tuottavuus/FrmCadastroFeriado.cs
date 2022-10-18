using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroFeriado : Form
    {
        Feriado feriado;
        FeriadoControle feriadoControle;
        DateTime dtAno;
        int idFeriado = 0;

        public FrmCadastroFeriado()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            TxtAno.Text = dtAno.ToString("yyyy");
            TxtDescricao.Clear();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            MktData.Clear();
            MktData.Focus();
        }

        private bool ListaFeriados(DateTime dtCompetencia)
        {
            feriadoControle = new FeriadoControle();
            try
            {

                DgvFeriados.DataSource = feriadoControle.FeriadoTabelaCompetencia(dtCompetencia);
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
            feriadoControle = new FeriadoControle();
            feriado = new Feriado();
            try
            {
                DateTime dtFeriado = DateTime.Parse(MktData.Text);
                if (dtFeriado.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Feriado no domingo, não é necessário cadastrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    return false;
                }
                feriado.Id = idFeriado;
                feriado.Ano = TxtAno.Text.Trim();
                feriado.Descricao = TxtDescricao.Text.Trim();
                feriado.Data = DateTime.Parse(MktData.Text);

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    feriadoControle.Gravar(feriado);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    feriadoControle.Alterar(feriado);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    feriadoControle.Excluir(feriado);
                }
                ListaFeriados(dtAno);
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void FrmCadastroFeriado_Load(object sender, EventArgs e)
        {
            dtAno = DateTime.Now;
            ListaFeriados(dtAno);
            TxtAno.Text = dtAno.ToString("yyyy");
            MktData.Select();
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

        private void TxtAno_Leave(object sender, EventArgs e)
        {
            try
            {
                dtAno = DateTime.Parse("01/01/" + TxtAno.Text);
                ListaFeriados(dtAno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                TxtAno.Text = DateTime.Now.ToString("yyyy");
            }
        }

        private void TxtAno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtAno = DateTime.Parse("01/01/" + TxtAno.Text);
                    ListaFeriados(dtAno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                TxtAno.Text = DateTime.Now.ToString("yyyy");
            }
        }

        private void FrmCadastroFeriado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tirar o som da tecla enter
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void DgvFeriados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idFeriado = int.Parse(DgvFeriados.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                MktData.Text = DgvFeriados.Rows[e.RowIndex].Cells["Data"].Value.ToString();
                TxtDescricao.Text = DgvFeriados.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
