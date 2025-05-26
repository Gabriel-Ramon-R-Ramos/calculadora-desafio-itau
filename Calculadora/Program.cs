using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new();
            Stack<double> pilhaResultados = new();
            Queue<Operacoes> filaOperacoes = new();

            filaOperacoes.Enqueue(new Operacoes { ValorA = 2, ValorB = 3, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 14, ValorB = 8, Operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 5, ValorB = 6, Operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 2147483647, ValorB = 2, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 18, ValorB = 3, Operador = '/' });

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.ValorA, operacao.Operador, operacao.ValorB, operacao.Resultado);
                pilhaResultados.Push(operacao.Resultado);

                Console.WriteLine("--------------");
                Console.WriteLine("Lista de operações a serem processadas:");
                int i = 5;
                foreach (var item in filaOperacoes)
                {
                    Console.WriteLine("item {0}: {1} {2} {3}", i, item.ValorA, item.Operador, item.ValorB);
                    i--;
                }
                Console.WriteLine("--------------\n");
            }

            Console.WriteLine("Resultados totais obtidos: " + pilhaResultados.Count);
            Console.WriteLine("--------------");
            Console.WriteLine("Resultados:");
            while (pilhaResultados.Count > 0)
            {
                double resultado = pilhaResultados.Pop();
                Console.WriteLine(resultado);
            }
        }
    }
}
