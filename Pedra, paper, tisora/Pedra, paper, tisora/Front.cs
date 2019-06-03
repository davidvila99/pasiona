using System;
using System.Collections.Generic;
using System.Text;
using StringsLibrary;
using CharsLibrary;

namespace Frontend
{
    class cFront {

        public static void print_characteristics()
        {
            Console.WriteLine(cStringsLibrary.Game_description);
        }
        public static char ask_for_values()
        {
            char key;

            Console.WriteLine(cStringsLibrary.Select_value);
            key = Char.ToUpper(Console.ReadKey().KeyChar);

            while (key != cCharsLibrary.Rock && key != cCharsLibrary.Paper && key != cCharsLibrary.Scissors)
            {
                Console.WriteLine(cStringsLibrary.Error_value);
                key = Char.ToUpper(Console.ReadKey().KeyChar);
            }
            return key;
        }
    }
}
