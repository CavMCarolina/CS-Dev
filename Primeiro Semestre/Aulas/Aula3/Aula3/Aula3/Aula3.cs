using System;

namespace Aula3
{
    internal class Aula3
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int r;

            Console.Write("Insira o valor para o n1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor para o n2: ");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;

            if (r == 0)
            {
                Console.WriteLine("O resultado é zero");
            }
            if (r < 0)
            {
                Console.WriteLine("O resultado é negativo");
            }
            if (r > 0)
            {
                Console.WriteLine("O resultado é positivo");
            }

            // Espera o usuário apertar uma tecla para sair (terminal estava fechando muito rápido)
            //Console.WriteLine("Pressione qualquer tecla para sair...");
            //Console.ReadLine();
        }
    }
}