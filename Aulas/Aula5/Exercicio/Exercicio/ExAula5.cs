using System;

// Separa os blocos
namespace Exercicio
{
    internal class ExAula5
    {
        static void Main(string[] args)
        {
            // Looping duplo --> pirâmide
            // a = altura. l = linha. e = espaço
            int a = 0;
            int e = 0;

            while(a < 10)
            {
                for(int l = 0; l < a; l++)
                {
                    while (e < 10)
                    {
                        Console.Write(" ");
                        e++;
                    }

                    Console.Write("* ");
                }

                Console.WriteLine();
                a++;
            }

            //for (int a = 0; a < 10; a++)
            //{
            //    while (l <= a) 
            //    {
            //        // while para espaços --> vão diminuindo conforme a linha

            //        for (int e = 10; e >= l; e--)
            //        {
            //            Console.Write(" ");
            //        }

            //        // asteriscos vão aumentando de quantidade de acordo com a linha
            //        for (l = 0; l < a; l++) {
            //            Console.Write("* ");
            //        }

            //        l++;
            //    }

            //    // pula para a proxima linha
            //    Console.WriteLine();
            //}
        }
    }
}