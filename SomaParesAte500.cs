using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SomaParesAte500
    {
        public static void Main(string[] args)
        {
            int i = 1, soma = 0;
            while (i <= 500)
            {
                if (i % 2 == 0)
                    soma += i;
                i++;
            }
            Console.WriteLine($"Soma dos pares de 1 a 500: {soma}");
        }
    }
}
