using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class VerificaFaixa
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= 9)
                Console.WriteLine("Número está na faixa permitida.");
            else
                Console.WriteLine("Número fora da faixa permitida.");
        }
    }
}
