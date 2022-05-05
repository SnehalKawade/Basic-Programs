using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class sample
    {
        static void Main(string[] args)
        {
            int rem = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            int  oddcou = 0;
            while (num > 0)
            {
                rem = num % 10;
                if (rem % 2 == 0)
                    oddcou++;
                
                num = num / 10;
            }
            if (oddcou == 0)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            }
        }
    }
}
