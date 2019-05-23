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

            methods choose_values = new methods();

            player1 = choose_values.ask_for_values();
            player2 = choose_values.ask_for_values();

        }
    }
}
