using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
        }

        Console.WriteLine("Números pares entre 0 e " + numero + ":");

        
        for (int i = 0; i <= numero; i += 2)
        {
            Console.WriteLine(i);
            Console.ReadKey(true);
        }
    }
}
