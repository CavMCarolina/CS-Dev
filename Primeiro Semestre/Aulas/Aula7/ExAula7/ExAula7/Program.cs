using System;

namespace ExAula7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo 10 carros com diferentes atributos
            Carro carro1 = new Carro("Sedan", "ABC123", "Vermelho", "V6");
            Carro carro2 = new Carro("SUV", "XYZ789", "Azul", "Elétrico");
            Carro carro3 = new Carro("Hatch", "DEF456", "Preto", "1.0");
            Carro carro4 = new Carro("Pickup", "GHI321", "Branco", "Diesel");
            Carro carro5 = new Carro("Conversível", "JKL654", "Amarelo", "V8");
            Carro carro6 = new Carro("Crossover", "MNO987", "Cinza", "Híbrido");
            Carro carro7 = new Carro("Minivan", "PQR741", "Verde", "2.0");
            Carro carro8 = new Carro("Coupe", "STU852", "Laranja", "Turbo");
            Carro carro9 = new Carro("Roadster", "VWX963", "Azul Claro", "Elétrico");
            Carro carro10 = new Carro("Wagon", "YZA159", "Marrom", "1.8");

            // Adicionando carros em uma lista
            Carro[] listaCarros = { carro1, carro2, carro3, carro4, carro5, carro6, carro7, carro8, carro9, carro10 };

            // Printando a lista
            Console.WriteLine("~~~~ Lista de Carros: ~~~~\n");

            // For para percorrer cada carro da lista
            for (int i= 0; i < listaCarros.Length; i++)
            {
                Console.WriteLine($"~~~ Carro {i + 1} ~~~");
                Console.WriteLine($"Chassis: {listaCarros[i].chassis}\nLicense Plate: {listaCarros[i].licensePlate}\nCor: {listaCarros[i].cor}\nMotor: {listaCarros[i].motor}\n");
            }
        }
    }
}