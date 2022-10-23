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
            SQL = String.Empty;
        }
        public bool Gravar(Indicador indicador)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Indicador (Descricao, Ativo, Pesquisa) " +
                "VALUES (@Descricao, @Ativo, @Pesquisa)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", indicador.Descricao);
                crud.AdicionarParametros("Ativo", indicador.Ativo);
                crud.AdicionarParametros("Pesquisa", indicador.Pesquisa);
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
            SQL = "UPDATE Indicador SET Descricao = @Descricao, Ativo = @Ativo, Pesquisa = @Pesquisa " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", indicador.Descricao);
                crud.AdicionarParametros("Ativo", indicador.Ativo);
                crud.AdicionarParametros("Pesquisa", indicador.Pesquisa);
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
            SQL = "SELECT Id, Descricao, Ativo, Pesquisa " +
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
