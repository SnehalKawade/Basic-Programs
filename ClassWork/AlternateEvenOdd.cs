using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class AlternateEvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 77, 67, 45, 80, 9, 5, 22 };
            int[] b = new int[a.Length];
            int e = 0, o = 0;
            for(int i=0;i<a.Length;)
            {
                while(e<a.Length && a[e]%2==1)
                {
                    e++;
                }
                if (e < a.Length)
                {
                    b[i] = a[e];
                    i++;
                    e++;
                }

                while (o < a.Length && a[o] % 2 == 0)
                {
                    o++;
                }
                if (o < a.Length)
                {
                    b[i] = a[o];
                    i++;
                    o++;
                }
            }
            Array.ForEach(b, Console.WriteLine);
        }
    }
}
