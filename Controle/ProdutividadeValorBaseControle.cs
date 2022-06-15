using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class ProdutividadeValorBaseControle
    {
        CRUD crud;
        string SQL;
        public ProdutividadeValorBaseControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }

        public bool Gravar(ProdutividadeValorBase produtividadeValorBases)
        {
            crud = new CRUD();
            SQL = "INSERT INTO ProdutividadeBase (Data_Cadastro, Valor) " +
            "VALUES (@Data_Cadastro, @Valor)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Data_Cadastro", produtividadeValorBases.DataCadastro.Date);
                crud.AdicionarParametros("Valor", produtividadeValorBases.Valor);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(ProdutividadeValorBase produtividadeValorBases)
        {
            crud = new CRUD();
            SQL = "UPDATE ProdutividadeBase SET Data_Cadastro = @Data_Cadastro, Valor = @Valor " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Data_Cadastro", produtividadeValorBases.DataCadastro.Date);
                crud.AdicionarParametros("Valor", produtividadeValorBases.Valor);
                crud.AdicionarParametros("Id", produtividadeValorBases.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(ProdutividadeValorBase produtividadeValorBases)
        {
            crud = new CRUD();
            SQL = "DELETE FROM ProdutividadeBase " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", produtividadeValorBases.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public double Valor()
        {
            crud = new CRUD();
            SQL = "SELECT TOP 1 Valor FROM ProdutividadeBase " +
            "ORDER BY Data_Cadastro DESC";
            try
            {
                return double.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
        }
        public double Valor_Data(DateTime data_Competencia)
        {
            crud = new CRUD();
            SQL = "SELECT TOP 1 Valor FROM ProdutividadeBase " +
                  "WHERE  (Month(Data_Cadastro) <= Month(@Data_Cadastro)) AND " +
                  "(Year(Data_Cadastro) <= Year(@Data_Cadastro)) " +
                  "ORDER BY Data_Cadastro DESC";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Data_Cadastro", data_Competencia);

                return double.Parse((crud.Executar(CommandType.Text, SQL) != null) ?
                                     crud.Executar(CommandType.Text, SQL).ToString() :
                                     throw new Exception("Valor da Produtividade não cadastrado para a competência."));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ProdutividadeValorBasesTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Data_Cadastro, Valor " +
            "FROM ProdutividadeBase " +
            "ORDER BY Data_Cadastro DESC ";
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
