using Controle;
using Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroAvaliacao : Form
    {
        EmpregadoControle empregadoControle;
        EmpresaControle empresaControle;
        AtividadeControle atividadeControle;
        AtividadeAvaliacao atividadeAvaliacao;
        AtividadeAvaliacaoControle atividadeAvaliacaoControle;
        ProdutividadeControle produtividadeControle;
        CompetenciaControle competenciaControle;
        ValidarNumero validarNumero;
        DateTime dtCompetencia;
        int idEmpregado = 0, idEmpresa = 0, idAtividade = 0, idAvaliacaoAtividade = 0, idCompetencia = 0, aux = 0, aux1 = 0;
        int numCalculo = 0, numEmpregado;
        bool ausente = false, alterar = false;
        public FrmCadastroAvaliacao()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtNota.Text = "0,00";
        }

        private bool ListaEmpresa()
        {
            empresaControle = new EmpresaControle();
            try
            {
                CbxEmpresa.DataSource = empresaControle.EmpresaComboBox();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListaEmpregado(int empresaId)
        {
            empregadoControle = new EmpregadoControle();

            try
            {
                CbxEmpregado.DataSource = empregadoControle.EmpregadoComboBox(empresaId);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListaCompetencia()
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetencia = competenciaControle.CompetenciaAtiva();
                idCompetencia = competenciaControle.Id(dtCompetencia);
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void VerificarEmpregado(int empregadoId)
        {
            produtividadeControle = new ProdutividadeControle();
            DataTable dataTable = produtividadeControle.ProdutividadeTabela(idCompetencia, idEmpresa);
            ausente = false;
            foreach (DataRow item in dataTable.Rows)
            {
                if (empregadoId == int.Parse(item["Id_Empregado"].ToString()))
                {
                    ausente = false;
                    break;
                }
                else
                {
                    ausente = true;
                }
            }
            if (ausente)
            {
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");
                DgvAvaliacao.Enabled = true;
                CbxAtividade.Enabled = true;
                TxtNota.Enabled = true;
                Reset();
            }
            else if (numCalculo <= numEmpregado && numCalculo > 0)
            {
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy") + " - Empregado já calculado!!!";
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnGravar.Enabled = false;
                DgvAvaliacao.CancelEdit();
                CbxAtividade.Enabled = false;
                TxtNota.Enabled = false;
            }
            else if (numCalculo == 0)
            {
                ausente = true;
            }
        }

        private int VerificarCalculoProdutividade()
        {
            produtividadeControle = new ProdutividadeControle();
            try
            {
                numCalculo = produtividadeControle.NumCalculados(idCompetencia, idEmpresa);
                numEmpregado = CbxEmpregado.Items.Count;
                if (numCalculo == numEmpregado && numEmpregado != 0)
                {
                    LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy") + " - Produtividade Calculada!!!";
                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    BtnGravar.Enabled = false;
                    DgvAvaliacao.CancelEdit();
                    CbxAtividade.Enabled = false;
                    TxtNota.Enabled = false;
                }
                else if (numCalculo < numEmpregado && numCalculo > 0)
                {
                    LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy") + " - Produtividade parcial calculada!!!";
                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    BtnGravar.Enabled = false;
                    DgvAvaliacao.CancelEdit();
                    CbxAtividade.Enabled = false;
                    TxtNota.Enabled = false;
                }
                else
                {
                    LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");
                    DgvAvaliacao.Enabled = true;
                    CbxAtividade.Enabled = true;
                    TxtNota.Enabled = true;
                    Reset();
                }
                return numCalculo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private bool ListaAtividade()
        {
            atividadeControle = new AtividadeControle();
            try
            {
                CbxAtividade.DataSource = atividadeControle.AtividadeComboBox();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ListaAtividadeAvaliacao(int empresaId, int empregadoId, int competenciaId)
        {
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();
            LblInfo.Text = "Média para calculo: 0,00";
            int totalItens = 0;
            decimal dcNota = 0, media = 0;
            try
            {
                DgvAvaliacao.DataSource = atividadeAvaliacaoControle.AtividadeAvaliacaoTabela(idEmpresa, idEmpregado, idCompetencia);
                totalItens = DgvAvaliacao.Rows.Count;

                foreach (DataGridViewRow item in DgvAvaliacao.Rows)
                {
                    dcNota += decimal.Parse(item.Cells["Notaa"].Value.ToString());
                }

                if (totalItens != 0)
                {
                    media = dcNota / totalItens;
                    LblInfo.Text = "Total: " + dcNota.ToString("#,##0.00") +
                                   " Média para calculo: " + media.ToString("#,##0.00");
                }
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
            atividadeAvaliacao = new AtividadeAvaliacao();
            atividadeAvaliacaoControle = new AtividadeAvaliacaoControle();

            try
            {
                atividadeAvaliacao.Id = idAvaliacaoAtividade;
                atividadeAvaliacao.Nota = double.Parse(TxtNota.Text.Trim());
                atividadeAvaliacao.Competencia = new Competencia();
                atividadeAvaliacao.Competencia.Id = idCompetencia;
                atividadeAvaliacao.Empresa = new Empresa();
                atividadeAvaliacao.Empresa.Id = idEmpresa;
                atividadeAvaliacao.Empregado = new Empregado();
                atividadeAvaliacao.Empregado.Id = idEmpregado;
                atividadeAvaliacao.Atividade = new Atividade();
                atividadeAvaliacao.Atividade.Id = idAtividade;

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    atividadeAvaliacaoControle.Gravar(atividadeAvaliacao);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    atividadeAvaliacaoControle.Alterar(atividadeAvaliacao);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    atividadeAvaliacaoControle.Excluir(atividadeAvaliacao);
                }

                ListaAtividadeAvaliacao(idEmpresa, idEmpregado, idCompetencia);
                alterar = false;
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void LancamentoItem()
        {
            int totalItens = 0, totalEmpregado = 0;
            try
            {
                if (TxtNota.Text != "")
                {
                    totalItens = CbxAtividade.Items.Count;
                    totalEmpregado = CbxEmpregado.Items.Count;
                    aux++;
                    if (aux < totalItens)
                    {
                        CbxAtividade.SelectedIndex = aux;
                        TxtNota.Clear();
                        TxtNota.Focus();
                    }
                    else
                    {
                        aux = 0;
                        CbxAtividade.SelectedIndex = 0;
                        aux1++;
                        if (aux1 < totalEmpregado)
                        {
                            CbxEmpregado.SelectedIndex = aux1;
                        }
                        else
                        {
                            MessageBox.Show("Selecione outra empresa...", "Aviso");
                            CbxEmpresa.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Manipular(TipoManipulacao.Gravar);
            LancamentoItem();
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
            try
            {
                TxtNota.Text = validarNumero.Validar(TxtNota.Text);
                TxtNota.Select(TxtNota.Text.Length, 0);
                if (TxtNota.Text != "")
                {
                    decimal valor = decimal.Parse(TxtNota.Text);
                    if (valor > 100)
                    {
                        TxtNota.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                validarNumero = new ValidarNumero();
                TxtNota.Text = validarNumero.Zero(TxtNota.Text);
                TxtNota.Text = validarNumero.Formatar(TxtNota.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            if (TxtNota.Text == "0,00")
            {
                TxtNota.Text = "";
            }
        }

        private void FrmCadastroAvaliacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tirar o som da tecla enter
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
                TxtNota.Text = "";
                TxtNota.Focus();
            }

        }

        private void DgvAvaliacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ausente)
                {
                    idAvaliacaoAtividade = int.Parse(DgvAvaliacao.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    decimal dcNota = decimal.Parse(DgvAvaliacao.Rows[e.RowIndex].Cells["Notaa"].Value.ToString());
                    TxtNota.Text = dcNota.ToString("0.00");
                    CbxAtividade.Text = DgvAvaliacao.Rows[e.RowIndex].Cells["AtividadeDescricao"].Value.ToString();
                    BtnGravar.Enabled = false;
                    BtnAlterar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    TxtNota.Focus();
                    alterar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && alterar == false)
            {
                Manipular(TipoManipulacao.Gravar);
                LancamentoItem();
            }
            else if (e.KeyCode == Keys.Enter && alterar == true)
            {
                Manipular(TipoManipulacao.Alterar);
                LancamentoItem();
            }
        }

        private void FrmCadastroAvaliacao_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
            ListaAtividade();
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.Text.Substring(0, CbxEmpresa.Text.IndexOf(' ')));
                ListaEmpregado(idEmpresa);
                VerificarCalculoProdutividade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpregado = int.Parse(CbxEmpregado.Text.Substring(0, CbxEmpregado.Text.IndexOf(' ')));
                VerificarEmpregado(idEmpregado);
                ListaAtividadeAvaliacao(idEmpresa, idEmpregado, idCompetencia);
                aux1 = CbxEmpregado.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
            atividadeControle = new AtividadeControle();
            try
            {
                aux = CbxAtividade.SelectedIndex;
                idAtividade = atividadeControle.Id(CbxAtividade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
