using System;
using RockPaperScissors;
using StringsLibrary;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            mPlay();
        }
        private static void mPlay() {
            char player1;
            char player2;

            methods methods = new methods();

            methods.print_characteristics();
          
            //Round 1
            Console.WriteLine(cStringsLibrary.CurrentRound + "1 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 2
            Console.WriteLine(StringsLibrary.CurrentRound + "2 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 3
            Console.WriteLine(StringsLibrary.CurrentRound + "3 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 4
            Console.WriteLine(StringsLibrary.CurrentRound + "4 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 5
            Console.WriteLine(StringsLibrary.CurrentRound + "5 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 6
            Console.WriteLine(StringsLibrary.CurrentRound + "6 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 7
            Console.WriteLine(StringsLibrary.CurrentRound + "7 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round8
            Console.WriteLine(StringsLibrary.CurrentRound + "8 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 9
            Console.WriteLine(StringsLibrary.CurrentRound + "9 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            //Round 10
            Console.WriteLine(StringsLibrary.CurrentRound + "10 ----------");
            Console.WriteLine("\nPlayer 1, please choose...");
            player1 = methods.ask_for_values();
            Console.WriteLine("\nPlayer 2, please choose...");
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            /*for (int i = 0; i < 10; i++) {
                Console.WriteLine(StringsLibrary.CurrentRound + (i+1) + " ----------");
                Console.WriteLine("\nPlayer 1, please choose...");
                player1 = methods.ask_for_values();
                Console.WriteLine("\nPlayer 2, please choose...");
                player2 = methods.ask_for_values();
                methods.game(player1, player2);
                Console.WriteLine();
            }*///Simplifying the code above
        }
    }
}