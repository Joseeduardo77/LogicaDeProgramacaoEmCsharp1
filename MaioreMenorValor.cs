using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class MaioreMenorValor
    {
        public static void Main(string[] args)
        {
            int maior;
            int menor;
            int num;

            Console.Write("Digite um valor (negativo para parar): ");
            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                // O primeiro numero e o maior e o menor por enquanto
                maior = num;
                menor = num;

                while (true)
                {
                    Console.Write("Digite outro valor (negativo para parar): ");
                    num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        // Sai do loop
                        break;
                    }

                    if (num > maior)
                    {
                        maior = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                }

                Console.WriteLine("Maior valor: " + maior);
                Console.WriteLine("Menor valor: " + menor);
            }
            else
            {
                Console.WriteLine("Nenhum numero positivo foi digitado.");
            }
        }
    }
}
