using System; //biblioteca do sistema

// Separa os blocos
namespace Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array de números --> ordem
            int[] listaNumeros = { 5, 6, 4, 46, 32, 12 };

            int numero = 0;

            // array de números --> senha
            int[] listaSenha = { 5, 4, 6, 9 };

            int[] senhaNumeros = { 0, 0, 0, 0 };

            while (true)
            {
                // Lógica dos números
                //Console.WriteLine("\n~~~ Tente descobrir a ordem dos números ~~~");

                //numero = int.Parse(Console.ReadLine());

                //for (int i = 0; i < listaNumeros.Length; i++)
                //{
                //    if(numero == listaNumeros[i])
                //    {
                //        Console.WriteLine("Esse número está certo!");
                //        if (i >= listaNumeros.Length - 1) 
                //        {
                //            return;
                //        }
                //        numero = int.Parse(Console.ReadLine());
                //    }
                //    else{
                //        Console.WriteLine("Tente novamente :(");
                //        break;
                //    }
                //}

                // Lógica da senha --> sem ser um por um
                Console.WriteLine("\n~~~ Tente descobrir a senha ~~~");

                for (int i = 0; i < listaSenha.Length; i++)
                {
                    Console.Write("Digito " + (i + 1) + ": ");
                    senhaNumeros[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < listaSenha.Length; i++)
                {
                    if (senhaNumeros[i] != listaSenha[i])
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