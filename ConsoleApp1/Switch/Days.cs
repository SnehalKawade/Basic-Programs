using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Switch
{
    class Days
    {
        static void Main(string[] args)
        {
			
            Console.WriteLine("Enter Weekdays number");
			int weekday = Convert.ToInt32(Console.ReadLine());
			if (weekday == 1)
			{
                Console.WriteLine("Sunday");
			}
			else if (weekday == 2)
			{
                Console.WriteLine("Monday");
			}
			else if (weekday == 3)
			{
				Console.WriteLine("Tuesday");
			}
			else if (weekday == 4)
			{
				Console.WriteLine("Wednesday");
			}
			else if (weekday == 5)
			{
				Console.WriteLine("Thursday");
			}
			else if (weekday == 6)
			{
				Console.WriteLine("Friday");
			}
			else if (weekday == 7)
			{
				Console.WriteLine("Staurday");
			}
			else
			{
				Console.WriteLine("Invalid");
			}

		}
	}
}
