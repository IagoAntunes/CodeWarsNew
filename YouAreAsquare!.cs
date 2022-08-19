using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class YouAreAsquare_
    {
        public static bool IsSquare(int n)
        {
            double number = Math.Pow(n, 0.5);
            if (number % 1 == 0)
                return true;
            else
                return false;
        }
    }
}
