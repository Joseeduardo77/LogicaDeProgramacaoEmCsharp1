using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class QuadradoDaSoma
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            int soma = A + B + C;
            int resultado = soma * soma;

            Console.WriteLine($"Quadrado da soma dos três valores: {resultado}");
        }
    }
}
