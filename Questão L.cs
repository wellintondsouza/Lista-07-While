using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero;
        bool entradaValida;

        do
        {
            entradaValida = int.TryParse(Console.ReadLine(), out numero) && numero >= 0;

            if (!entradaValida)
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }

        } while (!entradaValida);

        Console.WriteLine("Números pares entre 0 e " + numero + ":");

        for (int i = 0; i <= numero; i += 2)
        {
            Console.WriteLine(i);
            Console.ReadKey(true);
        }
    }
}
