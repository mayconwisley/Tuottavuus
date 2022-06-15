using Banco_De_Dados;
using Modelo;
using System;
using System.Data;

namespace Controle
{
    public class AtividadeAvaliacaoControle
    {
        CRUD crud;
        string SQL;

        public AtividadeAvaliacaoControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }

        public bool Gravar(AtividadeAvaliacao atividadeAvaliacao)
        {
            crud = new CRUD();
            SQL = "INSERT INTO AtividadeAvaliacao (Nota, Id_Competencia, Id_Empresa, Id_Empregado, Id_Atividade) " +
                  "VALUES (@Nota, @Id_Competencia, @Id_Empresa, @Id_Empregado, @Id_Atividade)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nota", atividadeAvaliacao.Nota);
                crud.AdicionarParametros("Id_Competencia", atividadeAvaliacao.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", atividadeAvaliacao.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", atividadeAvaliacao.Empregado.Id);
                crud.AdicionarParametros("Id_Atividade", atividadeAvaliacao.Atividade.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(AtividadeAvaliacao atividadeAvaliacao)
        {
            crud = new CRUD();
            SQL = "UPDATE AtividadeAvaliacao SET Nota = @Nota, Id_Competencia = @Id_Competencia, Id_Empresa = @Id_Empresa, Id_Empregado = @Id_Empregado, Id_Atividade = @Id_Atividade " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nota", atividadeAvaliacao.Nota);
                crud.AdicionarParametros("Id_Competencia", atividadeAvaliacao.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", atividadeAvaliacao.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", atividadeAvaliacao.Empregado.Id);
                crud.AdicionarParametros("Id_Atividade", atividadeAvaliacao.Atividade.Id);
                crud.AdicionarParametros("Id", atividadeAvaliacao.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool AlterarAtividadeEmpregado(AtividadeAvaliacao atividadeAvaliacao)
        {
            crud = new CRUD();
            SQL = "UPDATE AtividadeAvaliacao SET Id_Empresa = @Id_Empresa " +
                  "WHERE Id_Empregado = @Id_Empregado";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Empresa", atividadeAvaliacao.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", atividadeAvaliacao.Empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(AtividadeAvaliacao atividadeAvaliacao)
        {
            crud = new CRUD();
            SQL = "DELETE FROM AtividadeAvaliacao " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", atividadeAvaliacao.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int TotalAvaliacaoEmpregado(int empresaId, int empregadoId, int competenciaId)
        {
            int totalAvaliacaoEmpregado = 0;
            crud = new CRUD();
            SQL = "SELECT COUNT(AtividadeAvaliacao.Id) AS Quantidade " +
                  "FROM ((((AtividadeAvaliacao " +
                  "INNER JOIN Competencia ON AtividadeAvaliacao.Id_Competencia = Competencia.Id) " +
                  "INNER JOIN Empresa ON AtividadeAvaliacao.Id_Empresa = Empresa.Id) " +
                  "INNER JOIN Empregado ON AtividadeAvaliacao.Id_Empregado = Empregado.Id) " +
                  "INNER JOIN Atividade ON AtividadeAvaliacao.Id_Atividade = Atividade.Id) " +
                  "WHERE Empresa.Id = @EmpresaId AND Empregado.Id = @EmpregadoId AND Competencia.Id = @CompetenciaId";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("EmpresaId", empresaId);
                crud.AdicionarParametros("EmpregadoId", empregadoId);
                crud.AdicionarParametros("CompetenciaId", competenciaId);
                totalAvaliacaoEmpregado = int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
                return totalAvaliacaoEmpregado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public double Media(int empresaId, int empregadoId, int competenciaId)
        {
            double dcNota = 0;
            int numLinhas = 0;
            crud = new CRUD();
            SQL = "SELECT AtividadeAvaliacao.Nota AS Nota " +
                  "FROM ((((AtividadeAvaliacao " +
                  "INNER JOIN Competencia ON AtividadeAvaliacao.Id_Competencia = Competencia.Id) " +
                  "INNER JOIN Empresa ON AtividadeAvaliacao.Id_Empresa = Empresa.Id) " +
                  "INNER JOIN Empregado ON AtividadeAvaliacao.Id_Empregado = Empregado.Id) " +
                  "INNER JOIN Atividade ON AtividadeAvaliacao.Id_Atividade = Atividade.Id) " +
                  "WHERE Empresa.Id = @EmpresaId AND Empregado.Id = @EmpregadoId AND Competencia.Id = @CompetenciaId";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("EmpresaId", empresaId);
                crud.AdicionarParametros("EmpregadoId", empregadoId);
                crud.AdicionarParametros("CompetenciaId", competenciaId);

                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                numLinhas = dataTable.Rows.Count;

                if (numLinhas != 0)
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        dcNota = dcNota + double.Parse(item["Nota"].ToString());
                    }
                    dcNota = dcNota / numLinhas;
                }
                else
                {

                }
                return dcNota;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public DataTable AtividadeAvaliacaoTabela(int empresaId, int empregadoId, int competenciaId)
        {
            crud = new CRUD();
            SQL = "SELECT AtividadeAvaliacao.Id AS Id, AtividadeAvaliacao.Nota, Competencia.Competencia AS DataCompetencia, Empresa.Nome AS NomeEmpresa, Empregado.Id As IdEmpregado, Empregado.Nome AS NomeEmpregado, Atividade.Descricao AS AtividadeDescricao " +
                    "FROM ((((AtividadeAvaliacao " +
                    "INNER JOIN Competencia ON AtividadeAvaliacao.Id_Competencia = Competencia.Id) " +
                    "INNER JOIN Empresa ON AtividadeAvaliacao.Id_Empresa = Empresa.Id) " +
                    "INNER JOIN Empregado ON AtividadeAvaliacao.Id_Empregado = Empregado.Id) " +
                    "INNER JOIN Atividade ON AtividadeAvaliacao.Id_Atividade = Atividade.Id) " +
                    "WHERE Empresa.Id = @EmpresaId AND Empregado.Id = @EmpregadoId AND Competencia.Id = @CompetenciaId " +
                    "ORDER BY Atividade.Descricao ASC ";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("EmpresaId", empresaId);
                crud.AdicionarParametros("EmpregadoId", empregadoId);
                crud.AdicionarParametros("CompetenciaId", competenciaId);
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
