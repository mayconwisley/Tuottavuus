using Controle;
using Modelo;
using System;
using System.Windows.Forms;


namespace Tuottavuus
{
    public partial class FrmCadastroDepartamento : Form
    {
        Departamento departamento;
        DepartamentoControle departamentoControle;
        int idDepartamento = 0;

        public FrmCadastroDepartamento()
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


        private bool ListaDepartamento()
        {
            departamentoControle = new DepartamentoControle();
            try
            {
                DgvDepartamento.DataSource = departamentoControle.DepartamentoTabela();
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
            departamento = new Departamento();
            departamentoControle = new DepartamentoControle();
            try
            {
                departamento.Id = idDepartamento;
                departamento.Descricao = TxtDescricao.Text.Trim();

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    departamentoControle.Gravar(departamento);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    departamentoControle.Alterar(departamento);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    departamentoControle.Excluir(departamento);
                }
                ListaDepartamento();
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void FrmCadastroDepartamento_Load(object sender, EventArgs e)
        {
            ListaDepartamento();
        }

        private void DgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDepartamento = int.Parse(DgvDepartamento.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtDescricao.Text = DgvDepartamento.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
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
