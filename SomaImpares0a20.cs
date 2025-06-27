using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SomaImpares0a20
    {
        public static void Main(string[] args)
        {
            int i = 0, soma = 0;
            while (i <= 20)
            {
                if (i % 2 != 0)
                    soma += i;
                i++;
            }
            Console.WriteLine($"Soma dos ímpares de 0 a 20: {soma}");
        }
    }
}
