using System;
using stone_paper_scissors;

namespace Pedra__paper__tisora
{
    class Program
    {
        static void Main(string[] args)
        {
            Program play = new Program();
            play.play();
        }
        private void play() {
            char player1;
            char player2;

            methods methods = new methods();

            methods.print_characteristics();

            for (int i = 0; i < 10; i++) {
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("\nPlayer 1, please choose...");
                player1 = methods.ask_for_values();
                System.Threading.Thread.Sleep(1200);
                Console.WriteLine("\nPlayer 2, please choose...");
                player2 = methods.ask_for_values();
            }

        }
    }
}