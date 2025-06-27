using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class MaiorMenorDeTres
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int c = int.Parse(Console.ReadLine());

            int maior = Math.Max(a, Math.Max(b, c));
            int menor = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
        }
    }
}
