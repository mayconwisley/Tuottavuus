using System;
using System.Data;
using System.Data.OleDb;

namespace Banco_De_Dados
{
    public class CRUD : Conexao
    {
        OleDbCommand dbCommand;
        OleDbParameterCollection parameterCollection = new OleDbCommand().Parameters;

        public void LimparParametros()
        {
            parameterCollection.Clear();
        }

        public void AdicionarParametros(string nome, object valor)
        {
            parameterCollection.Add(new OleDbParameter(nome, valor));
        }

        public object Executar(CommandType commandType, string SQL)
        {
            if (Conectar())
            {
                try
                {
                    dbCommand = dbConnection.CreateCommand();
                    dbCommand.CommandType = commandType;
                    dbCommand.CommandText = SQL;
                    dbCommand.CommandTimeout = 7200;

                    foreach (OleDbParameter dbParameter in parameterCollection)
                    {
                        dbCommand.Parameters.Add(new OleDbParameter(dbParameter.ParameterName, dbParameter.Value));
                    }
                    return dbCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                return null;
            }
        }

        public DataTable ConsultaTabela(CommandType commandType, string SQL)
        {
            if (Conectar())
            {
                try
                {
                    dbCommand = dbConnection.CreateCommand();
                    dbCommand.CommandType = commandType;
                    dbCommand.CommandText = SQL;
                    dbCommand.CommandTimeout = 7200;

                    foreach (OleDbParameter dbParameter in parameterCollection)
                    {
                        dbCommand.Parameters.Add(new OleDbParameter(dbParameter.ParameterName, dbParameter.Value));
                    }
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(dbCommand);
                    DataTable dataTable = new DataTable();
                    oleDbDataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
