using System;

namespace ExAula3
{
    internal class ExAula3
    {
        static void Main(string[] args)
        {
            int i1, i2;

            Console.Write("Insira a idade do aluno 1: ");
            i1 = int.Parse(Console.ReadLine());

            Console.Write("Insira a idade do aluno 2: ");
            i2 = int.Parse(Console.ReadLine());

            if (i1 == i2)
            {
                Console.WriteLine("Os alunos têm a mesma idade");
            }
            if (i1 > i2)
            {
                Console.WriteLine("O aluno 1 é mais velho que o aluno 2");
            }
            if (i2 > i1)
            {
                Console.WriteLine("O aluno 2 é mais velho que o aluno 1");
            }

            // Espera o usuário apertar uma tecla para sair (terminal estava fechando muito rápido)
            //Console.WriteLine("Pressione qualquer tecla para sair...");
            //Console.ReadLine();
        }
    }
}