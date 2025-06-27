using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class OperacoesComQuatroValores
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            int P = A + C;
            int S = B + D;

            Console.WriteLine($"Resultado do primeiro com o terceiro (P): {P}");
            Console.WriteLine($"Resultado do segundo com o quarto (S): {S}");
        }
    }
}
