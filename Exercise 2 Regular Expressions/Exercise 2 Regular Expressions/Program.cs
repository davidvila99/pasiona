using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Exercise_2_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string texto = client.DownloadString("http://trifulcas.com/wp-content/uploads/2019/09/testra.txt");
                string patron = "[0-9]{8}[A-Z]{1}";
                MatchCollection matches = Regex.Matches(texto, patron,
                  RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

                WriteMatches(texto, matches);

                string patronMatricula= "[0-9]{4}[A-Z]{3}";
                MatchCollection matchesMatricula = Regex.Matches(texto, patronMatricula,
                  RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

                WriteMatches(texto, matchesMatricula);
            }

            void WriteMatches(string texto, MatchCollection matches)
            {
                Console.WriteLine("Apariciones encontradas: " + matches.Count);
                foreach (Match m in matches)
                {
                    int index = m.Index;
                    string result = m.ToString();
                    int charsBefore = (index < 5) ? index : 5;
                    int fromEnd = texto.Length - index - result.Length;
                    int charsAfter = (fromEnd < 5) ? fromEnd : 5;
                    int charsToDisplay = charsBefore + charsAfter + result.Length;
                    Console.WriteLine($"Posición: {index} | \tValor: {m.Value}\t | {texto.Substring(index - charsBefore, charsToDisplay)}");
                }
            }
        }
    }
}
