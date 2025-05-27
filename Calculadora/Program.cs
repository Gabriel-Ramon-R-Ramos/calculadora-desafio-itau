using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> pilhaResultados = new();
            Queue<Operacoes> filaOperacoes = new();

            filaOperacoes.Enqueue(new Operacoes { ValorA = 2, ValorB = 3, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 14, ValorB = 8, Operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 5, ValorB = 6, Operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 2147483647, ValorB = 2, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 18, ValorB = 0, Operador = '/' });

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                Calculadora.Calcular(operacao);

                Console.WriteLine("Operação atual:");
                Console.WriteLine("{0} {1} {2} = {3}", operacao.ValorA, operacao.Operador, operacao.ValorB, operacao.Resultado);
                
                pilhaResultados.Push(operacao.Resultado);
                LerFilaOperacoes(filaOperacoes);
            }

            LerPilhaResultados(pilhaResultados);
        }
        private static void LerFilaOperacoes(Queue<Operacoes> filaOperacoes)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Lista de operações a serem processadas:");
            int i = filaOperacoes.Count;
            foreach (var item in filaOperacoes)
            {
                if (i != 1)
                {
                Console.Write("item {0}: {1} {2} {3} | ", i, item.ValorA, item.Operador, item.ValorB);
                } else
                {
                Console.Write("item {0}: {1} {2} {3}\n", i, item.ValorA, item.Operador, item.ValorB);  
                }
                i--;
            }
            Console.WriteLine("--------------\n");
        }

        private static void LerPilhaResultados(Stack<double> pilhaResultados)
        {
            Console.WriteLine("Resultados totais obtidos: " + pilhaResultados.Count);
            Console.WriteLine("--------------");
            Console.WriteLine("Resultados:");
            while (pilhaResultados.Count > 0)
            {
                double resultado = pilhaResultados.Pop();
                Console.Write(resultado + " | ");
            }
            Console.WriteLine("");
        }
    }
}
