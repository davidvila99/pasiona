using System;
using StringsLibrary;

namespace RockPaperScissors {
    
    public class methods {
        public const char Rock = 'R';
        public const char Paper = 'P';
        public const char Scissors = 'S';

        private static cStringsLibrary cStringsLibrary = new cStringsLibrary();


        public void print_characteristics() {
            Console.WriteLine(cStringsLibrary.Game_description);
        }
        public char ask_for_values(){
            char key;

            Console.WriteLine(cStringsLibrary.Select_value);
            key = Char.ToUpper(Console.ReadKey().KeyChar);

            while (key != Rock && key != Paper && key != Scissors) {
                Console.WriteLine(cStringsLibrary.Error_value);
                key = Char.ToUpper(Console.ReadKey().KeyChar);
            }
            return key;
        }

        int CountPlayer1 = 0;
        int CountPlayer2 = 0;
        public void game(char player1, char player2) {

            switch (player1) {
                case Rock:
                    switch (player2) {
                        case Rock:
                            Console.WriteLine(cStringsLibrary.Draw);
                            break;
                        case Paper:
                            Console.WriteLine(cStringsLibrary.Player2_wins);
                            CountPlayer2++;
                            break;
                        case Scissors:
                            Console.WriteLine(cStringsLibrary.Player1_wins);
                            CountPlayer1++;
                            break;
                    }
                    break;
                case Paper:
                    switch (player2) {
                        case Rock:
                            Console.WriteLine(cStringsLibrary.Player1_wins);
                            CountPlayer1++;
                            break;
                        case Paper:
                            Console.WriteLine(cStringsLibrary.Draw);
                            break;
                        case Scissors:
                            Console.WriteLine(cStringsLibrary.Player2_wins);
                            CountPlayer2++;
                            break;
                    }
                    break;
                case Scissors:
                    switch (player2) {
                        case Rock:
                            Console.WriteLine(cStringsLibrary.Player2_wins);
                            CountPlayer2++;
                            break;
                        case Paper:
                            Console.WriteLine(cStringsLibrary.Player1_wins);
                            CountPlayer1++;
                            break;
                        case Scissors:
                            Console.WriteLine(cStringsLibrary.Draw);
                            break;
                    }
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nPlayer1: " + CountPlayer1 + " Player2: " + CountPlayer2);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
