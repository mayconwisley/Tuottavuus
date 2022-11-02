using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class AtividadeControle
    {
        CRUD crud;
        string SQL;

        public AtividadeControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }

        public bool Gravar(Atividade atividade)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Atividade (Descricao, Ativo) " +
                "VALUES (@Descricao, @Ativo)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", atividade.Descricao);
                crud.AdicionarParametros("Ativo", atividade.Ativo);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Atividade atividade)
        {
            crud = new CRUD();
            SQL = "UPDATE Atividade SET Descricao = @Descricao, Ativo = @Ativo " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", atividade.Descricao);
                crud.AdicionarParametros("Ativo", atividade.Ativo);
                crud.AdicionarParametros("Id", atividade.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Atividade atividade)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Atividade " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", atividade.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(string descricaoAtividade)
        {
            crud = new CRUD();
            SQL = "SELECT Id FROM Atividade " +
                "WHERE Descricao = @Descricao";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", descricaoAtividade);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable AtividadeComboBox()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Descricao " +
                "FROM Atividade " +
                "WHERE Ativo = 1 " +
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
        public DataTable AtividadeTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Descricao, Ativo " +
                "FROM Atividade " +
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
