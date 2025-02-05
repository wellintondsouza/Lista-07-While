using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma sequência de números para serem somados : ");
        int soma = 0;
        string input;

           do
        {
            Console.Write("Digite um número: "); //Pede o usuário para digitar um número
            input = Console.ReadLine();

            // Verifica se o usuário pressionou Enter sem digitar nada
            if (string.IsNullOrWhiteSpace(input))
            {
                break; // Quando o espaço estiver vazio a operação é parada e finalizada
            }

            int numero;
            if (int.TryParse(input, out numero))
            {
                soma += numero;
            }
            else
            {
                Console.WriteLine("Os números são inválidos, por favor digite números válidos.");
            }
        }while (true);

        Console.WriteLine("A soma dos números é: " + soma);
        Console.ReadKey();
    }
}
