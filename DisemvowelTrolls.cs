using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            List<string> ListVowels = new List<string>() { "a", "e", "i", "o", "u" };
            string newPhrase = "";
            foreach (var letter in str)
            {
                if (!ListVowels.Contains(letter.ToString().ToLower()))
                {
                    newPhrase += letter;
                }
            }
            str = newPhrase;
            return str;
        }
    }
}
