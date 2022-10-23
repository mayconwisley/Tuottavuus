using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LayoutImportacao
    {
        public string Pesquisa { get; private set; }
        public string Chamado { get; private set; }
        public string Empregado { get; private set; }

        public LayoutImportacao()
        {
            LayoutChamado();
            LayoutEmpregado();
            LayoutPesquisa();
        }

        private void LayoutPesquisa()
        {
            this.Pesquisa = "Data do fechamento;Código do atendente;Nome;Nota do conceito;Código do chamado";
        }

        private void LayoutChamado()
        {
            this.Chamado = "Data da atividade;Código do chamado;Código do grupo de solução;Descrição do grupo de solução;Código do atendente;Nome;Código da natureza;Descrição da natureza;Código do tipo da atividade;Descrição do tipo da atividade";
        }

        private void LayoutEmpregado()
        {
            this.Empregado = "Nome;Código";
        }
    }
}
