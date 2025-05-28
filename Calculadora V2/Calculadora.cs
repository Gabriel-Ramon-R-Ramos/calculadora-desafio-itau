using System;
namespace Calculadora_V2
{
    public class Calculadora
    {

        public Operacoes calcular(Operacoes operacao)
        {
            try
            {
                switch (operacao.operador)
                {
                    case '+': operacao.resultado = soma(operacao); break;
                    case '-': operacao.resultado = subtracao(operacao); break;
                    case '*': operacao.resultado = multiplicacao(operacao); break;
                    case '/': operacao.resultado = divisao(operacao); break;
                    default: operacao.resultado = 0; break;
                }
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Erro: tentativa de dividir por zero.");
                throw;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Erro: overflow aritmético. Valores ultrapassam os limites de int.");
                throw;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                throw;
            }

            return operacao;
        }
        public int soma(Operacoes operacao)
        {
            return checked(operacao.valorA + operacao.valorB);
        }
        public int subtracao(Operacoes operacao)
        {
            return checked(operacao.valorA - operacao.valorB);
        }
        public int multiplicacao(Operacoes operacao)
        {
            return checked(operacao.valorA * operacao.valorB);
        }
        public decimal divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0)
            {
                throw new DivideByZeroException("Erro: Tentativa de dividir por zero.");
            }
            return checked(operacao.valorA / operacao.valorB);
        }

    }
}
