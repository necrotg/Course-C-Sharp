using System;

namespace Desafio_Jogo_da_velha
{
    class Program
    {
        static String[,] jogo = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        static bool victory = false;
        static void Main(string[] args)
        {
            printJogo();
            while (victory == false)
            {
                Console.WriteLine("Player 1: Escolha um campo:");
                String input = Console.ReadLine();
                String jogador = "X";
                verify(input,jogador);
                printJogo();
                wincond(jogador);
                Console.WriteLine("Player 2: Escolha um campo:");
                input = Console.ReadLine();
                jogador = "O";
                verify(input,jogador);
                printJogo();
                wincond(jogador);
            }
            
            static void verify(String input,String jogador)
            {
                for (int i = 0; i < jogo.GetLength(0); i++)
                {
                    for (int j = 0; j < jogo.GetLength(0); j++)
                    {
                        
                        if (input.Equals(jogo[i, j])) {
                            if (jogo[i, j] == "X" || jogo[i, j] == "O")
                            {
                                Console.WriteLine("Digite numero valido");
                                input = Console.ReadLine();
                                verify(input, jogador);
                            }
                            jogo[i, j] = jogador;
                        }
                    }
                }

            }

            static void printJogo()
            {
                Console.Clear();
                Console.WriteLine("     |     |          \n  {0}  |  {1}  |  {2}  \n_____|_____|_____\n     |     |          \n  {3}  |  {4}  |  {5}  \n_____|_____|_____" +
                "\n     |     |          \n  {6}  |  {7}  |  {8}  \n     |     |    \n", jogo[0, 0], jogo[0, 1], jogo[0, 2], jogo[1, 0], jogo[1, 1], jogo[1, 2], jogo[2, 0], jogo[2, 1], jogo[2, 2]);
            }

            static void wincond(String jogador)
            {
                if (jogo[0, 0].Equals(jogo[1, 0]) && jogo[0, 0].Equals(jogo[2,0]) || jogo[0, 1].Equals(jogo[1, 1]) && jogo[0, 1].Equals(jogo[2, 1]) || jogo[0, 2].Equals(jogo[1, 2]) && jogo[0, 2].Equals(jogo[2, 2]) || (jogo[0, 0].Equals(jogo[1, 1])&&jogo[0, 0].Equals(jogo[2, 2])) || (jogo[0, 2].Equals(jogo[1, 1])&&jogo[0, 2].Equals(jogo[2, 0])) || jogo[0, 0].Equals(jogo[0, 1]) && jogo[0, 0].Equals(jogo[0, 2]) || jogo[1, 0].Equals(jogo[1, 1]) && jogo[1, 0].Equals(jogo[1, 2]) || jogo[2, 0].Equals(jogo[2, 1]) && jogo[2, 0].Equals(jogo[2, 2]))
                {
                    int numero;
                    switch (jogador)
                    {
                        case "X": numero = 1; break;
                        case "O": numero = 2; break;
                        default: numero = 2; break;
                    }
                    Console.WriteLine("Parabens Jogador {0}",numero);
                    Console.ReadKey();
                } 
            }

        }
    }
}
