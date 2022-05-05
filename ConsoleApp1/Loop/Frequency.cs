using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class Frequency
    {
        static void Main(string[] args)
        {
            int number, i, count, digit, temp;
            Console.WriteLine("Enter a digits");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digit\tFrequency");
            for (i = 0; i <= 9; i++)
            {
                count = 0;
                temp = number;
                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine(i + "\t" + count);
                }
            }

        }
    }
}
