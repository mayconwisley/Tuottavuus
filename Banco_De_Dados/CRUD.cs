using System;
using System.Data;
using System.Data.SqlClient;

namespace Banco_De_Dados
{
    public class CRUD : Conexao
    {
        SqlCommand sqlCommand;
        readonly SqlParameterCollection parameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            parameterCollection.Clear();
        }
        public void AdicionarParametros(string nome, object valor)
        {
            parameterCollection.Add(new SqlParameter(nome, valor));
        }
        public object Executar(CommandType commandType, string SQL)
        {
            if (Conectar())
            {
                try
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandType = commandType;
                    sqlCommand.CommandText = SQL;
                    sqlCommand.CommandTimeout = 7200;

                    foreach (SqlParameter sqlParameter in parameterCollection)
                    {
                        sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                    }
                    return sqlCommand.ExecuteScalar();
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
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandType = commandType;
                    sqlCommand.CommandText = SQL;
                    sqlCommand.CommandTimeout = 7200;

                    foreach (SqlParameter sqlParameter in parameterCollection)
                    {
                        sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                    }

                    SqlDataAdapter sqkDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqkDataAdapter.Fill(dataTable);
              
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
