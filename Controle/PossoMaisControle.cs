using Modelo;

namespace Controle
{
    public class PossoMaisControle
    {
        ChamadoControle chamadoControle;
        EmpregadoControle empregadoControle;
        PesquisaControle pesquisaControle;
        AssiduidadeControle assiduidadeControle;

        double totalChamado = 0, totalEmpregado = 0, totalChamdadoAtendente = 0, notaConceito = 0;
        
        public double PorcentagemChamado(char opcMeta, int idCompetencia, int idEmpresa, int idEmpregado, int codigoGrupo, int idDepartamento)
        {
            chamadoControle = new ChamadoControle();
            empregadoControle = new EmpregadoControle();

            try
            {

                totalEmpregado = empregadoControle.TotalEmpregadoPorDepartamento(idDepartamento);

                if (opcMeta == 'Q')
                {
                    totalChamado = chamadoControle.QtdPorGrupoSolucao(idCompetencia, idEmpresa, codigoGrupo);
                    totalChamdadoAtendente = chamadoControle.QtdChamadoAtendente(idCompetencia, idEmpresa, idEmpregado);
                }
                else if (opcMeta == 'C')
                {
                    totalChamado = chamadoControle.QtdPorGrupoSolucaoCapturado(idCompetencia, idEmpresa, codigoGrupo);
                    totalChamdadoAtendente = chamadoControle.QtdCapturadoAtendente(idCompetencia, idEmpresa, idEmpregado);
                }

                double media = totalChamado / totalEmpregado;
                double porcentagem = (totalChamdadoAtendente * 100) / media;

                return porcentagem;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public double PorcentagemPesquisa(int codigoAtendente, int notaFinal)
        {
            pesquisaControle = new PesquisaControle();
            empregadoControle = new EmpregadoControle();

            try
            {
                totalEmpregado = pesquisaControle.QtdAvaliacaoAtendente(codigoAtendente);
                notaConceito = pesquisaControle.NotaAvaliacaoAtendente(codigoAtendente);

                double media = notaConceito / totalEmpregado;
                double porcentagem = (media * 100) / notaFinal;

                return porcentagem;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public decimal QuantidadeAssiduidade(Assiduidade assiduidade)
        {
            assiduidadeControle = new AssiduidadeControle();

            try
            {
                decimal qtdAssiduidade = assiduidadeControle.AtrasoFalta(assiduidade);
                return qtdAssiduidade;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
