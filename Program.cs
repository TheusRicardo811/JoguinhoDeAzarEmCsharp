using System;

class JogoDeSorte
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio, chute, tentativas;

        Console.WriteLine("=== Jogo de Sorte ===");
        Console.WriteLine("Escolha o nível:");
        Console.WriteLine("1 - Fácil (1 a 10, 3 chances)");
        Console.WriteLine("2 - Difícil (1 a 20, 5 chances)");
        Console.Write("Nível: ");
        int nivel = int.Parse(Console.ReadLine());

        if (nivel == 1)
        {
            numeroAleatorio = random.Next(1, 11); // número de 1 a 10
            tentativas = 3;
            Console.WriteLine("Você escolheu o nível Fácil! Tente adivinhar o número de 1 a 10.");
        }
        else if (nivel == 2)
        {
            numeroAleatorio = random.Next(1, 21); // número de 1 a 20
            tentativas = 5;
            Console.WriteLine("Você escolheu o nível Difícil! Tente adivinhar o número de 1 a 20.");
        }
        else
        {
            Console.WriteLine("Nível inválido. Encerrando o jogo.");
            return;
        }

        bool acertou = false;

        for (int i = 1; i <= tentativas; i++)
        {
            Console.Write($"Tentativa {i} de {tentativas}: ");
            chute = int.Parse(Console.ReadLine());

            if (chute == numeroAleatorio)
            {
                Console.WriteLine("Parabéns! Você acertou o número!");
                acertou = true;
                break;
            }
            else if (chute < numeroAleatorio)
            {
                Console.WriteLine("O número é maior!");
            }
            else
            {
                Console.WriteLine("O número é menor!");
            }
        }

        if (!acertou)
        {
            Console.WriteLine($"Suas chances acabaram. O número era {numeroAleatorio}.");
        }

        Console.WriteLine("Fim do jogo. Obrigado por jogar!");
    }
}
