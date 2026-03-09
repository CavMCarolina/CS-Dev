using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comida comida = new Comida("Qualquer Comida", 500);
            comida.Descrever();

            Carne carne = new Carne("Carne Bovina", 300, "25g", "Ao Ponto");
            carne.DescreverCarne();

            Arroz arroz = new Arroz("Arroz", 200, "Integral", "130 calorias");
            arroz.DescreverArroz();
        }
    }
}
