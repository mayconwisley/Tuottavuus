using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class EmpresaControle
    {
        CRUD crud;
        string SQL;
        public EmpresaControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }
        public bool Gravar(Empresa empresa)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Empresa (Nome, Ativo) " +
                  "VALUES (@Nome, @Ativo)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empresa.Nome);
                crud.AdicionarParametros("Ativo", empresa.Ativo);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Empresa empresa)
        {
            crud = new CRUD();
            SQL = "UPDATE Empresa SET Nome = @Nome, Ativo = @Ativo " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empresa.Nome);
                crud.AdicionarParametros("Ativo", empresa.Ativo);
                crud.AdicionarParametros("Id", empresa.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Empresa empresa)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Empresa " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", empresa.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(string empresaNome)
        {
            crud = new CRUD();
            SQL = "SELECT Id " +
                  "FROM Empresa " +
                  "WHERE Nome = @Nome";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empresaNome);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable EmpresaComboBox()
        {
            crud = new CRUD();
            SQL = "SELECT Id, CONCAT(Id, ' - ', Nome) AS Nome " +
                  "FROM Empresa " +
                  "WHERE Ativo = 1 " +
                  "ORDER BY Nome ";
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
        public DataTable EmpresaTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Nome, Ativo " +
                  "FROM Empresa " +
                  "ORDER BY Nome ";
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
