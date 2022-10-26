namespace Modelo
{
    public class Assiduidade
    {
        public int Id { get; set; }
        public int AtrasoFalta { get; set; }
        public Competencia Competencia { get; set; }
        public Empresa Empresa { get; set; }
        public Empregado Empregado { get; set; }

    }
}
