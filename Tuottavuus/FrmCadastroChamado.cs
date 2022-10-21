using Controle;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuottavuus
{
    public partial class FrmCadastroChamado : Form
    {
        EmpresaControle empresaControle;
        EmpregadoControle empregadoControle;
        CompetenciaControle competenciaControle;
        DateTime dtCompetencia;
        int idEmpregado = 0, idEmpresa = 0, idCompetencia = 0, idChamado = 0, codigoEmpregado;
        string nomeEmpregado = string.Empty;

        public FrmCadastroChamado()
        {
            InitializeComponent();
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
                nomeEmpregado = empregadoControle.NomePorId(idEmpregado);

                LblInfoCodigoAtendente.Text = "Código Atendente: " + codigoEmpregado.ToString("00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void FrmCadastroChamado_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
            ListaEmpresa();
            //ListaPesquisa();
        }

        private void DgvChamado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idChamado = int.Parse(DgvChamado.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                idEmpregado = int.Parse(DgvChamado.Rows[e.RowIndex].Cells["Id_Empregado"].Value.ToString());
                idEmpresa = int.Parse(DgvChamado.Rows[e.RowIndex].Cells["Id_Empresa"].Value.ToString());

                TxtChamado.Text = DgvChamado.Rows[e.RowIndex].Cells["Chamado"].Value.ToString();
                TxtCodArea.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoArea"].Value.ToString();
                TxtCodGpSolucao.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoGrupoSolucao"].Value.ToString();
                TxtCodNatureza.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoNatureza"].Value.ToString();
                TxtCodTpAtividade.Text = DgvChamado.Rows[e.RowIndex].Cells["CodigoTpAtividade"].Value.ToString();

                TxtDescArea.Text = DgvChamado.Rows[e.RowIndex].Cells["DescArea"].Value.ToString();
                TxtDescGrupoSolucao.Text = DgvChamado.Rows[e.RowIndex].Cells["DescGrupoSolucao"].Value.ToString();
                TxtDescNatureza.Text = DgvChamado.Rows[e.RowIndex].Cells["DescNatureza"].Value.ToString();
                TxtDescTpAtividade.Text = DgvChamado.Rows[e.RowIndex].Cells["DescTpAtividade"].Value.ToString();

                CbxEmpregado.SelectedValue = idEmpregado;
                CbxEmpresa.SelectedValue = idEmpresa;

                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;

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
            TxtChamado.Text = "0";
            TxtCodArea.Text = "0";
            TxtCodGpSolucao.Text = "0";
            TxtCodNatureza.Text = "0";
            TxtCodTpAtividade.Text = "0";
            TxtDescArea.Clear();
            TxtDescGrupoSolucao.Clear();
            TxtDescNatureza.Clear();
            TxtDescTpAtividade.Clear();
            MktDataAbertura.Text = "";
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
    }
}
