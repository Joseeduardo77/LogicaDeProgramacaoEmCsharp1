using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    internal class MaiorMenorComInterrupcao
    {
        public static void Main(string[] args)
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;

            while (true)
            {
                Console.Write("Digite um valor positivo (ou negativo para encerrar): ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                    break;

                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;
            }

            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
        }
    }
}
