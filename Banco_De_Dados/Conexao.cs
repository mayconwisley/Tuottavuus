using System;
using System.Data.OleDb;
namespace Banco_De_Dados
{
    public class Conexao
    {

        protected OleDbConnection dbConnection = new OleDbConnection();
 
        protected bool Conectar()
        {
            string conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Banco de Dados\tuottavuus.mdb";
            dbConnection = new OleDbConnection(conexao);
            try
            {
                dbConnection.Open();
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
                if (dbConnection.State == System.Data.ConnectionState.Closed)
                {
                    dbConnection.Close();
                    dbConnection.Dispose();
                    return true;
                }
                else
                {
                    dbConnection.Dispose();
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
