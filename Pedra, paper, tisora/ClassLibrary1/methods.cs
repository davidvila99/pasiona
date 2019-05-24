using System;

namespace stone_paper_scissors
{
    public class methods {
        public const char Rock = 'R';
        public const char Paper = 'P';
        public const char Scissors = 'S';
        public const string Game_description = "--------2 players game--------\n" +
        "\n -Stone wins scissors\n -Scissors wins paper\n -Paper wins stone\n";
        public const string Select_value = "Choose R (Rock), S (Scissors) or P (Paper)";
        public const string Error_value = "\nYou entered an incorrect value, please try again\n";
        public const string Draw = "DRAW";
        public const string Player1_wins = "Player1_wins";
        public const string Player2_wins = "Player2_wins";


        public void print_characteristics() {
            Console.WriteLine(Game_description);
        }
        public char ask_for_values(){
            char key;

            Console.WriteLine(Select_value);
            key = Char.ToUpper(Console.ReadKey().KeyChar);

            while (key != Rock && key != Paper && key != Scissors) {
                Console.WriteLine(Error_value);
                key = Char.ToUpper(Console.ReadKey().KeyChar);
            }

            return key;
        }

        public void game(char player1, char player2) {
            switch (player1) {
                case Rock:
                    switch (player2) {
                        case Rock: Console.WriteLine(Draw);
                            break;
                        case Paper: Console.WriteLine(Player2_wins);
                            break;
                        case Scissors: Console.WriteLine(Player1_wins);
                            break;
                    }
                    break;
                case Paper:
                    switch (player2) {
                        case Rock:
                            Console.WriteLine(Player1_wins);
                            break;
                        case Paper:
                            Console.WriteLine(Draw);
                            break;
                        case Scissors:
                            Console.WriteLine(Player2_wins);
                            break;
                    }
                    break;
                case Scissors:
                    switch (player2) {
                        case Rock:
                            Console.WriteLine(Player2_wins);
                            break;
                        case Paper:
                            Console.WriteLine(Player1_wins);
                            break;
                        case Scissors:
                            Console.WriteLine(Draw);
                            break;
                    }
                    break;
            }
        }
        public void score() {
        int score_player1;
        int score_player2;



        Console.WriteLine();
        }
    }
}
