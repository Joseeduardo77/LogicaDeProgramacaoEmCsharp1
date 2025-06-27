using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SomaDos100PrimeirosInteiros
    {
        public static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine("A soma dos 100 primeiros numeros e: " + soma);
        }
    }
}
