using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class MediaDeDezNumeros
    {
        public static void Main(string[] args)
        {
            int i = 0, soma = 0;

            while (i < 10)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                soma += int.Parse(Console.ReadLine());
                i++;
            }

            double media = soma / 10.0;
            Console.WriteLine($"Média dos valores: {media:F2}");
        }
    }
}
