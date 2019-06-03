using System;
using System.Collections.Generic;
using System.Text;
using StringsLibrary;
using RockPaperScissors;
using CharsLibrary;


namespace Body
{
    public class cBody {
        methods methods = new methods();

        public static void game(char pHandPlayer1, char pHandPlayer2)
        {
            

            char[,] array = new char[,] {{'D', 'P', 'R'/*, 'R', 'K'*/},
                                         {'P', 'D', 'S'/*, 'L', 'P'*/},
                                         {'R', 'S', 'D'/*, 'S', 'K'*/},
                                         /*{'R', 'L', 'S', 'D', 'L'},
                                         {'K', 'P', 'K', 'L', 'D'}*/};

            /*for (int row = 0; row > array.Length; row++) {
                for (int col = 0; col > array.Length; col++) {

                }
            }*/

            /*switch (pHandPlayer1)
            {
                case cCharsLibrary.Rock:
                    switch (pHandPlayer2)
                    {
                        case cCharsLibrary.Rock:
                            Console.WriteLine(cStringsLibrary.Draw);
                            break;
                        case cCharsLibrary.Paper:
                            Console.WriteLine(cStringsLibrary.Player2_wins);
                            vCountPlayer2++;
                            break;
                        case cCharsLibrary.Scissors:
                            Console.WriteLine(cStringsLibrary.Player1_wins);
                            vCountPlayer1++;
                            break;
                    }
                    break;
                case cCharsLibrary.Paper:
                    switch (pHandPlayer2)
                    {
                        case cCharsLibrary.Rock:
                            Console.WriteLine(cStringsLibrary.Player1_wins);
                            vCountPlayer1++;
                            break;
                        case cCharsLibrary.Paper:
                            Console.WriteLine(cStringsLibrary.Draw);
                            break;
                        case cCharsLibrary.Scissors:
                            Console.WriteLine(cStringsLibrary.Player2_wins);
                            vCountPlayer2++;
                            break;
                    }
                    break;
                case cCharsLibrary.Scissors:
                    switch (pHandPlayer2)
                    {
                        case cCharsLibrary.Rock:
                            Console.WriteLine(cStringsLibrary.Player2_wins);
                            vCountPlayer2++;
                            break;
                        case cCharsLibrary.Paper:
                            Console.WriteLine(cStringsLibrary.Player1_wins);
                            vCountPlayer1++;
                            break;
                        case cCharsLibrary.Scissors:
                            Console.WriteLine(cStringsLibrary.Draw);
                            break;
                    }
                    break;*/
        /*
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nPlayer1: " + vCountPlayer1 + " Player2: " + vCountPlayer2);
            Console.ForegroundColor = ConsoleColor.White;
        */
        }

        /*Rounds
        public void mRounds(uint pCurrentRound)
        {
            Console.WriteLine(cStringsLibrary.CurrentRound + pCurrentRound + " ----------");
            Console.WriteLine(cStringsLibrary.Player1_choose);
            player1 = methods.ask_for_values();
            Console.WriteLine(cStringsLibrary.Player2_choose);
            player2 = methods.ask_for_values();
            methods.game(player1, player2);
            Console.WriteLine();

            /*for (int i = 0; i < 10; i++) {
                Console.WriteLine(cStringsLibrary.CurrentRound + (i+1) + " ----------");
                Console.WriteLine("\nPlayer 1, please choose...");
                player1 = methods.ask_for_values();
                Console.WriteLine("\nPlayer 2, please choose...");
                player2 = methods.ask_for_values();
                methods.game(player1, player2);
                Console.WriteLine();
            }*///Simplifying the code above
            
        
    }
}
