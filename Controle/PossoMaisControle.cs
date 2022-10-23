using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Controle
{
    public class PossoMaisControle
    {
        ChamadoControle chamadoControle;
        EmpregadoControle empregadoControle;
        PesquisaControle pesquisaControle;

        int totalChamado = 0, totalEmpregado = 0, totalChamdadoAtendente = 0;
        decimal notaConceito = 0;

        public decimal PorcentagemChamado(char opcMeta, int idCompetencia, int idEmpresa, int idEmpregado, int codigoGrupo, int idDepartamento)
        {
            chamadoControle = new ChamadoControle();
            empregadoControle = new EmpregadoControle();


            totalEmpregado = empregadoControle.TotalEmpregadoPorDepartamento(idDepartamento);


            if (opcMeta == 'Q')
            {
                totalChamado = chamadoControle.QuantidadePorGrupoSolucao(idCompetencia, idEmpresa, idEmpregado, codigoGrupo);
                totalChamdadoAtendente = chamadoControle.QuantidadeChamadoAtendente(idCompetencia, idEmpresa, idEmpregado);
            }
            else if (opcMeta == 'C')
            {
                totalChamado = chamadoControle.QuantidadePorGrupoSolucaoCapturado(idCompetencia, idEmpresa, idEmpregado, codigoGrupo);
                totalChamdadoAtendente = chamadoControle.QuantidadeCapturadoAtendente(idCompetencia, idEmpresa, idEmpregado);
            }

            decimal media = totalChamado / totalEmpregado;
            decimal porcentagem = (totalChamdadoAtendente * 100) / media;

            return porcentagem;
        }
        public decimal PorcentagemPesquisa(int codigoAtendente, int notaFinal)
        {
            pesquisaControle = new PesquisaControle();
            empregadoControle = new EmpregadoControle();

            totalEmpregado = pesquisaControle.QtdAvaliacaoAtendente(codigoAtendente);
            notaConceito = pesquisaControle.NotaAvaliacaoAtendente(codigoAtendente);



            decimal media = notaConceito / totalEmpregado;
            decimal porcentagem = (media * 100) / notaFinal;

            return porcentagem;
        }
    }
}
