using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP1
{
    public class Pessoa
    {
        public int Id { get; set; }   // usado como chave
        public string Nome { get; set; }

        public override string ToString() => $"{Nome}";
    }
}

