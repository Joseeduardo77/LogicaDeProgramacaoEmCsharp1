using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class Quadrados2de15a200
    {
     public static void Main(string[] args)
        {
            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;
                Console.WriteLine("O quadrado de " + i + " e: " + quadrado);
            }
        }
    }
}
