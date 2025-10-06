using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Carro : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("O carro está acelerando...");
        }
    }
}
