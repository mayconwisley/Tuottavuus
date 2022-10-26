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
    public class PesquisaControle
    {
        CRUD crud;
        string SQL;
        EmpregadoControle empregadoControle;
        Utilitarios utilitarios;
        private ProgressBar PbCarregamento { get; set; }


        public PesquisaControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }

        public PesquisaControle(ref ProgressBar pbCarregamento)
        {
            PbCarregamento = pbCarregamento;
        }

        public bool Gravar(Pesquisa pesquisa)
        {
            crud = new CRUD();
            SQL = "INSERT INTO PesquisaAvaliacao (Id_Competencia, Id_Empresa, Id_Empregado, DataAbertura, CodigoAtendente, NomeAtendente, NotaConceito, Chamado)" +
                "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @DataAbertura, @CodigoAtendente, @NomeAtendente, @NotaConceito, @Chamado)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", pesquisa.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", pesquisa.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", pesquisa.Empregado.Id);
                crud.AdicionarParametros("DataAbertura", pesquisa.DataAbertura);
                crud.AdicionarParametros("CodigoAtendente", pesquisa.CodigoAtendente);
                crud.AdicionarParametros("NomeAtendente", pesquisa.NomeAtendente);
                crud.AdicionarParametros("NotaConceito", pesquisa.NotaConceito);
                crud.AdicionarParametros("Chamado", pesquisa.Chamado);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public bool Alterar(Pesquisa pesquisa)
        {
            crud = new CRUD();
            SQL = "UPDATE PesquisaAvaliacao SET Id_Competencia =@Id_Competencia, Id_Empresa = @Id_Empresa, Id_Empregado = @Id_Empregado, " +
                  "DataAbertura = @DataAbertura, CodigoAtendente = @CodigoAtendente, NomeAtendente = @NomeAtendente, NotaConceito = @NotaConceito, Chamado = @Chamado " +
                  "WHERE Id = @Id";

            try
            {

                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", pesquisa.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", pesquisa.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", pesquisa.Empregado.Id);
                crud.AdicionarParametros("DataAbertura", pesquisa.DataAbertura);
                crud.AdicionarParametros("CodigoAtendente", pesquisa.CodigoAtendente);
                crud.AdicionarParametros("NomeAtendente", pesquisa.NomeAtendente);
                crud.AdicionarParametros("NotaConceito", pesquisa.NotaConceito);
                crud.AdicionarParametros("Chamado", pesquisa.Chamado);
                crud.AdicionarParametros("Id", pesquisa.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public bool Excluir(Pesquisa pesquisa)
        {
            crud = new CRUD();
            SQL = "DELETE FROM PesquisaAvaliacao " +
                  "WHERE Id = @Id";

            try
            {

                crud.LimparParametros();
                crud.AdicionarParametros("Id", pesquisa.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public decimal NotaAvaliacaoAtendente(int codigoAtendente)
        {
            crud = new CRUD();
            SQL = "SELECT SUM(NotaConceito) " +
                  "FROM PesquisaAvaliacao" +
                  "WHERE CodigoAtendente = @CodigoAtendente";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("CodigoAtendente", codigoAtendente);

                var totalNota = crud.Executar(CommandType.Text, SQL);

                if (totalNota is null)
                {
                    return 0;
                }
                else
                {
                    return decimal.Parse(totalNota.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int QtdAvaliacaoAtendente(int codigoAtendente)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(Id) " +
                  "FROM PesquisaAvaliacao" +
                  "WHERE CodigoAtendente = @CodigoAtendente";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("CodigoAtendente", codigoAtendente);

                var countAvaliacao = crud.Executar(CommandType.Text, SQL);

                if (countAvaliacao is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(countAvaliacao.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int IdPorChamado(int codigoChamado)
        {
            crud = new CRUD();
            SQL = "SELECT Id " +
                  "FROM PesquisaAvaliacao " +
                  "WHERE Chamado = @Chamado";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Chamado", codigoChamado);

                var idPesquisa = crud.Executar(CommandType.Text, SQL);

                if (idPesquisa is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(idPesquisa.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable PesquisaTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Id_Competencia, Id_Empresa, Id_Empregado, DataAbertura, CodigoAtendente, NomeAtendente, NotaConceito, Chamado " +
                "FROM PesquisaAvaliacao";

            try
            {
                crud.LimparParametros();
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public DataTable PesquisaTabelaEmpresa(int idCompetencia, int idEmpresa)
        {
            crud = new CRUD();
            SQL = "SELECT PA.Id_Competencia, PA.Id_Empresa, PA.Id_Empregado, PA.CodigoAtendente, PA.NomeAtendente, COUNT(PA.Id) AS QtdChamado, SUM(PA.NotaConceito) AS NotaConceito, SUM(PA.NotaConceito) / COUNT(PA.Id) AS AvaliacaoMedia " +
                  "FROM PesquisaAvaliacao PA " +
                  "WHERE PA.Id_Competencia = @Id_Competencia AND PA.Id_Empresa = @Id_Empresa " +
                  "GROUP BY PA.Id_Competencia, PA.Id_Empresa, PA.Id_Empregado, PA.CodigoAtendente, PA.NomeAtendente " +
                  "ORDER BY PA.NomeAtendente ASC";

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

            Pesquisa pesquisa = new Pesquisa();
            pesquisa.Competencia = new Competencia();
            pesquisa.Competencia.Id = idCompetencia;
            pesquisa.Empresa = new Empresa();
            pesquisa.Empresa.Id = idEmpresa;

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

                    idEmpregado = empregadoControle.IdPorCodigo(int.Parse(linhaArquivo[1].ToString()));

                    if (idEmpregado == 0)
                    {
                        itensErro.Add("Linha: " + (i + 1) + " - " + arquivo[i]);

                        continue;
                    }

                    int idPesquisa = IdPorChamado(int.Parse(linhaArquivo[4].ToString()));

                    pesquisa.Id = idPesquisa;
                    pesquisa.Empregado = new Empregado();
                    pesquisa.Empregado.Id = idEmpregado;
                    pesquisa.DataAbertura = DateTime.Parse(linhaArquivo[0].ToString());
                    pesquisa.CodigoAtendente = int.Parse(linhaArquivo[1].ToString());
                    pesquisa.NomeAtendente = linhaArquivo[2].ToString().Replace("\"", "").ToUpper();
                    pesquisa.NotaConceito = int.Parse(linhaArquivo[3].ToString());
                    pesquisa.Chamado = int.Parse(linhaArquivo[4].ToString());

                    if (idPesquisa != 0)
                    {
                        Alterar(pesquisa);
                        qtdAtualizados++;
                    }
                    else
                    {
                        Gravar(pesquisa);
                        qtdGravados++;
                    }
                }

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
