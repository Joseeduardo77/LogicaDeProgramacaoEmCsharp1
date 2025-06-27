using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Converterdolarparareal
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor em dólares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a cotação do dólar: ");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            double reais = dolares * cotacao;

            Console.WriteLine($"Valor em reais: R$ {reais:F2}");
        }
    }
}
