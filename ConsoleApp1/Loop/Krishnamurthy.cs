using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any number:");
            n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int sum = 0;
            while (n != 0)
            {
                int d = n % 10;
                int fact = 1;
                for (int i = 1; i <= d; i++)
                    fact = fact * i;
                sum = sum + fact;
                n = n / 10;
            }
            if (sum == m)
                Console.WriteLine("Krishnamurthy number");
          else
                Console.WriteLine("Not Krishnamurthy");

        }
    }
}
