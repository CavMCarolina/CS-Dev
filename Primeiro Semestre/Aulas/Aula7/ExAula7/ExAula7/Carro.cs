using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAula7
{
    internal class Carro
    {
        public string chassis;
        public string licensePlate;
        public string cor;
        public string motor;

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            this.chassis = chassis;
            this.licensePlate = licensePlate;
            this.cor = cor;
            this.motor = motor;
        }
    }
}
