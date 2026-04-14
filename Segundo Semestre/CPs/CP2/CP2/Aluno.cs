using System;
using System.Collections.Generic;
using System.Text;

namespace CP2
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString() => $"[{Id}] {Nome} - {Idade} anos";
    }
}
