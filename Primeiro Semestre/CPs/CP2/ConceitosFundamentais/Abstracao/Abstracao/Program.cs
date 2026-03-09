using System;

namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma circulo = new Circulo();
            Forma quadrado = new Quadrado();

            Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Área do Quadrado: {quadrado.CalcularArea()}");
        }
    }
}
