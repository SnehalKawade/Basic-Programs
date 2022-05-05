using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class BaseExpo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the exponent");
            int e = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            while(e>0)
            {
                power = power * b;
                e--;

            }
            Console.WriteLine(power);
        }
    }
}
