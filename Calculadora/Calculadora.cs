using System;
namespace Calculadora
{
    public class Calculadora
    {

        public Operacoes calcular(Operacoes operacao)
        {
            switch (operacao.Operador)
            {
                case '+':
                    operacao.Resultado = Soma(operacao);
                    break;
                case '-':
                    operacao.Resultado = Subtracao(operacao);
                    break;
                case '*':
                    operacao.Resultado = Multiplicacao(operacao);
                    break;
                case '/':
                    operacao.Resultado = Divisao(operacao);
                    break;
                default:
                    operacao.Resultado = 0;
                    break;
            }
            return operacao;
        }
        public long Soma(Operacoes operacao)
        {
            return operacao.ValorA + operacao.ValorB;
        }
        public long Subtracao(Operacoes operacao)
        {
            return operacao.ValorA - operacao.ValorB;
        }
        public long Multiplicacao(Operacoes operacao)
        {
            return operacao.ValorA * operacao.ValorB;
        }
        public double Divisao(Operacoes operacao)
        {
            try
            {
                return operacao.ValorA / operacao.ValorB;
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Não é possível fazer uma divisão por Zero");
                throw;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Houve um erro inesperado, por favor verifique sua conta");
                throw;
            }
        }
    }
}
