using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class AssiduidadeControle
    {
        CRUD crud;
        string SQL;

        public AssiduidadeControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }
        public bool Gravar(Assiduidade assiduidade)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Assiduidade (Id_Competencia, Id_Empresa, Id_Empregado, AtrasoFalta) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @AtrasoFalta)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", assiduidade.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", assiduidade.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", assiduidade.Empregado.Id);
                crud.AdicionarParametros("AtrasoFalta", assiduidade.AtrasoFalta);

                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Assiduidade assiduidade)
        {
            crud = new CRUD();
            SQL = "UPDATE Assiduidade  SET Id_Competencia = @Id_Competencia, Id_Empresa = @Id_Empresa, " +
                  "Id_Empregado = @Id_Empregado, AtrasoFalta = @AtrasoFalta " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", assiduidade.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", assiduidade.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", assiduidade.Empregado.Id);
                crud.AdicionarParametros("AtrasoFalta", assiduidade.AtrasoFalta);
                crud.AdicionarParametros("Id", assiduidade.Id);

                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Assiduidade assiduidade)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Assiduidade " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", assiduidade.Id);

                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int AtrasoFalta(Assiduidade assiduidade)
        {
            crud = new CRUD();
            SQL = "SELECT SUM(AtrasoFalta) AS Total " +
                  "FROM Assiduidade " +
                  "WHERE Id_Competencia = @Id_Competencia " +
                  "AND Id_Empresa = @Id_Empresa " +
                  "AND Id_Empregado = @Id_Empregado";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", assiduidade.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", assiduidade.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", assiduidade.Empregado.Id);

                var atrasoFalta = crud.Executar(CommandType.Text, SQL);

                if (String.IsNullOrEmpty(atrasoFalta.ToString()))
                {
                    return 0;
                }
                else
                {
                    return int.Parse(atrasoFalta.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable AssiduidadeTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Id_Competencia, Id_Empresa, Id_Empregado, AtrasoFalta " +
                  "FROM Assiduidade";

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
        public DataTable AssiduidadeTabelaConsulta(int idCompetencia, int idEmpresa)
        {
            crud = new CRUD();
            SQL = "SELECT A.Id_Empregado, E.Nome, A.AtrasoFalta " +
                  "FROM Assiduidade A " +
                  "INNER JOIN Empregado E ON A.Id_Empregado = E.Id " +
                  "WHERE A.Id_Competencia = @Id_Competencia " +
                  "AND A.Id_Empresa = @Id_Empresa";


            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Coompetencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);

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
