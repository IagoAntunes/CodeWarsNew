using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            foreach (var letra in str)
                if (Regex.IsMatch(letra.ToString(), "[aeiou]"))
                    vowelCount++;

            return vowelCount;
        }


    }
}
