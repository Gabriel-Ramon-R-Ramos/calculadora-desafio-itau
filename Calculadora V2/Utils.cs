using System;
using System.Collections.Generic;

namespace Calculadora_V2
{
    public static class Utils
    {
        public static void LerFilaOperacoes(Queue<Operacoes> filaOperacoes)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Processos pendentes:");
            int i = filaOperacoes.Count;
            foreach (var item in filaOperacoes)
            {
                if (i != 1)
                {
                    Console.Write("item {0}: {1} {2} {3} | ", i, item.valorA, item.operador, item.valorB);
                }
                else
                {
                    Console.Write("item {0}: {1} {2} {3}\n", i, item.valorA, item.operador, item.valorB);
                }
                i--;
            }
            Console.WriteLine("--------------\n");
        }

        public static void LerPilhaResultados(Stack<decimal> pilhaResultados)
        {
            Console.WriteLine("Resultados totais obtidos: " + pilhaResultados.Count);
            Console.WriteLine("--------------");
            Console.WriteLine("Resultados:");
            while (pilhaResultados.Count > 0)
            {
                decimal resultado = pilhaResultados.Pop();
                Console.Write(resultado + " | ");
            }
            Console.WriteLine("");
        }
    }
}
