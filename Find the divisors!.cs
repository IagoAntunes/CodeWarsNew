using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Find_the_divisors_
    {
        public static int[] Divisors()
        {
            string aux = "";
            int n = 12;
            int count= 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0 && i != 1)
                {
                    aux += i + ";";
                    count++;
                }
            if (count == 0)
                return null;

            var vetor2 = aux.Substring(0, aux.Length - 1).Split(';');
 
            return Array.ConvertAll(vetor2, int.Parse);



        }

    }
}
