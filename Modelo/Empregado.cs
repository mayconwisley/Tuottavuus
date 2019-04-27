using System;

namespace Modelo
{

    public class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public Empresa Empresa { get; set; }
        public Departamento Departamento { get; set; }
    }
}
