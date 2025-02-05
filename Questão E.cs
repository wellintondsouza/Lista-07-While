using System;
	

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequencia de números inteiros positivos: ");
        
        int soma = 0;
        int i = 0;
        
        while (i <= 5)
        {
            // Solicita ao usuário para digitar um número
            Console.WriteLine("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o número é positivo
            if (numero > 0)
            {
                soma += numero; // Soma o número à variável soma
                Console.WriteLine("O número escolhido foi: " + numero);
                i++; // Incrementa o contador para ir para o próximo número
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
               
            }
            Console.WriteLine("a soma da sequencia dos numeros é: "+soma);
         
        }

        
        
    }
}
