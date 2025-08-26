using System; //biblioteca do sistema

// Separa os blocos
namespace Aula2
{
    internal class Aula2
    {
        static void Main(string[] args)
        {
            string nome;
            int valor1;
            int valor2;

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome + "!");

            Console.WriteLine("Por favor, insira o primeiro valor:");

            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, " + nome + ", insira o segundo valor:");

            valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("A soma dos valores é: " + soma);

            // Espera o usuário apertar uma tecla para sair (terminal estava fechando muito rápido)
            //Console.WriteLine("Pressione qualquer tecla para sair...");
            //Console.ReadLine();
        }
    }
}