using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Banco_De_Dados
{
    public class Conexao
    {
        protected SqlConnection sqlConnection = new SqlConnection();

        private string StrConnectionSQLServer()
        {
           

            var connectionString = ConfigurationManager.ConnectionStrings["tuottavuusConnectionString"].ConnectionString;

            return connectionString;
        }


        protected bool Conectar()
        {
            sqlConnection = new SqlConnection(StrConnectionSQLServer());
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected bool Desconectar()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Close();
                    sqlConnection.Dispose();
                    return true;
                }
                else
                {
                    sqlConnection.Dispose();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
