using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class SumOfFact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int fact = 1;
            int sum = 0;
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine("Factorial: " + fact);
            Console.WriteLine("sum of all factorial: " + sum);

        }
    }
}
