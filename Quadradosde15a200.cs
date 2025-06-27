using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    internal class Quadradosde15a200
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício A: Quadrados dos números inteiros de 15 a 200.");

            for (int i = 15; i <= 200; i++)
            {
                long quadrado = (long)i * i;
                Console.WriteLine($"{i}² = {quadrado}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
