using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class GcdLcm
    {
        static void Main(string[] args)
        {
            int a, b, t, aTemp, bTemp, lcm, gcd;
            
            Console.WriteLine("Enter Two Number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            aTemp = a;
            bTemp = b;

            while (bTemp != 0)
            {
                t = bTemp;
                bTemp = aTemp % bTemp;
                aTemp = t;
            }

            gcd = aTemp;

            /*
             * GCD(a, b) * LCM(a, b) = a*b
             */
            lcm = (a * b) / gcd;
            Console.WriteLine("LCM = " + lcm);
            Console.WriteLine("GCD = " + gcd);

        }
    }
}
