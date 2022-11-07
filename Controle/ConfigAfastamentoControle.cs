using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class ConfigAfastamentoControle
    {
        CRUD crud;
        string SQL;

        public ConfigAfastamentoControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }

        public bool Gravar(ConfigAfastamento configAfastamento)
        {

            crud = new CRUD();
            SQL = "INSERT INTO ConfiguracaoAfastamento (Total_Dias) " +
                  "VALUES(@Total_Dias)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Total_Dias", configAfastamento.TotalDias);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(ConfigAfastamento configAfastamento)
        {

            crud = new CRUD();
            SQL = "UPDATE ConfiguracaoAfastamento SET Total_Dias = @Total_Dias " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Total_Dias", configAfastamento.TotalDias);
                crud.AdicionarParametros("Id", configAfastamento.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(ConfigAfastamento configAfastamento)
        {

            crud = new CRUD();
            SQL = "DELETE FROM ConfiguracaoAfastamento " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", configAfastamento.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int QtdDiasConfig()
        {
            crud = new CRUD();
            SQL = "SELECT Total_Dias " +
                  "FROM  ConfiguracaoAfastamento";

            try
            {
                crud.LimparParametros();

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

        public DataTable ConfigAfastamentoTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Total_Dias " +
                  "FROM ConfiguracaoAfastamento ";

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
