using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Veiculo
    {
        public virtual void Acelerar()
        {
            Console.WriteLine("O veículo está acelerando...");
        }
    }
}
