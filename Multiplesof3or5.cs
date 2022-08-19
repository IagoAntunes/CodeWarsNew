using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Multiplesof3or5
    {
        //Multiples of 3 or 5
        public static int Solution(int value)
        {
            if (value != 0)
            {
                int sum = 0;
                for (int i = 0; i < value; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                        sum += i;
                }
                return sum;
            }

            return 0;
        }
    }
}
