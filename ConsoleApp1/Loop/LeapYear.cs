using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if((year%4==0) && (year%100==0) && (year%400==0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }

            /*if (year % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if(year%400==0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }*/
        }
    }
}
