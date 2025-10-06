using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[3];

            veiculos[0] = new Carro();
            veiculos[1] = new Caminhao();
            veiculos[2] = new Moto();

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].Acelerar();
            }
        }
    }
}
