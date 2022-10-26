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
    public class AssiduidadeControle
    {
        CRUD crud;
        string SQL;

        public AssiduidadeControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }

        public bool Gravar(Assiduidade assiduidade)
        {
            crud = new CRUD();
            SQL = "INSERT INTO Assiduidade (Id_Competencia, Id_Empresa, Id_Empregado, AtrasoFalta) " +
                  "VALUES (@Id_Competencia, @Id_Empresa, @Id_Empregado, @AtrasoFalta)";

            try
            {
                crud.LimparParametros();
                crud.AdicionarParametros("Id_Competencia", assiduidade.Competencia.Id);
                crud.AdicionarParametros("Id_Empresa", assiduidade.Empresa.Id);
                crud.AdicionarParametros("Id_Empregado", assiduidade.Empregado.Id);
                crud.AdicionarParametros("AtrasoFalta", assiduidade.AtrasoFalta);

                crud.Executar(CommandType.Text, SQL);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
