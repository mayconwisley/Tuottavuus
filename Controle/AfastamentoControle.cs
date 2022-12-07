using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class AfastamentoControle
    {
        CRUD crud;
        string SQL;
        public AfastamentoControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }
        public bool Gravar(Afastamento afastamento)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Afastamento (Id_Competencia, Id_Empresa, Id_Empregado, Total_Dias) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @Total_Dias)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", afastamento.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", afastamento.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", afastamento.Empregado.Id);
                crud.AdicionarParametros("Total_Dias", afastamento.TotalDias);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public bool Alterar(Afastamento afastamento)
        {
            crud = new CRUD();
            SQL = "UPDATE Afastamento  SET Id_Competencia = @Id_Competencia, Id_Empresa = @Id_Empresa, " +
                  "Id_Empregado = @Id_Empregado, Total_Dias = @Total_Dias " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", afastamento.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", afastamento.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", afastamento.Empregado.Id);
                crud.AdicionarParametros("Total_Dias", afastamento.TotalDias);
                crud.AdicionarParametros("Id", afastamento.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public bool Excluir(Afastamento afastamento)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Afastamento " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", afastamento.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public int QtdAfastadoConfig(int qtdConfig, int idDepartamento)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(*) " +
                  "FROM Afastamento AFA " +
                  "INNER JOIN Empregado EMP ON AFA.Id_Empregado = EMP.Id " +
                  "WHERE AFA.Total_Dias >= @Total_Dias " +
                  "AND EMP.Id_Departamento = @Id_Departamento";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Total_Dias", qtdConfig);
                crud.AdicionarParametros("Id_Departamento", idDepartamento);

                var qtd = crud.Executar(CommandType.Text, SQL);

                if (qtd is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(qtd.ToString());
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool IsEmpregado(int idCompetencia, int idEmpresa, int idEmpregado, int qtdAfastConfig)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(*) " +
                  "FROM Afastamento " +
                  "WHERE Id_Competencia = @Id_Competencia " +
                  "AND Id_Empresa = @Id_Empresa " +
                  "AND Id_Empregado = @Id_Empregado " +
                  "AND Total_Dias >= @Total_Dias";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", idCompetencia);
                crud.AdicionarParametros("Id_Empresa", idEmpresa);
                crud.AdicionarParametros("Id_Empregado", idEmpregado);
                crud.AdicionarParametros("Total_Dias", qtdAfastConfig);
                var tem = crud.Executar(CommandType.Text, SQL);

                if (int.Parse(tem.ToString()) > 0)
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
        public DataTable AfastamentoTabela(string nome)
        {
            crud = new CRUD();
            SQL = "SELECT AFA.Id, AFA.Id_Empregado, EMP.Nome, AFA.Total_Dias " +
                  "FROM Afastamento AFA " +
                  "INNER JOIN Empregado EMP ON AFA.Id_Empregado = EMP.Id " +
                  "WHERE EMP.Nome LIKE @Nome " +
                  "ORDER BY EMP.Nome ASC";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", nome);
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
