using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
     class Calcularvolumedalatadeoleo
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o raio da lata (em cm): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata (em cm): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;

            Console.WriteLine($"Volume da lata: {volume} cm³");
        }
    }
}
