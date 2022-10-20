using System;

namespace Modelo
{
    public class Chamado
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public int CodigoChamado { get; set; }
        public int CodigoGrupoSolucao { get; set; }
        public string DescGrupoSolucao { get; set; }
        public int CodigoArea { get; set; }
        public string DescArea { get; set; }
        public int CodigoAtendente { get; set; }
        public string NomeAtendente { get; set; }
        public int CodigoNatureza { get; set; }
        public string DescNatureza { get; set; }
        public int CodigoTpAtividade { get; set; }
        public string DescTpAtividade { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }
    }
}
