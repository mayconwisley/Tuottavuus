using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class PesquisaNotaControle
    {
        CRUD crud;
        string SQL;

        public PesquisaNotaControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }

        public bool Gravar(PesquisaNota pesquisaNota)
        {
            crud = new CRUD();
            SQL = "INSERT INTO PesquisaNota (Nota, Data) " +
                  "VALUES (@Nota, @Data)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nota", pesquisaNota.Nota);
                crud.AdicionarParametros("Data", pesquisaNota.Data);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool Alterar(PesquisaNota pesquisaNota)
        {
            crud = new CRUD();
            SQL = "UPDATE PesquisaNota  SET Nota = @Nota, Data = @Data " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nota", pesquisaNota.Nota);
                crud.AdicionarParametros("Data", pesquisaNota.Data);
                crud.AdicionarParametros("Id", pesquisaNota.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(PesquisaNota pesquisaNota)
        {
            crud = new CRUD();
            SQL = "DELETE FROM PessquisaNota " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", pesquisaNota.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaNotaTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Nota, Data " +
                  "FROM PesquisaNota";

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

    }
}
