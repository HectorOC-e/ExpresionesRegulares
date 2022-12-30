using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main()
        {
            string frase = "Mi web es https://www.pildorasinformaticas.es";
            Console.WriteLine();

            string pattern = "(https?://)?(www.)?pildorasinformaticas.es";

            Regex miRegex = new Regex(pattern);

            MatchCollection matchCollection= miRegex.Matches(frase);

            if (matchCollection.Count > 0) Console.WriteLine("Se ha encontrado una web");
            else Console.WriteLine("No se ha encontrado una web");

            
            
        }
    }
}
