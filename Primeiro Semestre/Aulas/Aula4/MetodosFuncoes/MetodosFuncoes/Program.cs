using System;

namespace MetodosFuncoes
{
    internal class Program
    {

        static double raio = 0;

        static void Print(String value)
        {
            Console.WriteLine(value);
        }

        // Sobreposição do método Print para aceitar double
        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        static double AreaCirculo(double raio)
        {
            double r = 0;
            // Pow = potencia (base, expoente)
            r = Math.Pow(raio, 2) * Math.PI;

            return r;
        }

        static void Main(string[] args)
        {
            Print("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            double area = AreaCirculo(raio);
            Print("Área do círculo: " + area);
            Print(area);
        }
    }
}