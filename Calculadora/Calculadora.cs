using System;
namespace Calculadora
{
    public static class Calculadora
    {
        public static Operacoes Calcular(Operacoes operacao)
        {
            operacao.Resultado = operacao.Operador switch
            {
                '+' => Soma(operacao),
                '-' => Subtracao(operacao),
                '*' => Multiplicacao(operacao),
                '/' => Divisao(operacao),
                _ => 0,
            };
            return operacao;
        }
        public static long Soma(Operacoes operacao)
        {
            return operacao.ValorA + operacao.ValorB;
        }
        public static long Subtracao(Operacoes operacao)
        {
            return operacao.ValorA - operacao.ValorB;
        }
        public static long Multiplicacao(Operacoes operacao)
        {
            return operacao.ValorA * operacao.ValorB;
        }
        public static double Divisao(Operacoes operacao)
        {
            if (operacao.ValorB == 0)
            {
                    throw new DivideByZeroException("Tentativa de dividir por zero. Não é possível fazer uma divisão por Zero.");
            }
            return (double)operacao.ValorA / operacao.ValorB;
        }
    }
}
