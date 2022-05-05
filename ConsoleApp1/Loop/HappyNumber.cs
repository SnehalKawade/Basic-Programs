using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Loop
{
    //Write a program to find whether give number is Happy number or not
    class HappyNumber
    {
        static void Main(string[] args)
        {
            int rem = 0;
            Console.WriteLine("Enter the number to check whether it is happy or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int evencou = 0, oddcou = 0;
            while (num > 0)
            {
                rem = num % 10;
                if (rem % 2 == 0)
                    evencou++;
                else
                    oddcou++;
                num = num / 10;
            }
            if (evencou == 1)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            }

            /* Write a program to find whether give number is Happy number or not
            while (num > 0)
            {
                rem = num % 10;
                if (rem % 2!= 1)
                    oddcou++;
                else
                    evencou++;
                num = num / 10;
            }
            if (oddcou == 0)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            } */
        }
    }
}
