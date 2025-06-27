using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SomatorioDosPares2
    {
        public static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 2; i <= 500; i = i + 2)
            {
                soma = soma + i;
            }

            Console.WriteLine("A soma dos pares de 1 a 500 e: " + soma);
        }
    }
}
