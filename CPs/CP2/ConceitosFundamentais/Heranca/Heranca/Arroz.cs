using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Arroz : Comida
    {
        public string Tipo { get; set; }
        public string Calorias { get; set; }

        public Arroz(string nome, double peso, string tipo, string calorias) : base(nome, peso)
        {
            Tipo = tipo;
            Calorias = calorias;
        }

        public void DescreverArroz()
        {
            Descrever();
            Console.WriteLine($"Tipo de Arroz: {Tipo}\nCalorias: {Calorias}");
        }
    }
}
