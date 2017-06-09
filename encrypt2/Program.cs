using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii_encryptie
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'A';
            int shift = 3;

            int cijferAscii = letter;

            Console.WriteLine("De letter " + letter + " heeft de Ascii waarde: " + cijferAscii);
            Console.WriteLine("___________________________________________________");
            
            int getal = 100;
            char ch = Convert.ToChar(getal);

         
            Console.WriteLine(shiftLetter(letter, shift));

            Console.Read();
        }
        static int GetAsciiInt(char letter)
        {
            return letter;
        }
        static char GetCharFromAscii(int letter)
        {
            return Convert.ToChar(letter);
        }
        static char shiftLetter(char begin, int shift)
        {
            return GetCharFromAscii(begin + shift);
        }
        static char shiftLetterN(char begin, int shift)
        {
            return GetCharFromAscii(begin - shift);
        }
    }
}
