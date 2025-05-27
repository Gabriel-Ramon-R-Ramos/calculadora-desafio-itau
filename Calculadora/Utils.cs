using System;
using System.Collections.Generic;

namespace Calculadora
{
    public static class Utils
    {
        public static void LerFilaOperacoes(Queue<Operacoes> filaOperacoes)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Lista de operações a serem processadas:");
            int i = filaOperacoes.Count;
            foreach (var item in filaOperacoes)
            {
                if (i != 1)
                {
                    Console.Write("item {0}: {1} {2} {3} | ", i, item.ValorA, item.Operador, item.ValorB);
                }
                else
                {
                    Console.Write("item {0}: {1} {2} {3}\n", i, item.ValorA, item.Operador, item.ValorB);
                }
                i--;
            }
            Console.WriteLine("--------------\n");
        }

        public static void LerPilhaResultados(Stack<double> pilhaResultados)
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
