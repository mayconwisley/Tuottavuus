using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class MetaPesoControle
    {
        CRUD crud;
        string SQL;
        public MetaPesoControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }
        public bool Gravar(MetaPeso metaPeso)
        {
            crud = new CRUD();
            SQL = "INSERT INTO MetaPeso(Meta, Peso, Id_Indicador) " +
                  "VALUES(@Meta, @Peso, @Id_Indicador)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Meta", metaPeso.Meta);
                crud.AdicionarParametros("Peso", metaPeso.Peso);
                crud.AdicionarParametros("Id_Indicador", metaPeso.Indicador.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(MetaPeso metaPeso)
        {
            crud = new CRUD();
            SQL = "UPDATE MetaPeso SET Meta = @Meta, Peso = @Peso " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Meta", metaPeso.Meta);
                crud.AdicionarParametros("Peso", metaPeso.Peso);
                crud.AdicionarParametros("Id", metaPeso.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(MetaPeso metaPeso)
        {
            crud = new CRUD();
            SQL = "DELETE FROM MetaPeso " +
                  "WHERE Id = @Id";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", metaPeso.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int IdPorMeta(double porcMeta, int idIndicado)
        {

            crud = new CRUD();
            SQL = "SELECT TOP 1 Id " +
                  "FROM MetaPeso " +
                  "WHERE @Meta >= Meta " +
                  "AND Id_Indicador = @Id_Indicador " +
                  "ORDER BY Meta DESC";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Meta", porcMeta);
                crud.AdicionarParametros("Id_Indicador", idIndicado);
                var idMeta = crud.Executar(CommandType.Text, SQL);

                if (idMeta is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(idMeta.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal Meta(int idMeta)
        {
            crud = new CRUD();
            SQL = "SELECT Meta " +
                  "FROM MetaPeso " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", idMeta);
                var valorMeta = crud.Executar(CommandType.Text, SQL);

                if (valorMeta is null)
                {
                    return 0;
                }
                else
                {
                    return decimal.Parse(valorMeta.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal Peso(int idMeta)
        {
            crud = new CRUD();
            SQL = "SELECT Peso " +
                  "FROM MetaPeso " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", idMeta);
                var valorPeso = crud.Executar(CommandType.Text, SQL);

                if (valorPeso is null)
                {
                    return 0;
                }
                else
                {
                    return decimal.Parse(valorPeso.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable MetaPesoTabela(int idIndicador)
        {
            crud = new CRUD();
            SQL = "SELECT MP.Id, MP.Meta, MP.Peso, MP.Id_Indicador, Ind.Descricao " +
                "FROM MetaPeso MP " +
                "INNER JOIN Indicador Ind ON MP.Id_Indicador = Ind.Id " +
                "WHERE MP.Id_Indicador = @Id_Indicador " +
                "ORDER BY Ind.Descricao ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Indicador", idIndicador);
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
