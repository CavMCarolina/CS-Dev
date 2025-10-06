using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carne : Comida
    {
        public string Proteina { get; set; }
        public string Ponto { get; set; }
        public Carne(string nome, double peso, string proteina, string ponto) : base(nome, peso)
        {
            Proteina = proteina;
            Ponto = ponto;
        }
        public void DescreverCarne()
        {
            Descrever();
            Console.WriteLine($"Quantidade de Proteína: {Proteina}\nPonto da Carne: {Ponto}");
        }
    }
}

