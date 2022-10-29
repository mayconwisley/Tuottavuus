using Banco_De_Dados;
using Modelo;
using System;
using System.Data;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Controle
{
    public class PossoMaisControle
    {
        CRUD crud;
        string SQL;

        ChamadoControle chamadoControle;
        EmpregadoControle empregadoControle;
        PesquisaControle pesquisaControle;
        AssiduidadeControle assiduidadeControle;
        IndicadorControle indicadorControle;
        PossoMais possoMais;
        MetaPesoControle metaPesoControle;
        PesquisaNotaControle pesquisaNotaControle;
        private ProgressBar PbCarregamento { get; set; }


        double totalChamado = 0, totalEmpregado = 0, totalChamdadoAtendente = 0, notaConceito = 0;
        bool ativo, pesquisa, chamado, assiduidade, captura, feedback;
        int indicadorId;
        double porc;


        public PossoMaisControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }

        public PossoMaisControle(ref ProgressBar progressBar)
        {
            PbCarregamento = progressBar;
        }

        public double PorcentagemChamado(char opcMeta, int idCompetencia, int idEmpresa, int idEmpregado, int idDepartamento)
        {
            chamadoControle = new ChamadoControle();
            empregadoControle = new EmpregadoControle();

            try
            {

                totalEmpregado = empregadoControle.TotalEmpregadoPorDepartamento(idDepartamento);

                if (opcMeta == 'Q')
                {
                    totalChamado = chamadoControle.QtdChamado(idCompetencia, idEmpresa, idDepartamento);
                    totalChamdadoAtendente = chamadoControle.QtdChamadoAtendente(idCompetencia, idEmpresa, idEmpregado);
                }
                else if (opcMeta == 'C')
                {
                    totalChamado = chamadoControle.QtdChamadoCapturado(idCompetencia, idEmpresa, idDepartamento);
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
        public double QuantidadeFeedback(int idCompetencia, int idEmpresa, int idEmpregado)
        {
            chamadoControle = new ChamadoControle();
            try
            {
                double qtdFeed = chamadoControle.QtdFeedbackAtendente(idCompetencia, idEmpresa, idEmpregado);
                return qtdFeed;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public double QuantidadeAssiduidade(Assiduidade assiduidade)
        {
            assiduidadeControle = new AssiduidadeControle();

            try
            {
                double qtdAssiduidade = assiduidadeControle.AtrasoFalta(assiduidade);
                return qtdAssiduidade;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public bool Gravar(PossoMais possoMais)
        {
            crud = new CRUD();
            SQL = "INSERT INTO PossoMais (Id_Competencia, Id_Empresa, Id_Empregado, Id_Meta, Total) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @Id_Meta, @Total)";

            try
            {

                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", possoMais.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", possoMais.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", possoMais.Empregado.Id);
                crud.AdicionarParametros("Id_Meta", possoMais.MetaPeso.Id);
                crud.AdicionarParametros("Total", possoMais.Total);

                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
        public bool Alterar(PossoMais possoMais)
        {
            crud = new CRUD();
            SQL = "UPDATE PossoMais SET Id_Competencia = @Id_Competencia, Id_Empresa = @Id_Empresa, Id_Empregado = @Id_Empregado, " +
                  "Id_Meta = @Id_Meta, Total = @Total " +
                  "WHERE Id = @Id";

            try
            {

                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", possoMais.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", possoMais.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", possoMais.Empregado.Id);
                crud.AdicionarParametros("Id_Meta", possoMais.MetaPeso.Id);
                crud.AdicionarParametros("Total", possoMais.Total);
                crud.AdicionarParametros("Id", possoMais.Id);
                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }
        public bool Excluir(PossoMais possoMais)
        {
            crud = new CRUD();
            SQL = "DELETE FROM PossoMais " +
                  "WHERE Id = @Id";

            try
            {

                crud.LimparParametros();
                crud.AdicionarParametros("Id", possoMais.Id);
                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public bool Calcular(int idCompetencia)
        {
            possoMais = new PossoMais();
            indicadorControle = new IndicadorControle();
            empregadoControle = new EmpregadoControle();
            metaPesoControle = new MetaPesoControle();
            chamadoControle = new ChamadoControle();
            pesquisaNotaControle = new PesquisaNotaControle();

            DataTable indicador = indicadorControle.IndicadorTabela();
            DataTable empregado = empregadoControle.EmpregadoAtivoTabela();
            DataTable codigoGrupoSolucao = chamadoControle.CodigosGrupoSolucaoTabela(idCompetencia);

            int nota = pesquisaNotaControle.Nota(DateTime.Now.Date);
            PbCarregamento.Maximum = empregado.Rows.Count;
            int i = 0;
            /*Calcular porcentagem Chamado*/
            foreach (DataRow empregadoRow in empregado.Rows)
            {
                int empregadoId = int.Parse(empregadoRow[0].ToString());
                int empresaId = int.Parse(empregadoRow[1].ToString());
                int departamentoId = int.Parse(empregadoRow[2].ToString());
                int codigoEmpregado = int.Parse(empregadoRow[3].ToString());
                i++;
                PbCarregamento.Value = i;
                
                foreach (DataRow item in indicador.Rows)
                {
                    indicadorId = int.Parse(item[0].ToString());
                    ativo = bool.Parse(item[2].ToString());
                    pesquisa = bool.Parse(item[3].ToString());
                    chamado = bool.Parse(item[4].ToString());
                    assiduidade = bool.Parse(item[5].ToString());
                    captura = bool.Parse(item[6].ToString());
                    feedback = bool.Parse(item[7].ToString());

                    if (pesquisa)
                    {
                        porc = PorcentagemPesquisa(codigoEmpregado, nota);
                    }
                    if (chamado)
                    {
                        porc = PorcentagemChamado('Q', idCompetencia, empresaId, empregadoId, departamentoId);
                    }
                    if (captura)
                    {
                        porc = PorcentagemChamado('C', idCompetencia, empresaId, empregadoId, departamentoId);
                    }
                    if (assiduidade)
                    {

                    }
                    if (feedback)
                    {
                        porc = QuantidadeFeedback(idCompetencia, empresaId, empregadoId);
                    }

                    int idMeta = metaPesoControle.IdPorMeta(porc, indicadorId);

                    if (idMeta == 0)
                    {
                        continue;
                    }

                    possoMais.Competencia = new Competencia();
                    possoMais.Competencia.Id = idCompetencia;
                    possoMais.Empresa = new Empresa();
                    possoMais.Empresa.Id = empresaId;
                    possoMais.Empregado = new Empregado();
                    possoMais.Empregado.Id = empregadoId;
                    possoMais.MetaPeso = new MetaPeso();
                    possoMais.MetaPeso.Id = idMeta;
                    possoMais.Total = porc;

                    Gravar(possoMais);




                }







            }








            return true;

        }

    }
}
