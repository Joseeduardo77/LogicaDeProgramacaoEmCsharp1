using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class AreaResidencia
    {
        public static void Main(string[] args)
        {
            int i = 1;
            double areaTotal = 0;

            while (i <= 4)
            {
                Console.Write($"Digite o nome do cômodo {i}: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite a largura do cômodo {nome}: ");
                double largura = double.Parse(Console.ReadLine());

                Console.Write($"Digite o comprimento do cômodo {nome}: ");
                double comprimento = double.Parse(Console.ReadLine());

                double area = largura * comprimento;
                areaTotal += area;

                Console.WriteLine($"Área do {nome}: {area} m²");
                i++;
            }

            Console.WriteLine($"Área total da residência: {areaTotal} m²");
        }
    }
}
