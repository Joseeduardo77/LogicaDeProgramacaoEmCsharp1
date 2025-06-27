using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Converterrealparadolar
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor em reais: ");
            double reais = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a cotação do dólar: ");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            double dolares = reais / cotacao;

            Console.WriteLine($"Valor em dólares: $ {dolares:F2}");
        }
    }
}
