using System;
using System.Diagnostics;
using System.Timers; //biblioteca do sistema

// Separa os blocos
namespace Repeticao
{
    internal class Aula5
    {
        static void Main(string[] args)
        {
            // Looping duplo --> quadrado de asterisco
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // 10 asteriscos na linha
                    Console.Write("* ");
                }

                // pula para a proxima linha (para fazer mais 10 asteriscos)
                Console.WriteLine();
            }

            //static void ForFunction()
            //{
            //    // Inicialização da variável, condição de funcionamento e incremento
            //    for (int i = 10000; i > 0; i--)
            //    {
            //        //Console.WriteLine(i);
            //    }
            //}

            //static void WhileFunction()
            //{
            //    int i = 0;
            //    while (i < 10000)
            //    {
            //        //Console.WriteLine(i + 1);

            //        i++;
            //    }
            //}

            //pega a data e a hora atual
            //DateTime UtcNow = DateTime.Now;

            //double microAfter;
            //double microBefore;
            //double elapsed;

            // WHILE
            // pega o microsegundo atual
            //UtcNow = DateTime.Now;
            //microBefore = UtcNow.Microsecond;

            // Chamando o While
            //WhileFunction();

            // pega o microsegundo atual
            //UtcNow = DateTime.Now;
            //microAfter = UtcNow.Microsecond;

            //elapsed = microAfter - microBefore;

            //Console.WriteLine("Tempo decorrido com While: " + Math.Abs(elapsed));

            // FOR
            // pega o microsegundo atual
            //UtcNow = DateTime.Now;
            //microBefore = UtcNow.Microsecond;

            // Chamando o While
            //ForFunction();

            // pega o microsegundo atual
            //UtcNow = DateTime.Now;
            //microAfter = UtcNow.Microsecond;

            //elapsed = microAfter - microBefore;

            //Console.WriteLine("Tempo decorrido com For: " + Math.Abs(elapsed));
        }
    }
}