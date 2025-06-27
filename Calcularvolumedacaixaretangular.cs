using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Calcularvolumedacaixaretangular
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o comprimento: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine($"Volume da caixa: {volume}");
        }
    }
}
