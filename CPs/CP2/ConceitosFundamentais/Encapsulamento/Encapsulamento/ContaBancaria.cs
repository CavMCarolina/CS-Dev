using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class ContaBancaria
    {
        private double saldo;
        private string titular;
        private string numeroConta;
        private string agencia;
        private string banco;

        public double Saldo { get; set; }
        public string Titular { get; set; }
        public string NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }

        public ContaBancaria(string titular, string numeroConta, string agencia, string banco)
        {
            this.titular = titular;
            this.numeroConta = numeroConta;
            this.agencia = agencia;
            this.banco = banco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Titular: {titular}\nBanco: {banco}\nAgência: {agencia}\nNúmero da Conta: {numeroConta}\nSaldo: R${Saldo}\n");
        }
    }
}
