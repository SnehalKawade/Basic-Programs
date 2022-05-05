using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    //Write a program to find whether give number is increasing,decreasing or bouncy.
    class BouncyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isIncrease = true;
            bool isDecrease = true;

            int next = n % 10;
            n = n / 10;
            while(n>0)
            {
                int prev = n % 10;
                if(prev>next)
                {
                    isIncrease = false;
                }
                if(prev<next)
                {
                    isDecrease = false;
                }
                n = n / 10;
                next = prev;
            }
            if(isDecrease && isIncrease)
                Console.WriteLine("All are equal");
            else if(isIncrease)
                Console.WriteLine("Increasing number ");
            else if(isDecrease)
                Console.WriteLine("Decreasing number");
            else
                Console.WriteLine("Bouncy number");

        }
    }
}
