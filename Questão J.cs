using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a senha: ");
        string input;
        int attempts = 0; // Inicializa o contador de tentativas

        do
        {
            input = Console.ReadLine(); // Lê a entrada do usuário

            // Verifica se a entrada está vazia
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }


            if (input == "1234") // Verifica se a senha está correta
            {
                Console.WriteLine("A senha está correta! Sucesso.");
                break; // Sai do loop após a senha correta
            }
            else
            {
                attempts++;
                if (attempts >= 3)
                {
                    Console.WriteLine("Número máximo de tentativas atingido! Tente Novamente mais tarde...");
                    break; // Sai do loop após 3 tentativas falhas
                }
                else
                {
                    Console.WriteLine("Senha incorreta. Tente novamente.");
                }
            }
        }while (true);

        Console.ReadKey(); // Aguarda uma tecla para fechar o console
    }
}
