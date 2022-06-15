using Banco_De_Dados;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class MetaPesoControle
    {
        CRUD crud;
        string SQL;

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
        public DataTable MetaPesoTabela()
        {
            crud = new CRUD();
            SQL = "SELECT MP.Id, MP.Meta, MP.Peso, MP.Id_Indicador, Ind.Descricao " +
                "FROM MetaPeso MP " +
                "INNER JOIN Indicador Ind ON MP.Id_Indicador = Ind.Id "+
                "ORDER BY Ind.Descricao ";
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
