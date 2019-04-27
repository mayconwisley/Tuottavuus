namespace Modelo
{
    public class AtividadeAvaliacao
    {
        public int Id { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }
        public Atividade Atividade { get; set; }
        public double Nota { get; set; }
    }
}
