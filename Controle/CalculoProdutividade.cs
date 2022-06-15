using System;

namespace Controle
{
    public class CalculoProdutividade
    {
        double valor, domingoFeriados;

        public CalculoProdutividade()
        {
            valor = 0.0;
            domingoFeriados = 0.0;
        }
        //Calcula o valor do pagamento referente a nota lançada
        public double Valor(double vlrBase, double vlrMedia)
        {
            try
            {
                valor = vlrBase * (vlrMedia / 100);
                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Calcula o reflexo sobre o valor na competencia
        public double Reflexo(double vlrValor, int numDiasUteis, int numDomingosFeriados)
        {
            try
            {
                domingoFeriados = (vlrValor / numDiasUteis) * numDomingosFeriados;
                return domingoFeriados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
