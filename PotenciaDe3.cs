using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class PotenciaDe3
    {
        public static void Main(string[] args)
        {
            
            double resultado = 1;

            Console.WriteLine("3 elevado a 0 = " + resultado);

            for (int i = 1; i <= 15; i++)
            {
                resultado = resultado * 3;
                Console.WriteLine("3 elevado a " + i + " = " + resultado);
            }
        }
    }
}
