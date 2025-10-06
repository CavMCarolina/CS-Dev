using System;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("João Silva", "12345-6", "0001", "Banco Exemplo");
            conta.Exibir(); // saldo = 0 por padrão
            conta.Saldo = 150.75; // usando o setter para definir o saldo
            conta.Exibir(); // saldo atualizado
        }
    }
}
