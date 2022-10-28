﻿using Banco_De_Dados;
using Modelo;
using System.Data;
using System.Security.Principal;
using System.Text.RegularExpressions;

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


        double totalChamado = 0, totalEmpregado = 0, totalChamdadoAtendente = 0, notaConceito = 0;
        bool ativo, pesquisa, chamado, assiduidade, captura;
        int indicadorId;
        double porc;

        public PossoMaisControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }



        public double PorcentagemChamado(char opcMeta, int idCompetencia, int idEmpresa, int idEmpregado, int codigoGrupo, int idDepartamento)
        {
            chamadoControle = new ChamadoControle();
            empregadoControle = new EmpregadoControle();

            try
            {

                totalEmpregado = empregadoControle.TotalEmpregadoPorDepartamento(idDepartamento);

                if (opcMeta == 'A')
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

            DataTable indicador = indicadorControle.IndicadorTabela();
            DataTable empregado = empregadoControle.EmpregadoAtivoTabela();
            DataTable codigoGrupoSolucao = chamadoControle.CodigosGrupoSolucaoTabela(idCompetencia);

            /*Calcular porcentagem Chamado*/
            foreach (DataRow empregadoRow in empregado.Rows)
            {
                int empregadoId = int.Parse(empregadoRow[0].ToString());
                int empresaId = int.Parse(empregadoRow[1].ToString());
                int departamentoId = int.Parse(empregadoRow[2].ToString());


                foreach (DataRow codigoGrupoSol in codigoGrupoSolucao.Rows)
                {
                    int codGrupo = int.Parse(codigoGrupoSol[0].ToString());

                    foreach (DataRow item in indicador.Rows)
                    {
                        indicadorId = int.Parse(item[0].ToString());
                        ativo = bool.Parse(item[2].ToString());
                        pesquisa = bool.Parse(item[3].ToString());
                        chamado = bool.Parse(item[4].ToString());
                        assiduidade = bool.Parse(item[5].ToString());
                        captura = bool.Parse(item[5].ToString());

                        if (pesquisa)
                        {

                        }
                        if (chamado)
                        {
                            porc = PorcentagemChamado('Q', idCompetencia, empresaId, empregadoId, codGrupo, departamentoId);
                        }
                        if (captura)
                        {
                            porc = PorcentagemChamado('C', idCompetencia, empresaId, empregadoId, codGrupo, departamentoId);
                        }
                        if (assiduidade)
                        {

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





            }








            return true;

        }

    }
}
