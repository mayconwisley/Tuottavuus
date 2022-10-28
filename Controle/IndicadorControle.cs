using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class IndicadorControle
    {
        CRUD crud;
        string SQL;
        public IndicadorControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }
        public bool Gravar(Indicador indicador)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Indicador (Descricao, Ativo, Pesquisa, Chamado, Assiduidade, Captura, Feedback) " +
                  "VALUES (@Descricao, @Ativo, @Pesquisa, @Chamado, @Assiduidade, @Captura, @Feedback)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", indicador.Descricao);
                crud.AdicionarParametros("Ativo", indicador.Ativo);
                crud.AdicionarParametros("Pesquisa", indicador.Pesquisa);
                crud.AdicionarParametros("Chamado", indicador.Chamado);
                crud.AdicionarParametros("Assiduidade", indicador.Assiduidade);
                crud.AdicionarParametros("Captura", indicador.Captura);
                crud.AdicionarParametros("Feedback", indicador.Feedback);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Indicador indicador)
        {
            crud = new CRUD();
            SQL = "UPDATE Indicador SET Descricao = @Descricao, Ativo = @Ativo, Pesquisa = @Pesquisa, " +
                  "Chamado = @Chamado, Assiduidade = @Assiduidade, Captura = @Captura, Feedback = @Feedback " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", indicador.Descricao);
                crud.AdicionarParametros("Ativo", indicador.Ativo);
                crud.AdicionarParametros("Pesquisa", indicador.Pesquisa);
                crud.AdicionarParametros("Chamado", indicador.Chamado);
                crud.AdicionarParametros("Assiduidade", indicador.Assiduidade);
                crud.AdicionarParametros("Captura", indicador.Captura);
                crud.AdicionarParametros("Feedback", indicador.Feedback);
                crud.AdicionarParametros("Id", indicador.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Indicador indicador)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Indicador " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", indicador.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(string descricaoIndicador)
        {
            crud = new CRUD();
            SQL = "SELECT Id FROM Indicador " +
                "WHERE Descricao = @Descricao";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", descricaoIndicador);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable IndicadorComboBox()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Descricao " +
                "FROM Indicador " +
                "WHERE Ativo = Yes " +
                "ORDER BY Descricao ";
            try
            {
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable IndicadorTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Descricao, Ativo, Pesquisa, Chamado, Assiduidade, Captura, Feedback " +
                  "FROM Indicador " +
                  "ORDER BY Descricao ";
            try
            {
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
