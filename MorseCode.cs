using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    public class MorseCode : MorseDictionary
    {
        
        
       public static string ConvertToMorseCode(string text)
        {
            
            string result = "";
            foreach (char c in text)
            {
                if (morseCodeDict.TryGetValue(c, out string morseCode))
                    result += morseCode + " ";
                else if (c == ' ')
                    result += "/ ";
            }
            return result.Trim();
        }
    }
}
