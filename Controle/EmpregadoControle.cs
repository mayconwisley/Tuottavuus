using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class EmpregadoControle
    {
        CRUD crud;
        string SQL;
        public EmpregadoControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }
        public bool Gravar(Empregado empregado)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Empregado (Nome,  Ativo, Id_Empresa, Id_Departamento) " +
            "VALUES (@Nome, @Ativo, @Id_Empresa, @Id_Departamento)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empregado.Nome);
                crud.AdicionarParametros("Ativo", empregado.Ativo);
                crud.AdicionarParametros("Id_Empresa", empregado.Empresa.Id);
                crud.AdicionarParametros("Id_Departamento", empregado.Departamento.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Empregado empregado)
        {
            crud = new CRUD();
            SQL = "UPDATE Empregado SET Nome = @Nome, Ativo = @Ativo, Id_Empresa = @Id_Empresa, Id_Departamento = @Id_Departamento " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empregado.Nome);
                crud.AdicionarParametros("Ativo", empregado.Ativo);
                crud.AdicionarParametros("Id_Empresa", empregado.Empresa.Id);
                crud.AdicionarParametros("Id_Departamento", empregado.Departamento.Id);
                crud.AdicionarParametros("Id", empregado.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Empregado empregado)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Empregado " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(string empregadoNome)
        {
            crud = new CRUD();
            SQL = "SELECT Id FROM Empregado " +
            "WHERE Nome = @Nome";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empregadoNome);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
        }
        public DataTable EmpregadoComboBox(int empresaId)
        {
            crud = new CRUD();
            SQL = "SELECT Empregado.Id, Empregado.Id & ' - ' & Empregado.Nome AS Nome " +
            "FROM (Empregado " +
            "INNER JOIN Empresa ON Empregado.Id_Empresa = Empresa.Id) " +
            "WHERE Empregado.Ativo = Yes AND Empresa.Id = @EmpresaId " +
            "ORDER BY Empregado.Nome ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("EmpresaId", empresaId);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable EmpregadoTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Empregado.Id, Empregado.Nome, Empregado.Ativo, Empresa.Id & ' - ' & Empresa.Nome AS EmpresaNome, Departamento.Descricao AS DepartamentoDescricao " +
            "FROM ((Empregado " +
            "INNER JOIN Empresa ON Empregado.Id_Empresa = Empresa.Id) " +
            "INNER JOIN Departamento ON Empregado.Id_Departamento = Departamento.Id) " +
            "ORDER BY Empregado.Nome ";
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
        public DataTable EmpregadoTabelaCalculo(int empresaId)
        {
            crud = new CRUD();
            SQL = "SELECT Empregado.Id " +
            "FROM ((Empregado " +
            "INNER JOIN Empresa ON Empregado.Id_Empresa = Empresa.Id) " +
            "INNER JOIN Departamento ON Empregado.Id_Departamento = Departamento.Id) " +
            "WHERE Empregado.Ativo = Yes AND Empregado.Id_Empresa = @Id_Empresa " +
            "ORDER BY Empregado.Nome ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Empresa", empresaId);
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
