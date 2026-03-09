using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class Quadrado : Forma
    {
        public override double CalcularArea()
        {
            double lado = 4.0; // Exemplo de lado
            return lado * lado;
        }
    }
}

