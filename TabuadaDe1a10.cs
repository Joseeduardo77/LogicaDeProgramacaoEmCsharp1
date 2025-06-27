using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class TabuadaDe1a10
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"Tabuada do {i}:");
                int j = 1;
                while (j <= 10)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
