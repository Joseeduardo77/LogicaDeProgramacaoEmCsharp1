using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class ApuracaoVotos
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o número total de eleitores: ");
            int totalEleitores = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos para o candidato A: ");
            int votosA = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos para o candidato B: ");
            int votosB = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de votos para o candidato C: ");
            int votosC = int.Parse(Console.ReadLine());

            double percValidos = (votosValidos * 100.0) / totalEleitores;
            double percBrancos = (votosBrancos * 100.0) / totalEleitores;
            double percNulos = (votosNulos * 100.0) / totalEleitores;

            double percA = (votosA * 100.0) / votosValidos;
            double percB = (votosB * 100.0) / votosValidos;
            double percC = (votosC * 100.0) / votosValidos;

            Console.WriteLine($"\nPercentual de votos válidos: {percValidos:F2}%");
            Console.WriteLine($"Percentual de votos brancos: {percBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percNulos:F2}%");
            Console.WriteLine($"Percentual de votos do candidato A: {percA:F2}%");
            Console.WriteLine($"Percentual de votos do candidato B: {percB:F2}%");
            Console.WriteLine($"Percentual de votos do candidato C: {percC:F2}%");
        }
    }
}
