using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Afastamento
    {
        public int Id { get; set; }
        public int TotalDias { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }

    }
}
