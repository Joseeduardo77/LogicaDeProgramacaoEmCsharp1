using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class CelsiusParaFahrenheit
    {
        public static void Main(string[] args)
        {
            int celsius = 10;

            while (celsius <= 100)
            {
                double fahrenheit = (9 * celsius / 5.0) + 32;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                celsius += 10;
            }
        }
    }
}
