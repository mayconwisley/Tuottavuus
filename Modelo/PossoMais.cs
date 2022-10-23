using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PossoMais
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }
        public MetaPeso MetaPeso { get; set; }

    }
}
