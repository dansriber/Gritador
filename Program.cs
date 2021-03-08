using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
           string qualquerCoisa;

            //<---Inicio(Digite)--->//
            Console.Write("Digite qualquer coisa: ");
            qualquerCoisa = Console.ReadLine();

            Console.WriteLine($"{qualquerCoisa}!!!".ToUpper());
            //<---Fim(Digite)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->// 
        }
    }
}
