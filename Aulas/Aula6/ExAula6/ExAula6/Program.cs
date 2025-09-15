using System; //biblioteca do sistema

// Separa os blocos
namespace ExAula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array de números --> senha
            string[] listaSenha = { "5", "4", "6", "9" };

            while (true)
            {
                Console.WriteLine("\n~~~ Tente descobrir a senha ~~~\nDigite 4 números separados por um espaço");
                string[] entrada = Console.ReadLine().Split(' ');


                for (int i = 0; i < listaSenha.Length; i++)
                {
                    // Verifica se o usuário digitou 4 números
                    if (entrada.Length != listaSenha.Length)
                    {
                        Console.WriteLine("Por favor, digite exatamente 4 números.");
                        break;
                    }

                    if (entrada[i] != listaSenha[i])
                    {
                        Console.WriteLine("Senha incorreta! Tente novamente :c");
                        break;
                    }

                    if (i == listaSenha.Length - 1)
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        return;
                    }
                }
            }
        }
    }
}