using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class SomatorioMediaeTotal
    {
        public static void Main(string[] args)
        {
            double soma = 0;
            int totalLidos = 0;
            double valor;

            while (true)
            {
                Console.Write("Digite um valor (negativo para parar): ");
                valor = double.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    break;
                }

                soma = soma + valor;
                totalLidos = totalLidos + 1;
            }

            if (totalLidos > 0)
            {
                double media = soma / totalLidos;
                Console.WriteLine("Total de valores lidos: " + totalLidos);
                Console.WriteLine("Soma dos valores: " + soma);
                Console.WriteLine("Media dos valores: " + media);
            }
            else
            {
                Console.WriteLine("Nenhum valor foi digitado.");
            }
        }
    }
}
