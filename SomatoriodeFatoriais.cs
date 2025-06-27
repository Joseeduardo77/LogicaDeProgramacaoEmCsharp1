using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    internal class SomatoriodeFatoriais
    {
        public static void Main(string[] args)
        {
            
            double somaDosFatoriais = 0;

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Digite o " + i + "o valor: ");
                int valor = int.Parse(Console.ReadLine());

               
                double fatorial = 1;
                for (int j = 1; j <= valor; j++)
                {
                    fatorial = fatorial * j;
                }

                
                somaDosFatoriais = somaDosFatoriais + fatorial;
            }

            Console.WriteLine("A soma dos fatoriais e: " + somaDosFatoriais);
        }
    }
}
