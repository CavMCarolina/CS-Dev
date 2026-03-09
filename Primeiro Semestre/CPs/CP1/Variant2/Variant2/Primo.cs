// Projeto de Avaliação (Revisado) - Variante 2: Verificação de número primo
// O código a seguir deve ler um número inteiro do usuário e informar se ele é primo.
// Para aumentar a dificuldade, a implementação possui erros de tipo, lógica e fluxo.

using System;

class Primo
{
    static void Main()
    {
        Console.Write("Informe um número natural: ");

        // Não pode ser char --> Número = int
        int numero = int.Parse(Console.ReadLine());
        bool ePrimo;

        ePrimo = VerificarPrimo(numero);

        // Se ePrimo for true, então o número é primo. Se for false, não é primo.
        if (ePrimo == true)
        {
            Console.WriteLine("O número " + numero + " é primo");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não é primo");
        }
    }

    static bool VerificarPrimo(int n)
    {
        bool primo = true;

        // Verificar o divisor. Se n for divisível por qualquer número que não seja 1 ou ele mesmo, então não é primo.
        for (int divisor = 2; divisor <= n / divisor; divisor++)
        {
            if (n % divisor == 0)
            {
                primo = false;
                break;
            }
        }

        return primo;
    }
}