using System;

namespace stone_paper_scissors
{
    public class methods {
        public const char Rock = 'R';
        public const char Paper = 'P';
        public const char Scissors = 'S';
        public const string game_description = "2 players game\n" +
        "-Stone wins scissors\n-Scissors wins paper\nPaper wins stone";
        public const string select_value = "Choose R (Rock), S (Scissors) or P (Paper)";
        public const 
        public void print_characteristics() {
            Console.WriteLine();
        }
        public char ask_for_values(){
            char key;

            Console.WriteLine("Choose R (Rock), S (Scissors) or P (Paper)");
            key = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.Clear();

            return key;
        }
        public void winner() {
        }
        private void print_winner() {
            Console.WriteLine("Choose S (Stone), S (Scissors) or P (Paper)");
        }
    }
}
