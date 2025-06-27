using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class DiferencaMaiorMenor
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int maior = Math.Max(num1, num2);
            int menor = Math.Min(num1, num2);
            int diferenca = maior - menor;

            Console.WriteLine($"Diferença do maior pelo menor: {diferenca}");
        }
    }
}
