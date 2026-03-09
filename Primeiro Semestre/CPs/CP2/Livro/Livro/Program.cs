using System;

namespace Livro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Um Livro Qualquer", "Autor Bom", 1997);

            livro.ExibirInformacoes();
        }
    }
}
