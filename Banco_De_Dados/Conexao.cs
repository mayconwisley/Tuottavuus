using System;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Configuration;

namespace Banco_De_Dados
{
    public class Conexao
    {

        //protected OleDbConnection dbConnection = new OleDbConnection();
        protected SqlConnection sqlConnection = new SqlConnection();

        private string StrConnectionSQLServer()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Tuottavuus.Properties.Settings.tuottavuusConnectionString"].ConnectionString;

            return connectionString;
            //return $"Data Source=localhost\\SQLEXPRESS,1433; Initial Catalog = Tuottavuus; User Id = sa; Password = thugstools;";

        }


        protected bool Conectar()
        {
            //string conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Banco de Dados\tuottavuus.mdb";
            //dbConnection = new OleDbConnection(conexao);

            sqlConnection = new SqlConnection(StrConnectionSQLServer());
            try
            {
                //dbConnection.Open();
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
                //if (dbConnection.State == System.Data.ConnectionState.Closed)
                //{
                //    dbConnection.Close();
                //    dbConnection.Dispose();
                //    return true;
                //}
                //else
                //{
                //    dbConnection.Dispose();
                //    return false;
                //}

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
