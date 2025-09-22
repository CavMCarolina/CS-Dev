using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Veiculo
    {
        private string placa;

        private int codFrabrica;

        public Veiculo(int codFrabrica)
        {
            this.codFrabrica = codFrabrica;
        }

        // getter e setter --> visual studio cria automatico
        public string Placa { get => placa; set => placa = value; }

        // outro jeito de fazer getter e setter
        //public string Placa
        //{
        //    get { return placa; }
        //    set { placa = value; }
        //}

        // getter e setter pequeno
        //public string Placa { get; set; }

        public void Ligar()
        {
            Console.WriteLine("O veículo está ligado!");
        }
    }
}
