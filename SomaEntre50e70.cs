using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SomaEntre50e70
    {
        public static void Main(string[] args)
        {
            int i = 1, soma = 0;

            while (i <= 10)
            {
                Console.Write($"Digite o {i}º número: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 50 && num <= 70)
                    soma += num;

                i++;
            }

            Console.WriteLine($"Soma dos valores entre 50 e 70: {soma}");
        }
    }
}
