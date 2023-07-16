using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            



            start:
            Console.WriteLine("1 - Translate text to Morse code\n2 - Convert Morse code to text");
            string choice = Console.ReadLine();

            Console.Clear();

            if (choice == "1")
            {
                
                Console.Write("Enter text: ");
                string text = Console.ReadLine().ToUpper();
                string morseCode = MorseCode.ConvertToMorseCode(text);
                Console.WriteLine("Mors Code: " + morseCode);
            }



            else if (choice == "2")
            {
                Console.Write("Enter the morse code:");
                string morseCode = Console.ReadLine();
                string text = Text.ConvertToText(morseCode);
                Console.WriteLine("Metin: " + text);
            }

            else
            {
                Console.WriteLine("Invalid option!");
                goto start;
            }

            Console.WriteLine("Would you like to continue the translation? Yes/No");
            string choose = Console.ReadLine().ToLower();

            Console.Clear();

            if (choose == "yes")
            {
                goto start;
            }
            else
            {
                Environment.Exit(0);
            }
            Console.Clear();

            Console.ReadKey();
        }
    }
}
