using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class AreaDaResidencia
    {
        public static void Main(string[] args)
        {
            double areaTotal = 0;
            string resposta = "sim";

            while (resposta == "sim")
            {
                Console.Write("Digite a largura do comodo: ");
                double largura = double.Parse(Console.ReadLine());

                Console.Write("Digite o comprimento do comodo: ");
                double comprimento = double.Parse(Console.ReadLine());

                double areaComodo = largura * comprimento;
                areaTotal = areaTotal + areaComodo;

                Console.WriteLine("A area do comodo e: " + areaComodo);

                Console.Write("Deseja informar outro comodo? (sim/nao): ");
                resposta = Console.ReadLine();
            }

            Console.WriteLine("A area total da casa e: " + areaTotal);
        }
    }
}
