using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    public class Text : MorseDictionary
    {
       public static string ConvertToText(string morseCode)
        {
            string[] words = morseCode.Split('/');
            string result = "";
            foreach (string word in words)
            {
                string[] letters = word.Trim().Split(' ');
                foreach (string letter in letters)
                {
                    foreach (var pair in morseCodeDict)
                    {
                        if (pair.Value == letter)
                        {
                            result += pair.Key;
                            break;
                        }
                    }
                }
                result += " ";
            }
            return result.Trim();
        }
    }
}
