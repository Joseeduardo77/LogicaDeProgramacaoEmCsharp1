using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
   class SaudacaoGenero
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o sexo (M ou F): ");
            string sexo = Console.ReadLine().ToUpper();

            if (sexo == "M")
                Console.WriteLine($"Ilmo Sr. {nome}");
            else if (sexo == "F")
                Console.WriteLine($"Ilma Sra. {nome}");
            else
                Console.WriteLine("Sexo inválido.");
        }
    }
}
