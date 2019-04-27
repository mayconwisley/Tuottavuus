using Controle;
using Modelo;
using System;
using System.Windows.Forms;

namespace Tuottavuus
{
	public partial class FrmCadastroAtividade : Form
	{
		Atividade atividade;
		AtividadeControle atividadeControle;
		int idAtividade = 0;

		public FrmCadastroAtividade()
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

		private bool ListaAtividade()
		{
			atividadeControle = new AtividadeControle();
			int totalAtividade = 0;
			try {
				DgvAtividades.DataSource = atividadeControle.AtividadeTabela();
				totalAtividade = DgvAtividades.Rows.Count;
				LblInfoAtividade.Text = "Atividades - " + totalAtividade.ToString("00");
				return true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		private bool Manipular(TipoManipulacao tipoManipulacao)
		{
			atividade = new Atividade();
			atividadeControle = new AtividadeControle();

			try {
				atividade.Id = idAtividade;
				atividade.Descricao = TxtDescricao.Text.Trim();
				if (CbAtivo.Checked) {
					atividade.Ativo = true;
				} else {
					atividade.Ativo = false;
				}

				if (tipoManipulacao == TipoManipulacao.Gravar) {
					atividadeControle.Gravar(atividade);
				} else if (tipoManipulacao == TipoManipulacao.Alterar) {
					atividadeControle.Alterar(atividade);
				} else if (tipoManipulacao == TipoManipulacao.Excluir) {
					atividadeControle.Excluir(atividade);
				}
				ListaAtividade();
				Reset();
				return true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return false;
			}

		}

		private void FrmCadastroAtividade_Load(object sender, EventArgs e)
		{
			ListaAtividade();
		}

		private void DgvAtividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try {
				idAtividade = int.Parse(DgvAtividades.Rows[e.RowIndex].Cells["Id"].Value.ToString());
				TxtDescricao.Text = DgvAtividades.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
				bool ativo = bool.Parse(DgvAtividades.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
				if (ativo == true) {
					CbAtivo.Checked = true;
				} else {
					CbAtivo.Checked = false;
				}

				BtnAlterar.Enabled = true;
				BtnExcluir.Enabled = true;
				BtnGravar.Enabled = false;
			} catch (Exception ex) {
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
