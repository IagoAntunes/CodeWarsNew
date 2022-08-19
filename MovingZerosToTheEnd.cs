using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> vetor = arr.ToList();
            var listaZero = vetor.FindAll(x => x.Equals(0));
            vetor.RemoveAll(x => x.Equals(0));
            for (int i = 0; i < listaZero.Count; i++)
                vetor.Add(0);

            return vetor.ToArray();
        }
    }
}
