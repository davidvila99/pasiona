using System;
using RockPaperScissors;
using StringsLibrary;
using Body;
using Backend;
using Frontend;


namespace RockPaperScissors
{
    class Program
    {
        public static Player player1 = new Player();
        public static Player player2 = new Player();
        static void mMain(string[] args)
        {
            mPlay();
        }
        private static void mPlay() {

            player1.pName = Console.ReadLine();
            player2.pName = Console.ReadLine();

            cFront.print_characteristics();
            player1.pHand = cFront.ask_for_values();
            player2.pHand = cFront.ask_for_values();


            cBody.game(player1.pHand,player2.pHand);
            
        }
    }
}