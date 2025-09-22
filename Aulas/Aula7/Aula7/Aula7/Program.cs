using System;

namespace Aula7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo(123456);
            veiculo.Ligar();
            veiculo.Placa = "ABC-1234";
        }
    }
}