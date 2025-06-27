using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class DivisiveisPor4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numeros divisiveis por 4 (menores que 200):");

            for (int i = 1; i < 200; i++)
            {
                
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
