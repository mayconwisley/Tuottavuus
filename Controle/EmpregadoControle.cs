using Banco_De_Dados;
using Modelo;
using System;
using System.Collections;
using System.Data;

namespace Controle
{
    public class EmpregadoControle
    {
        CRUD crud;
        string SQL;
        Empregado empregado;
        Utilitarios utilitarios;
        int idEmpregado = 0;

        public EmpregadoControle()
        {
            crud = new CRUD();
            SQL = String.Empty;
        }
        public bool Gravar(Empregado empregado)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Empregado (Nome,  Ativo, Id_Empresa, Id_Departamento, Codigo) " +
            "VALUES (@Nome, @Ativo, @Id_Empresa, @Id_Departamento, @Codigo)";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empregado.Nome);
                crud.AdicionarParametros("Ativo", empregado.Ativo);
                crud.AdicionarParametros("Id_Empresa", empregado.Empresa.Id);
                crud.AdicionarParametros("Id_Departamento", empregado.Departamento.Id);
                crud.AdicionarParametros("Codigo", empregado.Codigo);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Alterar(Empregado empregado)
        {
            crud = new CRUD();
            SQL = "UPDATE Empregado SET Nome = @Nome, Ativo = @Ativo, Id_Empresa = @Id_Empresa, Id_Departamento = @Id_Departamento, Codigo = @Codigo " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empregado.Nome);
                crud.AdicionarParametros("Ativo", empregado.Ativo);
                crud.AdicionarParametros("Id_Empresa", empregado.Empresa.Id);
                crud.AdicionarParametros("Id_Departamento", empregado.Departamento.Id);
                crud.AdicionarParametros("Codigo", empregado.Codigo);
                crud.AdicionarParametros("Id", empregado.Id);

                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Excluir(Empregado empregado)
        {
            crud = new CRUD();
            SQL = "DELETE FROM Empregado " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", empregado.Id);
                crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string NomePorId(int id)
        {
            crud = new CRUD();
            SQL = "SELECT Nome FROM Empregado " +
                  "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", id);

                var nome = crud.Executar(CommandType.Text, SQL);

                if (nome is null)
                {
                    return string.Empty;
                }
                else
                {
                    return nome.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Id(string empregadoNome)
        {
            crud = new CRUD();
            SQL = "SELECT Id FROM Empregado " +
            "WHERE Nome = @Nome";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Nome", empregadoNome);
                return int.Parse(crud.Executar(CommandType.Text, SQL).ToString());
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
        }
        public int IdPorCodigo(int codigo)
        {
            crud = new CRUD();
            SQL = "SELECT Id FROM Empregado " +
            "WHERE Codigo = @Codigo";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Codigo", codigo);

                var idEmpregado = crud.Executar(CommandType.Text, SQL);


                if (idEmpregado is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(idEmpregado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int CodigoPorId(int id)
        {
            crud = new CRUD();
            SQL = "SELECT Codigo FROM Empregado " +
            "WHERE Id = @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id", id);

                var idEmpregado = crud.Executar(CommandType.Text, SQL);

                if (idEmpregado is null)
                {
                    return 0;
                }
                else
                {
                    return int.Parse(idEmpregado.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool IsCodigo(int codigo, int idEmpregado)
        {

            crud = new CRUD();
            SQL = "SELECT COUNT(Codigo) FROM Empregado " +
                  "WHERE Codigo = @Codigo AND Id <> @Id";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Codigo", codigo);
                crud.AdicionarParametros("Id", idEmpregado);
                int countCodigo = int.Parse(crud.Executar(CommandType.Text, SQL).ToString());

                if (countCodigo == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);


            }
        }
        public DataTable EmpregadoComboBox(int empresaId)
        {
            crud = new CRUD();
            SQL = "SELECT Empregado.Id, Empregado.Id & ' - ' & Empregado.Nome AS Nome " +
                    "FROM (Empregado " +
                    "INNER JOIN Empresa ON Empregado.Id_Empresa = Empresa.Id) " +
                    "WHERE Empregado.Ativo = Yes AND Empresa.Id = @EmpresaId " +
                    "ORDER BY Empregado.Nome ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("EmpresaId", empresaId);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable EmpregadoTabela()
        {
            crud = new CRUD();
            SQL = "SELECT Empregado.Id, Empregado.Nome, Empregado.Codigo, Empregado.Ativo, Empresa.Id & ' - ' & Empresa.Nome AS EmpresaNome, Departamento.Descricao AS DepartamentoDescricao " +
                    "FROM ((Empregado " +
                    "INNER JOIN Empresa ON Empregado.Id_Empresa = Empresa.Id) " +
                    "INNER JOIN Departamento ON Empregado.Id_Departamento = Departamento.Id) " +
                    "ORDER BY Empregado.Nome ";
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
        public DataTable EmpregadoTabelaCalculo(int empresaId)
        {
            crud = new CRUD();
            SQL = "SELECT Empregado.Id " +
                    "FROM ((Empregado " +
                    "INNER JOIN Empresa ON Empregado.Id_Empresa = Empresa.Id) " +
                    "INNER JOIN Departamento ON Empregado.Id_Departamento = Departamento.Id) " +
                    "WHERE Empregado.Ativo = Yes AND Empregado.Id_Empresa = @Id_Empresa " +
                    "ORDER BY Empregado.Nome ";
            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Empresa", empresaId);
                DataTable dataTable = crud.ConsultaTabela(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ImportarEmpregado(int idEmpresa, int idDepartamento, string caminhoArquivo, out int qtdAtualizados, out int qtdGravados)
        {
            empregado = new Empregado();
            utilitarios = new Utilitarios();

            ArrayList arquivo = utilitarios.LerArquivo(caminhoArquivo);
            ArrayList linhaArquivo = new ArrayList();
            qtdAtualizados = 0;
            qtdGravados = 0;
            try
            {
                for (int i = 1; i < arquivo.Count; i++)
                {
                    linhaArquivo.Clear();
                    foreach (var item in arquivo[i].ToString().Split(';'))
                    {
                        linhaArquivo.Add(item);
                    }

                    int codigoEmpregado = int.Parse(linhaArquivo[1].ToString());

                    idEmpregado = IdPorCodigo(codigoEmpregado);
                    empregado.Id = idEmpregado;
                    empregado.Empresa = new Empresa();
                    empregado.Empresa.Id = idEmpresa;
                    empregado.Departamento = new Departamento();
                    empregado.Departamento.Id = idDepartamento;
                    empregado.Nome = linhaArquivo[0].ToString().Trim().Replace("\"", "").ToUpper();
                    empregado.Codigo = linhaArquivo[1].ToString().Trim();
                    empregado.Ativo = true;

                    if (idEmpregado != 0)
                    {
                        Alterar(empregado);
                        qtdAtualizados++;
                    }
                    else
                    {
                        Gravar(empregado);
                        qtdGravados++;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
