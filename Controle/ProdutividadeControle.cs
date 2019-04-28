using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class ProdutividadeControle
    {
        CRUD crud;
        string SQL;

        public bool Gravar(Produtividade produtividade)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Produtividade (Id_Competencia, Id_Empresa, Id_Empregado, Dias_Apurados, Fer_Dom_Apurados, Media_Avaliacao, Produtividade_Valor, Produtividade_Reflexo, Data_Calculo) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @Dias_Apurados, @Fer_Dom_Apurados, @Media_Avaliacao, @Produtividade_Valor, @Produtividade_Reflexo, @Data_Calculo)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", produtividade.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", produtividade.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", produtividade.Empregado.Id);
                crud.AdicionarParametros("Dias_Apurados", produtividade.DiasUteis);
                crud.AdicionarParametros("Fer_Dom_Apurados", produtividade.DomingosFeriados);
                crud.AdicionarParametros("Media_Avaliacao", produtividade.Media);
                crud.AdicionarParametros("Produtividade_Valor", produtividade.Produtividade_Valor);
                crud.AdicionarParametros("Produtividade_Reflexo", produtividade.Produtividade_Reflexo);
                crud.AdicionarParametros("Data_Calculo", produtividade.Data_Calculo);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool AlterarEmpresaProdutividade(Produtividade produtividade)
        {
            crud = new CRUD();
            SQL = "UPDATE Produtividade SET  Id_Empresa = @Id_Empresa " +
                  "WHERE Id_Empregado = @Id_Empregado ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Empresa", produtividade.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", produtividade.Empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(Produtividade produtividade)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Produtividade " +
                  "WHERE Id_Competencia = @Id_Competencia AND Id_Empresa = @Id_Empresa";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", produtividade.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", produtividade.Empresa.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ExcluirIndividual(int produtividadeId)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Produtividade " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", produtividadeId);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ProdutividadeTabela(int competenciaId, int empresaId)
        {
            crud = new CRUD();
            SQL = "SELECT Produtividade.Id_Empregado AS Id_Empregado, Empregado.Nome AS Nome, Produtividade.Id, Produtividade.Media_Avaliacao, Produtividade.Produtividade_Valor, Produtividade.Produtividade_Reflexo, SUM(Produtividade.Produtividade_Valor + Produtividade.Produtividade_Reflexo) As Total_Geral, Produtividade.Dias_Apurados, Produtividade.Fer_Dom_Apurados " +
                  "FROM (Produtividade " +
                  "INNER JOIN Empregado ON Produtividade.Id_Empregado = Empregado.ID) " +
                  "WHERE Produtividade.Id_Competencia = @Id_Competencia AND Produtividade.Id_Empresa = @Id_Empresa " +
                  "GROUP BY Produtividade.Id, Produtividade.Produtividade_Valor, Produtividade.Produtividade_Reflexo, Produtividade.Media_Avaliacao, Produtividade.Dias_Apurados, Produtividade.Fer_Dom_Apurados, Produtividade.Id_Empregado, Nome " +
                  "ORDER BY Empregado.Nome ASC";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", competenciaId);
                crud.AdicionarParametros("Id_Empresa", empresaId);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DateTime Calculo_Data(int competenciaId, int empresaId)
        {
            crud = new CRUD();

            SQL = "SELECT TOP 1 Produtividade.Data_Calculo " +
                  "FROM (Produtividade " +
                  "INNER JOIN Empregado ON Produtividade.Id_Empregado = Empregado.ID) " +
                  "WHERE Produtividade.Id_Competencia = @Id_Competencia AND Produtividade.Id_Empresa = @Id_Empresa " +
                  "GROUP BY Produtividade.Data_Calculo " +
                  "ORDER BY Produtividade.Data_Calculo DESC";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", competenciaId);
                crud.AdicionarParametros("Id_Empresa", empresaId);
                DateTime dtDataCalculo = DateTime.Parse(crud.Executar(CommandType.Text, SQL).ToString());
                return dtDataCalculo;
            }
            catch
            {
                return DateTime.Now.Date;
            }
        }
        //retorna numeros de calculos
        public int NumCalculados(int competenciaId, int empresaId)
        {
            crud = new CRUD();
            SQL = "SELECT COUNT(Produtividade.Id) As Contador_Id " +
                  "FROM Produtividade " +
                  "WHERE Produtividade.Id_Competencia = @Id_Competencia AND Produtividade.Id_Empresa = @Id_Empresa ";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", competenciaId);
                crud.AdicionarParametros("Id_Empresa", empresaId);

                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch
            {
                return 0;
            }
        }

    }
}
