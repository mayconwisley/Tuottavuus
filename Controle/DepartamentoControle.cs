using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class DepartamentoControle
    {
        CRUD crud;
        string SQL;

        public bool Gravar(Departamento departamento)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Departamento (Descricao) " +
                  "VALUES (@Descricao)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", departamento.Descricao);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Departamento departamento)
        {
            crud = new CRUD();
            SQL = "UPDATE Departamento SET Descricao = @Descricao " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", departamento.Descricao);
                crud.AdicionarParametros("Id", departamento.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Departamento departamento)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Departamento " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", departamento.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(Departamento departamento)
        {
            crud = new CRUD();
            SQL = "SELECT Id " +
                  "FROM Departamento " +
                  "WHERE Descricao = @Descricao";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Descricao", departamento.Descricao);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable DepartamentoTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Descricao " +
                  "FROM Departamento " +
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
