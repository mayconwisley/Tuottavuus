using Banco_De_Dados;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Controle
{
    public class PesquisaControle
    {
        CRUD crud;
        string SQL;
        EmpregadoControle empregadoControle;

        public PesquisaControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
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


        public bool ImportarAquivo(int idCompetencia, int idEmpresa, string caminhoArquivo, out ArrayList itensErro)
        {
            int idEmpregado = 0;

            empregadoControle = new EmpregadoControle();

            Pesquisa pesquisa = new Pesquisa();
            pesquisa.Competencia = new Competencia();
            pesquisa.Competencia.Id = idCompetencia;
            pesquisa.Empresa = new Empresa();
            pesquisa.Empresa.Id = idEmpresa;


            ArrayList linhaArquivo = new ArrayList();
            ArrayList itensLinha = new ArrayList();
            itensErro = new ArrayList();

            using (var arquivo = new StreamReader(caminhoArquivo))
            {
                string linha = string.Empty;

                while ((linha = arquivo.ReadLine()) != null)
                {
                    linhaArquivo.Add(linha);
                }
            }

            try
            {
                for (int i = 1; i < linhaArquivo.Count; i++)
                {
                    itensLinha.Clear();
                    foreach (var item in linhaArquivo[i].ToString().Split(';'))
                    {
                        itensLinha.Add(item);
                    }

                    idEmpregado = empregadoControle.IdPorCodigo(int.Parse(itensLinha[1].ToString()));

                    if (idEmpregado == 0)
                    {
                        itensErro.Add("Linha: " + (i + 1) + " - " + linhaArquivo[i]);

                        continue;
                    }

                    pesquisa.Empregado = new Empregado();
                    pesquisa.Empregado.Id = idEmpregado;
                    pesquisa.DataAbertura = DateTime.Parse(itensLinha[0].ToString());
                    pesquisa.CodigoAtendente = int.Parse(itensLinha[1].ToString());
                    pesquisa.NomeAtendente = itensLinha[2].ToString().Replace("\"", "");
                    pesquisa.NotaConceito = int.Parse(itensLinha[3].ToString());
                    pesquisa.Chamado = int.Parse(itensLinha[4].ToString());

                    Gravar(pesquisa);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ErroLista(string diretorio, ArrayList arrayList)
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


                throw new Exception("Erro ao importar aquivos...");
              

            }
            else
            {
                throw new Exception("Arquivo importado com sucesso");
            }

        }
    }
}
