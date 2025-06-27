using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class EquacaoComValores
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double C = double.Parse(Console.ReadLine());

            double resultado = (A + B) * C;

            Console.WriteLine($"Resultado da equação (A + B) * C: {resultado}");
        }
    }
}
