using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de números inteiros positivos: ");

        int soma = 0;
        int i = 0;

        do
        {
            Console.WriteLine("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o número é positivo
            if (numero > 0)
            {
                soma += numero; 
                Console.WriteLine("O número escolhido foi: " + numero);
                i++;
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }

        } while (i < 5); // O loop continua até que 5 números válidos sejam inseridos

        Console.WriteLine("A soma da sequência dos números é: " + soma);
    }
}
