using System;

namespace Modelo
{
    public class Pesquisa
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public int CodigoAtendente { get; set; }
        public string NomeAtendente { get; set; }
        public int NotaConceito { get; set; }
        public int Chamado { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }

    }
}
