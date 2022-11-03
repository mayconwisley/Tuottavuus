using Banco_De_Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class ConfigAfastamentoControle
    {
        CRUD crud;
        string SQL;

        public ConfigAfastamentoControle()
        {
            crud = new CRUD();
            SQL = string.Empty;
        }
    }
}
