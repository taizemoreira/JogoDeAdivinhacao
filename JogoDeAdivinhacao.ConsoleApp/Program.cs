//Desenvolva um jogo de adivinhação. O computador pensará em um número, e você, jogador, precisará adivinhá-lo.
//A cada erro, a máquina lhe dirá se o número chutado foi maior ou menor do que o pensado. Você também poderá
//escolher o nível de dificuldade do jogo, e isso lhe dará mais ou menos oportunidades de chutar um número. Ao
//final, se você ganhar, o computador lhe dirá quantos pontos você fez, baseando-se em quão bons eram seus
//chutes.
//Pesquise sobre a geração de números randômicos em C#.
//O jogador deverá adivinhar um número entre 1 e 20.
//Os níveis de dificuldade serão:
//(1) Fácil = 15 chances
//(2) Médio = 10 chances
//(3) Difícil = 5 chances

//A pontuação do usuário começará em 1000, caso o usuário erre, será subtraído um valor da pontuação com a
//seguinte fórmula:
// (numero chutado – numero aleatório) / 2
//Caso o resultado seja negativo, deverá ser extraído o valor absoluto.
using System;

namespace JogoDeAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontuacaoUsuario;
            int numeroAleatorio = new Random().Next(1, 21);
            int ultimoNumero = 20, primeiroNumero = 1;
            int escolhaUsuario = 0, nivelDificuldade = 0, quantidadeTentativas = 0;


            Console.WriteLine("***************************************");
            Console.WriteLine("* Bem vindo(a) ao jogo de adivinhação *");
            Console.WriteLine("***************************************\n\n");

            do
            {
                Console.WriteLine("Escolha o nível de dificuldade:\n [1]Fácil(15 tentativas)\n [2]Médio(10 tentativas)\n [3]Difícil(5 tentativas)\n Escolha:");
                nivelDificuldade = Convert.ToInt32(Console.ReadLine());
            } while (nivelDificuldade < 1 || nivelDificuldade > 3);




            do
            {
                numeroAleatorio = primeiroNumero + (ultimoNumero - primeiroNumero) / 2;
                tentativas++;
                Console.WriteLine("O número que você escolheu é maior,menor ou igual a %d? Digite '>', '<' ou '=' respectivamente\n Número de tentativas : %d\n", aleatorio, tentativas);
                Console.ReadLine(" %c", &simbolomate);
                
                switch (simbolomate)
                {
                    case '=':
                        Console.Write("número correto");
                        break;
                    case '>':
                        primeiroNumero = numeroAleatorio + 1;
                        break;
                    case '<':
                        ultimoNumero = numeroAleatorio - 1;
                        break;
                }
            } while (simbolomate != '=');
        }

        int main()
        {
            int numero, tentar_de_novo = 1;
            do
            {
                Console.Write("Pense e digite um número de 1 a 100\n");
                Console.ReadLine("%d", &numero);
                adivinha();
                Console.Write("Se você deseja jogar novamente digite um qualquer numero, se não digite 0\n");
                Console.ReadLine("%d", &tentar_de_novo);
            } while (tentar_de_novo);
            return 0;
        }
    }
    }
}