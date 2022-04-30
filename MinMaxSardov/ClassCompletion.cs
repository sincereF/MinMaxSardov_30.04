using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSardov
{
    public class ClassCompletion
    {
        public int ResTest(int x)
        {
            int[] mas = new int[x];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(4, 4);
                x = mas[i];
            }
            return x;
        }
    }
}
