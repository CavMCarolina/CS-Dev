using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Comida
    {
        public string Nome { get; set; }
        public double Peso { get; set; }

        public Comida(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public void Descrever()
        {
            Console.WriteLine($"\nComida: {Nome}\nPeso: {Peso}g");
        }
    }
}
