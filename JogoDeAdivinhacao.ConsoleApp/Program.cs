using System;

namespace JogoDeAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 21); // Gera um número entre 1 e 20 

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Escolha o nível de dificuldade:");
            Console.WriteLine("(1) Fácil - 3 chances");
            Console.WriteLine("(2) Médio - 6 chances");
            Console.WriteLine("(3) Difícil - 9 chances");

            Console.Write("Digite o número correspondente ao nível de dificuldade: ");
            int nivelDificuldade = int.Parse(Console.ReadLine());

            int numeroDeChances;
            switch(nivelDificuldade)
            { 
                case 1:
                numeroDeChances = 3;
                break;
            case 2:
                numeroDeChances = 6;
                break;
            case 3:
                numeroDeChances = 9;
                break;
            default:
                Console.WriteLine("Nível de dificuldade inválido. Definindo para o nível Médio (6 chances).");
                numeroDeChances = 6;
                break;
            }
            int pontuacao = 1000;

            while (numeroDeChances > 0)
            {
                Console.WriteLine($"Chances restantes: {numeroDeChances}");
                Console.Write("Digite seu palpite (entre 1 e 20): ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    break;
                }
                else
                {
                    Console.WriteLine("Você errou!");

                    if (palpite > numeroAleatorio)
                    {
                        Console.WriteLine("O número pensado é menor que o seu palpite.");
                    }
                    else
                    {
                        Console.WriteLine("O número pensado é maior que o seu palpite.");
                    }

                    int pontuacaoPerdida = Math.Abs(palpite - numeroAleatorio) / 2;
                    pontuacao -= pontuacaoPerdida;

                    Console.WriteLine($"Pontuação perdida: {pontuacaoPerdida}");
                    Console.WriteLine();
                }

                numeroDeChances--;
            }

            Console.WriteLine();
            Console.WriteLine($"Pontuação final: {pontuacao}");
            Console.WriteLine("Obrigado por jogar!");

            Console.ReadLine();
        }
    }
}
    
