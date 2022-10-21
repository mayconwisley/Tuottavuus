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
                    "Chamado, CodigoGrupoSolucao, DescGrupoSolucao, CodigoArea, DescArea, " +
                    "CodigoAtendente, NomeAtendente, CodigoNatureza, DescNatureza, CodigoTpAtividade, DescTpAtividade) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @DataAbertura, " +
                    "@Chamado, @CodigoGrupoSolucao, @DescGrupoSolucao, @CodigoArea, @DescArea, " +
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
                crud.AdicionarParametros("CodigoArea", chamado.CodigoArea);
                crud.AdicionarParametros("DescArea", chamado.DescArea);
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
                    "CodigoArea = @CodigoArea, DescArea = @DescArea, CodigoAtendente = @CodigoAtendente, NomeAtendente = @NomeAtendente, " +
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
                crud.AdicionarParametros("CodigoArea", chamado.CodigoArea);
                crud.AdicionarParametros("DescArea", chamado.DescArea);
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
        public int IdPorChamado(int codigoChamado)
        {
            crud = new CRUD();
            SQL = "SELECT Id " +
                  "FROM Chamados " +
                  "WHERE Chamado = @Chamado";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Chamado", codigoChamado);

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
        public DataTable PesquisaTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id_Competencia, Id_Empresa, Id_Empregado, DataAbertura, " +
                    "Chamado, CodigoGrupoSolucao, DescGrupoSolucao, CodigoArea, DescArea, " +
                    "CodigoAtendente, NomeAtendente, CodigoNatureza, DescNatureza, CodigoTpAtividade, DescTpAtividade " +
                  "FROM Chamados";

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

                    idEmpregado = empregadoControle.IdPorCodigo(int.Parse(linhaArquivo[1].ToString()));

                    if (idEmpregado == 0)
                    {
                        itensErro.Add("Linha: " + (i + 1) + " - " + arquivo[i]);

                        continue;
                    }

                    int idChamado = IdPorChamado(int.Parse(linhaArquivo[4].ToString()));

                    chamado.Id = idChamado;
                    chamado.Empregado = new Empregado();
                    chamado.Empregado.Id = idEmpregado;
                    chamado.DataAbertura = DateTime.Parse(linhaArquivo[0].ToString());
                    chamado.CodigoChamado = int.Parse(linhaArquivo[1].ToString());
                    chamado.CodigoGrupoSolucao = int.Parse(linhaArquivo[2].ToString());
                    chamado.DescGrupoSolucao = linhaArquivo[3].ToString();
                    chamado.CodigoAtendente = int.Parse(linhaArquivo[4].ToString());
                    chamado.NomeAtendente = linhaArquivo[5].ToString();
                    chamado.CodigoNatureza = int.Parse(linhaArquivo[6].ToString());
                    chamado.DescNatureza = linhaArquivo[7].ToString();
                    chamado.CodigoTpAtividade = int.Parse(linhaArquivo[8].ToString());
                    chamado.DescTpAtividade = linhaArquivo[9].ToString();

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
