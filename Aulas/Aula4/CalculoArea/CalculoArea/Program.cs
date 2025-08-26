using System;

namespace CalculoArea
{
    internal class Program
    {
        static double b = 0;
        static double h = 0;
        static double r = 0;

        // /// <summary> = comentario de documentação. equivalente ao javadoc
        /// <summary>
        /// Print - Metodo para imprimir na tela
        /// </summary>
        /// <param name="value">mensagem a ser imprimida</param>
        static void Print(String value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Print - Metodo para imprimir na tela
        /// </summary>
        /// <param name="value">mensagem a ser imprimida</param>
        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Função para calcular a area do triangulo
        /// </summary>
        /// <param name="b">base do triangulo</param>
        /// <param name="h">altura do triangulo</param>
        /// <returns>area do triangulo</returns>
        static double CalculoAreaTriangulo(double b, double h)
        {
            double area = (b * h) / 2;
            return area;
        }

        /// <summary>
        /// Função para calcular a area do retangulo
        /// </summary>
        /// <param name="b">base do retangulo</param>
        /// <param name="h">altura do retangulo</param>
        /// <returns>area do retangulo</returns>
        static double CalculoAreaRetangulo(double b, double h)
        {
            double area = b * h;
            return area;
        }

        /// <summary>
        /// Função para calcular a area do circulo
        /// </summary>
        /// <param name="r">raio do circulo</param>
        /// <returns>area do circulo</returns>
        static double CalculoAreaCirculo(double r)
        {
            double area = Math.Pow(r, 2) * Math.PI;
            return area;
        }

        static void Main(string[] args)
        {
            Print("Insira seu nome: ");
            String nome = Console.ReadLine();

            Print("Qual forma geométrica deseja calcular a área?");
            Print("1 - Triângulo");
            Print("2 - Retângulo");
            Print("3 - Círculo");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Print("Digite a base do triângulo: ");
                b = double.Parse(Console.ReadLine());
                Print("Digite a altura do triângulo: ");
                h = double.Parse(Console.ReadLine());
                double area = CalculoAreaTriangulo(b, h);
                Print(nome + " a área do triângulo é: ");
                Print(area);
            }
            else if (opcao == 2)
            {
                Print("Digite a base do retângulo: ");
                b = double.Parse(Console.ReadLine());
                Print("Digite a altura do retângulo: ");
                h = double.Parse(Console.ReadLine());
                double area = CalculoAreaRetangulo(b, h);
                Print(nome + " a área do retângulo é: ");
                Print(area);
            }
            else if (opcao == 3)
            {
                Print("Digite o raio do círculo: ");
                r = double.Parse(Console.ReadLine());
                double area = CalculoAreaCirculo(r);
                Print(nome + " a área do círculo é: ");
                Print(area);
            }
            else
            {
                Print("Opção inválida!");
            }

        }
    }
}