using System; //biblioteca do sistema

// Separa os blocos
namespace Aula1
{
    internal class Aula1
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Hello World!");

            Console.WriteLine("Aula 1 - teste");

            // Escreve sem enter
            Console.Write("aaaaaaaaaaaaaaaaaaaaaaaaaaa");

            Console.WriteLine("adadasdadsa");

            // Sonzinho
            //Console.Beep(000, 1);

            // Espera o usuário apertar uma tecla para sair (terminal estava fechando muito rápido)
            //Console.WriteLine("Pressione qualquer tecla para sair...");
            //Console.ReadLine();
        }
    }
}