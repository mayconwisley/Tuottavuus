using Banco_De_Dados;
using Modelo;
using System;
using System.Data;
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
        AfastamentoControle afastamentoControle;
        ConfigAfastamentoControle configAfastamentoControle;
        PossoMaisControle possoMaisControle;

        private ProgressBar PbCarregamento { get; set; }

        double totalChamado = 0, totalChamdadoAtendente = 0, notaConceito = 0;
        int indicadorId;
        double qtdOuPorcentagem;

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
            afastamentoControle = new AfastamentoControle();
            configAfastamentoControle = new ConfigAfastamentoControle();

            try
            {
                int diasAfastadoConfig = configAfastamentoControle.QtdDiasConfig();
                int totalAfastado = afastamentoControle.QtdAfastadoConfig(diasAfastadoConfig, idDepartamento);
                int totalEmpregado = empregadoControle.TotalEmpregadoPorDepartamento(idDepartamento);

                int qtdEmpregado = totalEmpregado - totalAfastado;

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

                double media = totalChamado / qtdEmpregado;
                double porcentagem = (totalChamdadoAtendente * 100) / media;

                return porcentagem;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public double PorcentagemPesquisa(int codigoAtendente, int notaFinal, int idDepartamento)
        {
            pesquisaControle = new PesquisaControle();
            empregadoControle = new EmpregadoControle();

            try
            {
                int diasAfastadoConfig = configAfastamentoControle.QtdDiasConfig();
                int totalAfastado = afastamentoControle.QtdAfastadoConfig(diasAfastadoConfig, idDepartamento);
                int totalEmpregado = pesquisaControle.QtdAvaliacaoAtendente(codigoAtendente);

                int qtdEmpregado = totalEmpregado - totalAfastado;

                notaConceito = pesquisaControle.NotaAvaliacaoAtendente(codigoAtendente);

                double media = notaConceito / qtdEmpregado;
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
        public double QuantidadeAssiduidade(int idCompetencia, int idEmpresa, int idEmpregado)
        {
            assiduidadeControle = new AssiduidadeControle();

            try
            {
                double qtdAssiduidade = assiduidadeControle.AtrasoFalta(idCompetencia, idEmpresa, idEmpregado);
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
        public bool Excluir(int idPossoMais)
        {
            crud = new CRUD();
            SQL = "DELETE FROM PossoMais " +
                  "WHERE Id = @Id";

            try
            {

                crud.LimparParametros();
                crud.AdicionarParametros("Id", idPossoMais);
                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public bool ExcluirPorCompetencia(int idCompetencia, int idEmpregado)
        {
            crud = new CRUD();
            SQL = "DELETE FROM PossoMais " +
                  "WHERE Id_Competencia = @Id_Competencia " +
                  "AND Id_Empregado = @Id_Empregado";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);
                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public bool IsCalculo(int idCompetencia, int idEmpresa, int idEmpregado, int idMeta)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(*) " +
                    "FROM PossoMais " +
                    "WHERE Id_Competencia = @Id_Competencia " +
                    "AND Id_Empresa = @Id_Empresa " +
                    "AND Id_Empregado = @Id_Empregado " +
                    "AND Id_Meta = @Id_Meta";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);
                crud.AdicionarParametros("Id_Meta", idMeta);

                var temCalculo = crud.Executar(CommandType.Text, SQL);
                if (int.Parse(temCalculo.ToString()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public int Id(int idCompetencia, int idEmpresa, int idEmpregado, int idMeta, double total)
        {
            crud = new CRUD();
            SQL = "SELECT Id " +
                    "FROM PossoMais " +
                    "WHERE Id_Competencia = @Id_Competencia " +
                    "AND Id_Empresa = @Id_Empresa " +
                    "AND Id_Empregado = @Id_Empregado " +
                    "AND Id_Meta = @Id_Meta " +
                    "AND Total = @Total";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);
                crud.AdicionarParametros("Id_Meta", idMeta);
                crud.AdicionarParametros("Total", total);

                var id = crud.Executar(CommandType.Text, SQL);
                if (id is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(id.ToString());
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public bool Calcular(int idCompetencia, int idEmpresa)
        {
            possoMais = new PossoMais();
            indicadorControle = new IndicadorControle();
            empregadoControle = new EmpregadoControle();
            metaPesoControle = new MetaPesoControle();
            chamadoControle = new ChamadoControle();
            pesquisaNotaControle = new PesquisaNotaControle();
            afastamentoControle = new AfastamentoControle();
            configAfastamentoControle = new ConfigAfastamentoControle();
            possoMaisControle = new PossoMaisControle();

            DataTable indicador = indicadorControle.IndicadorTabela("%%");
            DataTable empregado = empregadoControle.EmpregadoAtivoTabela(idEmpresa);

            int nota = pesquisaNotaControle.Nota(DateTime.Now.Date);
            int qtdAfastConfiguracao = configAfastamentoControle.QtdDiasConfig();

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
                    bool pesquisa = bool.Parse(item[3].ToString());
                    bool chamado = bool.Parse(item[4].ToString());
                    bool assiduidade = bool.Parse(item[5].ToString());
                    bool captura = bool.Parse(item[6].ToString());
                    bool feedback = bool.Parse(item[7].ToString());

                    if (pesquisa)
                    {
                        qtdOuPorcentagem = PorcentagemPesquisa(codigoEmpregado, nota, departamentoId);
                    }
                    if (chamado)
                    {
                        qtdOuPorcentagem = PorcentagemChamado('Q', idCompetencia, empresaId, empregadoId, departamentoId);
                    }
                    if (captura)
                    {
                        qtdOuPorcentagem = PorcentagemChamado('C', idCompetencia, empresaId, empregadoId, departamentoId);
                    }
                    if (assiduidade)
                    {
                        qtdOuPorcentagem = QuantidadeAssiduidade(idCompetencia, empresaId, empregadoId);
                    }
                    if (feedback)
                    {
                        qtdOuPorcentagem = QuantidadeFeedback(idCompetencia, empresaId, empregadoId);
                    }


                    /*Não grava posso mais se a meta não for encontrada*/
                    int idMeta = metaPesoControle.IdPorMeta(qtdOuPorcentagem, indicadorId);

                    if (idMeta == 0)
                    {
                        continue;
                    }
                    /*Não calcula empresa se o mesmo estiver com dias de afastamento igual ou maior que a configuração*/
                    if (afastamentoControle.IsEmpregado(idCompetencia, empresaId, empregadoId, qtdAfastConfiguracao))
                    {
                        continue;
                    }

                    possoMais.Id = Id(idCompetencia, empresaId, empregadoId, idMeta, qtdOuPorcentagem);
                    possoMais.Competencia = new Competencia
                    {
                        Id = idCompetencia
                    };
                    possoMais.Empresa = new Empresa
                    {
                        Id = empresaId
                    };
                    possoMais.Empregado = new Empregado
                    {
                        Id = empregadoId
                    };
                    possoMais.MetaPeso = new MetaPeso
                    {
                        Id = idMeta
                    };
                    possoMais.Total = qtdOuPorcentagem;

                    bool temCalculo = IsCalculo(idCompetencia, empresaId, empregadoId, idMeta);

                    //foreach (DataRow possoMaisRow in PossoMaisTabela(idCompetencia, empresaId, "%%").Rows)
                    //{
                    //    if (empregadoId != int.Parse(possoMaisRow[2].ToString()))
                    //    {
                    //        ExcluirPorCompetencia(idCompetencia, empregadoId);
                           
                    //    }
                    //    else
                    //    {
                    //        continue;
                    //    }
                    //}

                    if (temCalculo == false)
                    {
                        Gravar(possoMais);
                    }
                    else
                    {
                        Alterar(possoMais);
                    }



                }
            }

            return true;

        }
        public DataTable PossoMaisTabela(int idCompetencia, int idEmpresa, string nomeEmpregado)
        {
            crud = new CRUD();
            SQL = "SELECT PM.Id, EP.Codigo, EP.Id AS Id_Empregado, EP.Nome, PM.Total, DP.Descricao AS Departamento, MP.Peso, IC.Descricao AS Indicador " +
                    "FROM ((((((PossoMais PM " +
                    "INNER JOIN Competencia CP ON CP.Id = PM.Id_Competencia) " +
                    "INNER JOIN Empresa EM ON EM.Id = PM.Id_Empresa) " +
                    "INNER JOIN Empregado EP ON EP.Id = PM.Id_Empregado) " +
                    "INNER JOIN MetaPeso MP ON MP.Id = PM.Id_Meta) " +
                    "INNER JOIN Departamento DP ON DP.Id = EP.Id_Departamento) " +
                    "INNER JOIN Indicador  IC ON IC.Id = MP.Id_Indicador) " +
                    "WHERE PM.Id_Competencia = @Id_Competencia " +
                    "AND PM.Id_Empresa = @Id_Empresa " +
                    "AND EP.Nome LIKE @Nome " +
                    "ORDER BY EP.Nome ASC";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Nome", nomeEmpregado);

                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
