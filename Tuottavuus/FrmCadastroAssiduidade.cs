using Controle;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroAssiduidade : Form
    {
        EmpresaControle empresaControle;
        EmpregadoControle empregadoControle;
        CompetenciaControle competenciaControle;
        Assiduidade assiduidade;
        AssiduidadeControle assiduidadeControle;
        DateTime dtCompetencia;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0, idAssiduidade = 0, codigoEmpregado;

        public FrmCadastroAssiduidade()
        {
            InitializeComponent();
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
                MessageBox.Show(ex.Message, "Erro");
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
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void CbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idEmpresa = int.Parse(CbxEmpresa.SelectedValue.ToString());
                ListaEmpregado(idEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void CbxEmpregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            empregadoControle = new EmpregadoControle();
            try
            {
                idEmpregado = int.Parse(CbxEmpregado.SelectedValue.ToString());
                codigoEmpregado = empregadoControle.CodigoPorId(idEmpregado);

                LblInfoCodigoAtendente.Text = "Código Atendente: " + codigoEmpregado.ToString("00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FrmCadastroAssiduidade_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
            ListaAssiduidade();
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

        private void DgvAssiduidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idAssiduidade = int.Parse(DgvAssiduidade.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                idCompetencia = int.Parse(DgvAssiduidade.Rows[e.RowIndex].Cells["Id_Competencia"].Value.ToString());
                idEmpresa = int.Parse(DgvAssiduidade.Rows[e.RowIndex].Cells["Id_Empresa"].Value.ToString());
                idEmpregado = int.Parse(DgvAssiduidade.Rows[e.RowIndex].Cells["Id_Empregado"].Value.ToString());

                TxtAtrasoFalta.Text = DgvAssiduidade.Rows[e.RowIndex].Cells["AtrasoFalta"].Value.ToString();

                CbxEmpresa.SelectedValue = idEmpresa;
                CbxEmpregado.SelectedValue = idEmpregado;

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                throw;
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
                MessageBox.Show(ex.Message, "Erro");
                return false;
            }
        }

        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;
            TxtAtrasoFalta.Text = "0";
        }
        private void Maninupar(TipoManipulacao tipoManipulacao)
        {
            assiduidade = new Assiduidade();
            assiduidadeControle = new AssiduidadeControle();

            try
            {
                try
                {
                    dtCompetencia = competenciaControle.CompetenciaAtiva();
                    idCompetencia = competenciaControle.Id(dtCompetencia.Date);
                }
                catch
                {
                    MessageBox.Show("Cadastrar competência!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                assiduidade.Id = idAssiduidade;
                assiduidade.Competencia = new Competencia();
                assiduidade.Competencia.Id = idCompetencia;
                assiduidade.Empresa = new Empresa();
                assiduidade.Empresa.Id = idEmpresa;
                assiduidade.Empregado = new Empregado();
                assiduidade.Empregado.Id = idEmpregado;
                assiduidade.AtrasoFalta = int.Parse(TxtAtrasoFalta.Text.Trim());

                if (tipoManipulacao == TipoManipulacao.Gravar)
                {
                    assiduidadeControle.Gravar(assiduidade);
                }
                else if (tipoManipulacao == TipoManipulacao.Alterar)
                {
                    assiduidadeControle.Alterar(assiduidade);
                }
                else if (tipoManipulacao == TipoManipulacao.Excluir)
                {
                    assiduidadeControle.Excluir(assiduidade);
                }

                ListaAssiduidade();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
        private void ListaAssiduidade()
        {
            assiduidadeControle = new AssiduidadeControle();
            int totalAssiduidade = 0;
            try
            {
                DgvAssiduidade.DataSource = assiduidadeControle.AssiduidadeTabela();
                totalAssiduidade = DgvAssiduidade.Rows.Count;
                LblInfoAssiduidade.Text = "Assiduidade - " + totalAssiduidade.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
