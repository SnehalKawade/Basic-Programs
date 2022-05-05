using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.ProrigoPgm
{
    //A cuckoo sequence is defined as showns.
    //Cuckoo[1]=0
    //Cuckoo[2]=1
    //Cuuckoo[n]=1*Cuckoo[n-1]+2*Cuckoo[n-2]+3*1,for n>2
    class CuckooSequence
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {
            CuckooSequence ck = new CuckooSequence();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            //int cu1 = 0;
           // int cu2 = 1;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");

            }
            else if (n > 2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }

    
           
            /*int n = Convert.ToInt32(Console.ReadLine());
            int[] cuckoo = new int[n + 1];
            cuckoo[0] = 0;
            cuckoo[1] = 1;
            cuckoo[2] = 1;
            int a = 1, b = 1;
            int sum = 0;
            for (int i = 3; i < n + 1; ++i)
            {
                sum = a + b;
                a = b;
                b = sum;
                cuckoo[i] = sum;
            }
            int ans = 0;
            n = n + 1;
            for (int i = 1; i < n - 1; i++)
            {
                ans += i * cuckoo[n - i];
            }
            Console.WriteLine(ans);*/


        }
    }
}
