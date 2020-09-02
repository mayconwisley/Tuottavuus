using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class CompetenciaControle
    {
        CRUD crud;
        string SQL;

        public bool Gravar(Competencia competencia)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Competencia (Competencia, Ativo) " +
                "VALUES (@Competencia, @Ativo)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Competencia", competencia.Data);
                crud.AdicionarParametros("Ativo", competencia.Ativo);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Competencia competencia)
        {
            crud = new CRUD();
            SQL = "UPDATE Competencia SET Competencia = @Competencia, Ativo = @Ativo " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Competencia", competencia.Data);
                crud.AdicionarParametros("Ativo", competencia.Ativo);
                crud.AdicionarParametros("Id", competencia.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Competencia competencia)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Competencia " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", competencia.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool FecharCompetencia(Competencia competencia)
        {

            crud = new CRUD();
            SQL = "UPDATE Competencia SET Ativo = No " +
                "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", competencia.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(DateTime dtCompetencia)
        {
            //Selecio o id da competencia ativa
            crud = new CRUD();
            SQL = "SELECT Id FROM Competencia " +
                "WHERE Competencia = @Competencia ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Competencia", dtCompetencia);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch
            {
                return 0;
            }
        }
        public int DiasUteis(DateTime dtPrimeiroDia, DateTime dtUltimoDia, int numFeriados)
        {
            //Conta os dias ulteis na competencia ativa
            int diasUteis = 0, qtDiasMes = 0;

            try
            {
                DateTime data = dtPrimeiroDia;
                qtDiasMes = int.Parse(dtUltimoDia.ToString("dd"));
                while (qtDiasMes > 0)
                {
                    if (data.DayOfWeek != DayOfWeek.Sunday)
                    {
                        diasUteis++;
                    }
                    data = data.AddDays(1);
                    qtDiasMes--;
                }
                diasUteis = diasUteis - numFeriados;
                return diasUteis;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Domingos(DateTime dtPrimeiroDia, DateTime dtUltimoDia)
        {
            //Conta os domingos da competencia ativa
            int domingos = 0, qtDiasMes = 0;

            try
            {
                DateTime data = dtPrimeiroDia;
                qtDiasMes = int.Parse(dtUltimoDia.ToString("dd"));
                while (qtDiasMes > 0)
                {
                    if (data.DayOfWeek == DayOfWeek.Sunday)
                    {
                        domingos++;
                    }
                    data = data.AddDays(1);
                    qtDiasMes--;
                }
                return domingos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DateTime CompetenciaAtiva()
        {
            crud = new CRUD();
            SQL = "SELECT Competencia FROM Competencia " +
                  "WHERE Ativo = Yes ";
            try
            {
                DateTime dateTime;

                return dateTime = (crud.Executar(CommandType.Text, SQL) != null) ?
                     DateTime.Parse(crud.Executar(CommandType.Text, SQL).ToString()) :
                     throw new Exception("Competência não cadastrada.");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DateTime PrimeiroDia(DateTime dtCompetencia)
        {
            //Pega o primeiro dia da competencia ativa
            try
            {
                DateTime primeiroDia = new DateTime(dtCompetencia.Year, dtCompetencia.Month, 1);
                return primeiroDia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DateTime UltimoDia(DateTime dtCompetencia)
        {
            //Pega o ultimo dia da competencia ativa
            try
            {
                DateTime ultimoDia = new DateTime(dtCompetencia.Year, dtCompetencia.Month, 1).AddMonths(1).AddDays(-1);
                return ultimoDia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable CompetenciaTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Id, Competencia, Ativo " +
                  "FROM Competencia " +
                  "ORDER BY Competencia DESC";
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
