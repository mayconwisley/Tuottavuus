using Controle;
using Modelo;
using System;
using System.Windows.Forms;


namespace Tuottavuus
{
    public partial class FrmCadastroEmpresa : Form
    {
        Empresa empresa;
        EmpresaControle empresaControle;
        int idEmpresa = 0;
        public FrmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            TxtNome.Clear();
            BtnGravar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            TxtNome.Focus();
        }

        private bool ListaEmpresa()
        {
            empresaControle = new EmpresaControle();
            int totalEmpresa = 0;
            try
            {
                DgvEmpresa.DataSource = empresaControle.EmpresaTabela();
                totalEmpresa = DgvEmpresa.Rows.Count;
                LblInfoEmpresa.Text = "Empresas cadastradas - " + totalEmpresa.ToString("00");
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
            empresa = new Empresa();
            empresaControle = new EmpresaControle();
            try
            {
                empresa.Id = idEmpresa;
                empresa.Nome = TxtNome.Text.Trim();
                if (CbxAtivo.Checked)
                {
                    empresa.Ativo = true;
                }
                else
                {
                    empresa.Ativo = false;
                }

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    empresaControle.Gravar(empresa);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    empresaControle.Alterar(empresa);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    empresaControle.Excluir(empresa);
                }
                ListaEmpresa();
                Reset();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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

        private void DgvEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(DgvEmpresa.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtNome.Text = DgvEmpresa.Rows[e.RowIndex].Cells["NomeEmpresa"].Value.ToString();
                bool ativo = bool.Parse(DgvEmpresa.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
                if (ativo == true)
                {
                    CbxAtivo.Checked = true;
                }
                else
                {
                    CbxAtivo.Checked = false;
                }
                BtnExcluir.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            ListaEmpresa();
        }
    }
}
