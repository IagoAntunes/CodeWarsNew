using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Wholikesit
    {
        public static string Likes(string[] name)
        {

            string str = "";
            int count = name.Length;
            if (count == 0)
                str += "no one likes this";
            if (count == 1)
                str += name[0] + " likes this";
            if (count == 2)
            {
                str += name[0] + " and ";
                str += name[1] + " like this";
            }
            if (count == 3)
            {
                str += name[0] + ", ";
                str += name[1] + " and ";
                str += name[2] + " like this";
            }
            if (count >= 4)
            {
                str += name[0] + ", ";
                str += name[1] + " and " + (count - 2) + " others" + " like this";
            }

            return str;
        }
    }
}
/*
 *   public static string Likes(string[] names)
  {
    switch (names.Length)
    {
      case 0: return "no one likes this"; // :(
      case 1: return $"{names[0]} likes this";
      case 2: return $"{names[0]} and {names[1]} like this";
      case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
      default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
    }
  }
*/
