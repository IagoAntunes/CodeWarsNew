using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class BreakcamelCase
    {
        public static string BreakCamelCase(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    newstr += " ";
                newstr += str[i];
            }
            return newstr;
        }
    }
}
