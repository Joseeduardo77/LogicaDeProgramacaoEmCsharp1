using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class MediaComRegras
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
                Console.WriteLine("Aprovado direto.");
            else if (media >= 3 && media < 7)
            {
                Console.Write("Digite a nota do exame: ");
                double exame = double.Parse(Console.ReadLine());

                double mediaFinal = (media + exame) / 2;

                if (mediaFinal >= 5)
                    Console.WriteLine($"Aprovado em exame com média final {mediaFinal}");
                else
                    Console.WriteLine("Reprovado após exame.");
            }
            else
                Console.WriteLine("Reprovado direto.");
        }
    }
}
