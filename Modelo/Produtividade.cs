using System;

namespace Modelo
{
    public class Produtividade
    {
        public int Id { get; set; }
        public int DiasUteis { get; set; }
        public int DomingosFeriados { get; set; }
        public double Media { get; set; }
        public double Produtividade_Valor { get; set; }
        public double Produtividade_Reflexo { get; set; }
        public DateTime Data_Calculo { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }

    }
}
