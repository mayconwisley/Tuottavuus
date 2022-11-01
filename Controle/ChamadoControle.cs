using Banco_De_Dados;
using Modelo;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Controle
{
    public class ChamadoControle
    {
        CRUD crud;
        string SQL;
        EmpregadoControle empregadoControle;
        Utilitarios utilitarios;
        private ProgressBar PbCarregamento { get; set; }
        public ChamadoControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }
        public ChamadoControle(ref ProgressBar progressBar)
        {
            PbCarregamento = progressBar;
        }
        public bool Gravar(Chamado chamado)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Chamados (Id_Competencia, Id_Empresa, Id_Empregado, DataAbertura, " +
                    "Chamado, CodigoGrupoSolucao, DescGrupoSolucao, " +
                    "CodigoAtendente, NomeAtendente, CodigoNatureza, DescNatureza, CodigoTpAtividade, DescTpAtividade) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @DataAbertura, " +
                    "@Chamado, @CodigoGrupoSolucao, @DescGrupoSolucao, " +
                    "@CodigoAtendente, @NomeAtendente, @CodigoNatureza, @DescNatureza, @CodigoTpAtividade, @DescTpAtividade)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", chamado.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", chamado.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", chamado.Empregado.Id);
                crud.AdicionarParametros("DataAbertura", chamado.DataAbertura);
                crud.AdicionarParametros("Chamado", chamado.CodigoChamado);
                crud.AdicionarParametros("CodigoGrupoSolucao", chamado.CodigoGrupoSolucao);
                crud.AdicionarParametros("DescGrupoSolucao", chamado.DescGrupoSolucao);
                crud.AdicionarParametros("CodigoAtendente", chamado.CodigoAtendente);
                crud.AdicionarParametros("NomeAtendente", chamado.NomeAtendente);
                crud.AdicionarParametros("CodigoNatureza", chamado.CodigoNatureza);
                crud.AdicionarParametros("DescNatureza", chamado.DescNatureza);
                crud.AdicionarParametros("CodigoTpAtividade", chamado.CodigoTpAtividade);
                crud.AdicionarParametros("DescTpAtividade", chamado.DescTpAtividade);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool Alterar(Chamado chamado)
        {
            crud = new CRUD();
            SQL = "UPDATE Chamados SET Id_Competencia = @Id_Competencia, Id_Empresa = @Id_Empresa, Id_Empregado = @Id_Empregado, " +
                    "DataAbertura = @DataAbertura, Chamado = @Chamado, CodigoGrupoSolucao = @CodigoGrupoSolucao, DescGrupoSolucao = @DescGrupoSolucao, " +
                    "CodigoAtendente = @CodigoAtendente, NomeAtendente = @NomeAtendente, " +
                    "CodigoNatureza = @CodigoNatureza, DescNatureza = @DescNatureza, CodigoTpAtividade = @CodigoTpAtividade, DescTpAtividade = @DescTpAtividade " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", chamado.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", chamado.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", chamado.Empregado.Id);
                crud.AdicionarParametros("DataAbertura", chamado.DataAbertura);
                crud.AdicionarParametros("Chamado", chamado.CodigoChamado);
                crud.AdicionarParametros("CodigoGrupoSolucao", chamado.CodigoGrupoSolucao);
                crud.AdicionarParametros("DescGrupoSolucao", chamado.DescGrupoSolucao);
                crud.AdicionarParametros("CodigoAtendente", chamado.CodigoAtendente);
                crud.AdicionarParametros("NomeAtendente", chamado.NomeAtendente);
                crud.AdicionarParametros("CodigoNatureza", chamado.CodigoNatureza);
                crud.AdicionarParametros("DescNatureza", chamado.DescNatureza);
                crud.AdicionarParametros("CodigoTpAtividade", chamado.CodigoTpAtividade);
                crud.AdicionarParametros("DescTpAtividade", chamado.DescTpAtividade);
                crud.AdicionarParametros("Id", chamado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool Excluir(Chamado chamado)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Chamados " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", chamado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int IdPorChamado(int codigoChamado, int codigoNatureza)
        {
            crud = new CRUD();
            SQL = "SELECT Id " +
                  "FROM Chamados " +
                  "WHERE Chamado = @Chamado AND CodigoNatureza = @CodigoNatureza";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Chamado", codigoChamado);
                crud.AdicionarParametros("CodigoNatureza", codigoNatureza);

                var idChamado = crud.Executar(CommandType.Text, SQL);

                if (idChamado is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(idChamado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public double QtdChamadoAtendente(int idCompetencia, int idEmpresa, int idEmpregado)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(Id) AS Total " +
                  "FROM Chamados " +
                  "WHERE Id_Competencia = @Id_Competencia " +
                  "AND Id_Empresa = @Id_Empresa " +
                  "AND Id_Empregado = @Id_Empregado";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);

                var qtdChamado = crud.Executar(CommandType.Text, SQL);

                if (qtdChamado is null)
                {
                    return 0;
                }
                else
                {
                    return double.Parse(qtdChamado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public double QtdCapturadoAtendente(int idCompetencia, int idEmpresa, int idEmpregado)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(Id) AS Total " +
                  "FROM Chamados " +
                  "WHERE CodigoNatureza = 5 " +
                  "AND Id_Competencia = @Id_Competencia " +
                  "AND Id_Empresa = @Id_Empresa " +
                  "AND Id_Empregado = @Id_Empregado ";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);

                var qtdChamado = crud.Executar(CommandType.Text, SQL);

                if (qtdChamado is null)
                {
                    return 0;
                }
                else
                {
                    return double.Parse(qtdChamado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public double QtdFeedbackAtendente(int idCompetencia, int idEmpresa, int idEmpregado)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(Id) AS Total " +
                  "FROM Chamados " +
                  "WHERE Id_Competencia = @Id_Competencia " +
                  "AND CodigoTpAtividade = 22 " +
                  "AND Id_Empresa = @Id_Empresa " +
                  "AND Id_Empregado = @Id_Empregado";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);

                var qtdChamado = crud.Executar(CommandType.Text, SQL);

                if (qtdChamado is null)
                {
                    return 0;
                }
                else
                {
                    return double.Parse(qtdChamado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public double QtdChamado(int idCompetencia, int idEmpresa, int idDepartamento)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(C.Id) " +
                  "FROM Chamados C " +
                  "INNER JOIN Empregado E ON E.Id = C.Id_Empregado " +
                  "WHERE C.Id_Competencia = @Id_Competencia " +
                  "AND C.Id_Empresa = @Id_Empresa " +
                  "AND E.Id_Departamento = @Id_Departamento " +
                  "AND C.CodigoNatureza IN (5,8)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Departamento", idDepartamento);

                var qtdChamado = crud.Executar(CommandType.Text, SQL);

                if (qtdChamado is null)
                {
                    return 0;
                }
                else
                {
                    return double.Parse(qtdChamado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public double QtdChamadoCapturado(int idCompetencia, int idEmpresa, int idDepartamento)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(C.Id) AS Total " +
                  "FROM Chamados C " +
                  "INNER JOIN Empregado E ON E.Id = C.Id_Empregado " +
                  "WHERE C.CodigoNatureza = 5 " +
                  "AND C.Id_Empresa = @Id_Empresa " +
                  "AND C.Id_Competencia = @Id_Competencia " +
                  "AND E.Id_Departamento = @Id_Departamento";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Departamento", idDepartamento);

                var qtdChamado = crud.Executar(CommandType.Text, SQL);

                if (qtdChamado is null)
                {
                    return 0;
                }
                else
                {
                    return double.Parse(qtdChamado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable ChamadoTabela(string nomeAtendente)
        {
            crud = new CRUD();
            SQL = "SELECT Id, Id_Competencia, Id_Empresa, Id_Empregado, DataAbertura, " +
                    "Chamado, CodigoGrupoSolucao, DescGrupoSolucao, " +
                    "CodigoAtendente, NomeAtendente, CodigoNatureza, DescNatureza, CodigoTpAtividade, DescTpAtividade " +
                  "FROM Chamados " +
                  "WHERE NomeAtendente LIKE @NomeAtendente " +
                  "ORDER BY NomeAtendente ASC, DataAbertura DESC";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("NomeAtendente", nomeAtendente);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public DataTable CodigosGrupoSolucaoTabela(int idCompetencia)
        {
            crud = new CRUD();
            SQL = "SELECT CodigoGrupoSolucao " +
                  "FROM Chamados " +
                  "WHERE Id_Competencia = @Id_Competencia " +
                  "GROUP BY CodigoGrupoSolucao";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public DataTable QtdChamadoTabela(int idCompetencia, int idEmpresa)
        {
            crud = new CRUD();
            SQL = "SELECT CodigoAtendente, NomeAtendente, COUNT(CodigoNatureza) AS Total " +
                  "FROM Chamados " +
                  "WHERE CodigoNatureza IN (5,8) AND Id_Competencia = @Id_Competencia AND Id_Empresa = @Id_Empresa " +
                  "GROUP BY CodigoAtendente, NomeAtendente " +
                  "ORDER BY NomeAtendente ";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable QtdChamadoCapturadoTabela(int idCompetencia, int idEmpresa)
        {
            crud = new CRUD();
            SQL = "SELECT CodigoAtendente, NomeAtendente, COUNT(CodigoNatureza) AS Total " +
                  "FROM Chamados " +
                  "WHERE CodigoNatureza = 5 AND Id_Competencia = @Id_Competencia AND Id_Empresa = @Id_Empresa " +
                  "GROUP BY CodigoAtendente, NomeAtendente " +
                   "ORDER BY NomeAtendente ";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable QtdFeedbackTabela(int idCompetencia, int idEmpresa)
        {
            crud = new CRUD();
            SQL = "SELECT CodigoAtendente, NomeAtendente, COUNT(CodigoNatureza) AS Total " +
                  "FROM Chamados " +
                  "WHERE CodigoTpAtividade = 22 AND Id_Competencia = @Id_Competencia AND Id_Empresa = @Id_Empresa " +
                  "GROUP BY CodigoAtendente, NomeAtendente " +
                   "ORDER BY NomeAtendente ";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable QtdCapEncTabela(int idCompetencia, int idEmpresa)
        {
            crud = new CRUD();
            SQL = "SELECT SELECT DescNatureza, COUNT(CodigoNatureza) AS Total " +
                  "FROM Chamados " +
                  "WHERE  CodigoNatureza IN (5,8) AND Id_Competencia = @Id_Competencia AND Id_Empresa = @Id_Empresa " +
                  "GROUP BY DescNatureza " +
                   "ORDER BY NomeAtendente ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool ImportarAquivo(int idCompetencia, int idEmpresa, string caminhoArquivo, out ArrayList itensErro, out int qtdAtualizados, out int qtdGravados)
        {
            int idEmpregado = 0;
            qtdAtualizados = 0; qtdGravados = 0;

            empregadoControle = new EmpregadoControle();
            utilitarios = new Utilitarios();

            Chamado chamado = new Chamado();
            chamado.Competencia = new Competencia();
            chamado.Competencia.Id = idCompetencia;
            chamado.Empresa = new Empresa();
            chamado.Empresa.Id = idEmpresa;

            ArrayList arquivo = utilitarios.LerArquivo(caminhoArquivo);
            ArrayList linhaArquivo = new ArrayList();
            itensErro = new ArrayList();

            try
            {
                PbCarregamento.Maximum = arquivo.Count;

                for (int i = 1; i < arquivo.Count; i++)
                {
                    linhaArquivo.Clear();

                    PbCarregamento.Value = i + 1;
                    foreach (var item in arquivo[i].ToString().Split(';'))
                    {
                        linhaArquivo.Add(item);
                    }

                    idEmpregado = empregadoControle.IdPorCodigo(int.Parse(linhaArquivo[4].ToString()));

                    if (idEmpregado == 0)
                    {
                        itensErro.Add("Linha: " + (i + 1) + " - " + arquivo[i]);

                        continue;
                    }

                    int idChamado = IdPorChamado(int.Parse(linhaArquivo[1].ToString()), int.Parse(linhaArquivo[6].ToString()));

                    chamado.Id = idChamado;
                    chamado.Empregado = new Empregado();
                    chamado.Empregado.Id = idEmpregado;
                    chamado.DataAbertura = DateTime.Parse(linhaArquivo[0].ToString());
                    chamado.CodigoChamado = int.Parse(linhaArquivo[1].ToString());
                    chamado.CodigoGrupoSolucao = int.Parse(linhaArquivo[2].ToString());
                    chamado.DescGrupoSolucao = linhaArquivo[3].ToString().Replace("\"", "");
                    chamado.CodigoAtendente = int.Parse(linhaArquivo[4].ToString());
                    chamado.NomeAtendente = linhaArquivo[5].ToString().Replace("\"", "").ToUpper();
                    chamado.CodigoNatureza = int.Parse(linhaArquivo[6].ToString());
                    chamado.DescNatureza = linhaArquivo[7].ToString().Replace("\"", "");
                    chamado.CodigoTpAtividade = int.Parse(linhaArquivo[8].ToString());
                    chamado.DescTpAtividade = linhaArquivo[9].ToString().Replace("\"", "");

                    if (idChamado != 0)
                    {
                        Alterar(chamado);
                        qtdAtualizados++;
                    }
                    else
                    {
                        Gravar(chamado);
                        qtdGravados++;
                    }
                }

                // ChamadoTabela("%%");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ErroLista(string diretorio, ArrayList arrayList)
        {
            if (arrayList.Count > 0)
            {
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                string caminhoErro = diretorio + "\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt";

                StreamWriter sw = File.CreateText(caminhoErro);

                sw.WriteLine("Erro: Codigo do atendente não encontrado no sistema");
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sw.WriteLine(arrayList[i].ToString());
                }

                sw.Close();
                Process.Start(caminhoErro);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
