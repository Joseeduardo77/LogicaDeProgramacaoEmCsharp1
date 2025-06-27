using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SequenciaFibonacci
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 1, i = 3;
            Console.WriteLine("Fibonacci: ");
            Console.Write($"{a} {b} ");

            while (i <= 10)
            {
                int c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                i++;
            }
        }
    }
}
