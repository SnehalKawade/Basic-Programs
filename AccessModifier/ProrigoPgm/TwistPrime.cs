using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.ProrigoPgm
{
    //given an interger n(1<=n<=10^4),you need to count the numbers,xi<n,which are co-prime to 'n',i.e gcd(x,n)=1.
    class TwistPrime
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (n % divisor == 0 && i % divisor == 0)
                        gcd = divisor;
                }

                if (gcd == 1)
                    c++;
            }
            Console.WriteLine(c);
        }
    }
}
