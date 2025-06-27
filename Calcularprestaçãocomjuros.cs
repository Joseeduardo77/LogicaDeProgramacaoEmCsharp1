using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Calcularprestaçãocomjuros
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor da dívida: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros (%): ");
            double taxa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo (meses): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            double prestacao = valor + (valor * taxa / 100 * tempo);

            Console.WriteLine($"Valor da prestação: R$ {prestacao:F2}");
        }
    }
}
