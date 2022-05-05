using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.ProrigoPgm
{
    //Given the second and the third terms of an AP(-10^6<=a2,a3<=10^6).find the nth(1<=n<=1000) term of the sequence.
    class AirthmeticProgression
    {
        static void Main(string[] args)
        {
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int diff = a3 - a2;

            for (int i = 3; i < n; i++)
            {
                a3 = a3 + diff;
            }
            Console.WriteLine(a3);
        }
    }
}
