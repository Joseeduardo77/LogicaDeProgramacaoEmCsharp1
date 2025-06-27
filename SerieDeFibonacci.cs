using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SerieDeFibonacci
    {
        public static void Main(string[] args)
        {
            int anterior = 0;
            int atual = 1;

            Console.WriteLine("Serie de Fibonacci (15 primeiros termos):");

            // Ja mostra o primeiro termo
            Console.WriteLine(atual);

            for (int i = 1; i < 15; i++)
            {
                int proximo = anterior + atual;
                Console.WriteLine(proximo);

                anterior = atual;
                atual = proximo;
            }
        }
    }
}
