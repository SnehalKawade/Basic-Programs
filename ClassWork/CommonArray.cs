using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class CommonArray
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] a2 = { 2, 3, 90, 89, 90, 9, 2 };
            foreach (int d1 in a1)
            {
                foreach(int d2 in a2)
                {
                    if(d1==d2)
                        Console.WriteLine(d1);
                }
            }
        }
    }
}
