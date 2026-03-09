using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    internal class Livro
    {
        string titulo;
        string autor;
        int anoPublicacao;


        public Livro(string titulo, string autor,int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("~~~~ Livro ~~~~");
            Console.WriteLine($"{titulo} - {autor} ({anoPublicacao})");
        }
    }
}
