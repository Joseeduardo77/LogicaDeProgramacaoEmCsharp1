using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class CelsiusParaFahrenheit2
    {
        public static void Main(string[] args)
        {
            
            for (int C = 10; C <= 100; C = C + 10)
            {
              
                double F = (9.0 * C + 160.0) / 5.0;
                Console.WriteLine(C + " graus Celsius = " + F + " graus Fahrenheit");
            }
        }
    }
}
