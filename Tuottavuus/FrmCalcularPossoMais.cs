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
    public partial class FrmCalcularPossoMais : Form
    {
        PossoMaisControle possoMaisControle;
        CompetenciaControle competenciaControle;

        int idCompetencia;
        DateTime dtCompetencia;

        public FrmCalcularPossoMais()
        {
            InitializeComponent();
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
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            FrmBarraCarregamento frmBarraCarregamento = new FrmBarraCarregamento('X', idCompetencia)
            {
                MdiParent = FrmPrincipal.ActiveForm
            };
            frmBarraCarregamento.Show();
        }

        private void FrmCalcularPossoMais_Load(object sender, EventArgs e)
        {
            ListaCompetencia();
        }
    }
}
