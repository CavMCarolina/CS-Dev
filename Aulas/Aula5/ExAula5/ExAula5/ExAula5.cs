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
            
            //for (int a = 0; a < 10; a++)
            //{
            //    for (int e = 10; e >= a; e--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int l = 0; l <= a; l++)
            //    {
            //        Console.Write("* ");
            //    }

            //    // pula para a proxima linha
            //    Console.WriteLine();
            //}

            int a = 0;

            while(a  < 10) 
            {
                for (int e = 10; e >= a; e--)
                {
                    Console.Write(" ");
                }

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