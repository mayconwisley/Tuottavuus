using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroCompetencia : Form
    {
        Competencia competencia;
        CompetenciaControle competenciaControle;
        DateTime dtCompetencia;
        int idCompetencia = 0, numCompetencia = 0;

        public FrmCadastroCompetencia()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            MktCompetencia.Clear();
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            MktCompetencia.Focus();
        }

        private bool ListaCompetencia()
        {
            competenciaControle = new CompetenciaControle();

            try
            {
                DgvCompetencia.DataSource = competenciaControle.CompetenciaTabela();
                numCompetencia = DgvCompetencia.Rows.Count;
                dtCompetencia = competenciaControle.CompetenciaAtiva();
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
            competencia = new Competencia();
            competenciaControle = new CompetenciaControle();

            try
            {
                competencia.Id = idCompetencia;
                competencia.Data = DateTime.Parse(MktCompetencia.Text.Trim());
                if (CbAtivo.Checked)
                {
                    competencia.Ativo = true;
                }
                else
                {
                    competencia.Ativo = false;
                }

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    if (numCompetencia == 0)
                    {
                        competenciaControle.Gravar(competencia);
                    }
                    else
                    {
                        competencia.Id = competenciaControle.Id(dtCompetencia);
                        competenciaControle.FecharCompetencia(competencia);
                        competenciaControle.Gravar(competencia);
                    }
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    competencia.Id = competenciaControle.Id(dtCompetencia);
                    competenciaControle.FecharCompetencia(competencia);
                    competencia.Id = idCompetencia;
                    competenciaControle.Alterar(competencia);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    competenciaControle.Excluir(competencia);
                }
                ListaCompetencia();
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void FrmCadastroCompetencia_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
        }

        private void DgvCompetencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCompetencia = int.Parse(DgvCompetencia.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                DateTime dateTime = DateTime.Parse(DgvCompetencia.Rows[e.RowIndex].Cells["DataCompetencia"].Value.ToString());
                MktCompetencia.Text = dateTime.ToString("MM/yyyy");
                bool ativo = bool.Parse(DgvCompetencia.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
                if (ativo)
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
    }
}
