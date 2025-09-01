using System;

// Separa os blocos
namespace ExAula5
{
    internal class ExAula5
    {
        static void Main(string[] args)
        {
            // Looping duplo --> pirâmide
            // a = altura; l = linha; e = espaço

            // 10 de altura
            //for (int a = 0; a < 10; a++)
            //{
            //    // Diminui os espaços conforme a altura
            //    for (int e = 10; e >= a; e--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Aumenta os asteriscos conforme a altura
            //    for (int l = 0; l <= a; l++)
            //    {
            //        Console.Write("* ");
            //    }

            //    // pula para a proxima linha
            //    Console.WriteLine();
            //}

            int a = 0;

            // 10 de altura
            while (a  < 10) 
            {
                // Diminui os espaços conforme a altura
                for (int e = 10; e >= a; e--)
                {
                    Console.Write(" ");
                }

                // Aumenta os asteriscos conforme a altura
                for (int l = 0; l <= a; l++)
                {
                    Console.Write("* ");
                }

                // pula para a proxima linha
                Console.WriteLine();

                a++;
            }
        }
    }
}