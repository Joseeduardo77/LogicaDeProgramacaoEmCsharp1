using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manzano
{
    class CadastroComConfirmacao
    {
        public static void Main(string[] args)
        {
            string resposta = "";

            do
            {
                Console.Write("Digite um novo nome para cadastrar: ");
                string nome = Console.ReadLine();
                Console.WriteLine($"Nome cadastrado: {nome}");

                Console.Write("Deseja cadastrar outro nome? (SIM/NAO): ");
                resposta = Console.ReadLine().ToUpper();
            }
            while (resposta == "SIM");

            Console.WriteLine("Cadastro finalizado.");
        }
    }
}
