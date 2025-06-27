using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class ConverterFahrenheitparaCelsius
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperatura em Celsius: {celsius}°C");
        }
    }
}
