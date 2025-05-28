using System;
namespace Calculadora
{
    public static class Calculadora
    {
        public static Operacoes Calcular(Operacoes operacao)
        {
            try
            {
                operacao.Resultado = operacao.Operador switch
                {
                    '+' => Soma(operacao),
                    '-' => Subtracao(operacao),
                    '*' => Multiplicacao(operacao),
                    '/' => Divisao(operacao),
                    _ => throw new InvalidOperationException("Operador inválido."),
                };
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: tentativa de dividir por zero.");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: overflow aritmético. Valores ultrapassam os limites de long.");
                throw;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                throw;
            }
            return operacao;
        }
        public static long Soma(Operacoes operacao) => checked(operacao.ValorA + operacao.ValorB);
        public static long Subtracao(Operacoes operacao) => checked(operacao.ValorA - operacao.ValorB);
        public static long Multiplicacao(Operacoes operacao) => checked(operacao.ValorA * operacao.ValorB);
        public static double Divisao(Operacoes operacao)
        {
            if (operacao.ValorB == 0)
            {
                    throw new DivideByZeroException("Erro: Tentativa de dividir por zero.");
            }
            return (double)operacao.ValorA / operacao.ValorB;
        }
    }
}
