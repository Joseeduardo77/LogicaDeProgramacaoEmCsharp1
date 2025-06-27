using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class MediaComNotaExtra
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 + n2) / 2;

            if (media >= 7)
                Console.WriteLine($"Aprovado com média {media}");
            else
            {
                Console.Write("Digite a nota do exame: ");
                double exame = double.Parse(Console.ReadLine());

                double novaMedia = (media + exame) / 2;

                if (novaMedia >= 5)
                    Console.WriteLine($"Aprovado em exame com média {novaMedia}");
                else
                    Console.WriteLine($"Reprovado com média {novaMedia}");
            }
        }
    }
}
