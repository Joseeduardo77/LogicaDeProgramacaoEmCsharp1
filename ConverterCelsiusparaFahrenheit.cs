using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class ConverterCelsiusparaFahrenheit
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}°F");
        }
    }
}
