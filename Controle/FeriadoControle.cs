using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class FeriadoControle
    {
        CRUD crud;
        string SQL;

        public bool Gravar(Feriado feriado)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Feriado (Ano, Data_Feriado, Descricao) " +
            "VALUES (@Ano, @Data_Feriado, @Descricao)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Ano", feriado.Ano);
                crud.AdicionarParametros("Data_Feriado", feriado.Data);
                crud.AdicionarParametros("Descricao", feriado.Descricao);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Feriado feriado)
        {
            crud = new CRUD();
            SQL = "UPDATE Feriado SET Ano = @Ano, Data_Feriado = @Data_Feriado, Descricao = @Descricao " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Ano", feriado.Ano);
                crud.AdicionarParametros("Data_Feriado", feriado.Data);
                crud.AdicionarParametros("Descricao", feriado.Descricao);
                crud.AdicionarParametros("Id", feriado.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Feriado feriado)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Feriado " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", feriado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int TotalFeriadoCompetencia(DateTime dtCompetencia)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(Id) FROM Feriado " +
            "WHERE MONTH(Data_Feriado) = MONTH(@Data_Feriado) ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Data_Feriado", dtCompetencia.Date);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable FeriadoTabelaCompetencia(DateTime dtCompetencia)
        {
            crud = new CRUD();
            SQL = "SELECT Id, Ano, Data_Feriado, Descricao " +
            "FROM Feriado " +
            "WHERE YEAR(Data_Feriado) = YEAR(@Ano) " +
            "ORDER BY Data_Feriado DESC";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Ano", dtCompetencia.Date);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable FeriadoTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Ano, Data_Feriado, Descricao " +
            "FROM Feriado " +
            "ORDER BY Data_Feriado ";
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
