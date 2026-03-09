using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class Circulo : Forma
    {
        public override double CalcularArea()
        {
            double raio = 5.0; // Exemplo de raio
            return Math.PI * raio * raio;
        }
    }
}
