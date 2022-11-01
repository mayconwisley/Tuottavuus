using Controle;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCalcularPossoMais : Form
    {
        PossoMaisControle possoMaisControle;
        CompetenciaControle competenciaControle;
        EmpresaControle empresaControle;

        int idCompetencia, idEmpresa, idPossoMais;
        DateTime dtCompetencia;
        string nomeEmpregado;

        public FrmCalcularPossoMais()
        {
            InitializeComponent();
        }
        private void ListaCompetencia()
        {
            competenciaControle = new CompetenciaControle();
            try
            {
                dtCompetencia = competenciaControle.CompetenciaAtiva();
                idCompetencia = competenciaControle.Id(dtCompetencia);
                LblCompetencia.Text = "Competência: " + dtCompetencia.ToString("MM/yyyy");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

            }
        }

        private void ListaEmpresa()
        {
            empresaControle = new EmpresaControle();
            try
            {
                CbxEmpresa.DataSource = empresaControle.EmpresaComboBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");

            }
        }

        private void ListaPossoMaisTabela(int competenciaId, int empresaId, string nome)
        {
            possoMaisControle = new PossoMaisControle();
            try
            {
                nomeEmpregado = $"%{nome}%";

                DgvPossoMais.DataSource = possoMaisControle.PossoMaisTabela(competenciaId, empresaId, nomeEmpregado);
                int total = DgvPossoMais.Rows.Count;
                LblInfoCalculo.Text = "Posso Mais - " + total.ToString("00");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBarraCarregamento frmBarraCarregamento = new FrmBarraCarregamento('X', idCompetencia, idEmpresa)
                {
                    MdiParent = FrmPrincipal.ActiveForm
                };
                frmBarraCarregamento.Show();
                ListaPossoMaisTabela(idCompetencia, idEmpresa, TxtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmCalcularPossoMais_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ListaPossoMaisTabela(idCompetencia, idEmpresa, TxtPesquisa.Text.Trim());
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListaPossoMaisTabela(idCompetencia, idEmpresa, TxtPesquisa.Text.Trim());
        }

        private void DgvPossoMais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            possoMaisControle = new PossoMaisControle();

            try
            {
                idPossoMais = int.Parse(DgvPossoMais.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                if (MessageBox.Show("Deseja excluir o calculo desse empregado?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    possoMaisControle.Excluir(idPossoMais);
                }
                ListaPossoMaisTabela(idCompetencia, idEmpresa, TxtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaPossoMaisTabela(idCompetencia, idEmpresa, TxtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
