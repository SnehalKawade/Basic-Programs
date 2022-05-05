using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{

    //An IMEI number/ International Mobile Station Equipment Identity is a 15 digit number and
    //it is said to be IMEI number if and only if the sum of the number is exactly divisible by 10.
    class TQ12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            long a = Convert.ToInt64(Console.ReadLine());
            long n = a;
            int c = 0;
            while(a>0)
            {
                c++;
                a = a / 10;
            }
            a = n;
            if(c==15)
            {
                int sum = 0;
                for(int i=1;i<=15;i++)
                {
                    int digit = (int)(a % 10);
                    if (i % 2 == 0)
                    {
                        int doubleup = 2 * digit;
                        if (doubleup > 9)
                            sum = sum + doubleup % 10 + doubleup / 10;
                        else
                            sum = sum + doubleup;
                    }
                    else
                        sum = sum + digit;

                    a = a / 10;
                }
                if(sum%10==0)
                    Console.WriteLine("Valid IMEI number");
                else
                    Console.WriteLine("Invalid IMEI number");
            }
            else
            {
                Console.WriteLine("Not a 15 digit number");
            }
        }
    }
}
