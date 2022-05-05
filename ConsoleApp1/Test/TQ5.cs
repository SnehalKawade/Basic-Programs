using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
	//Write a program to print number from 1 to 100 such that when a number is factor of 3 and 5 both print
	//“RedBlue”  and if given number is factor of only 3 the print “red” and if given number is factor of only
	//5 then “blue” 
	class TQ5
    {
        static void Main(string[] args)
        {
           
			Console.WriteLine("\nDivided by 3: ");
            for (int i = 1; i < 100; i++)
			{
				if (i % 3 == 0)
					Console.WriteLine("Red");
			}

			Console.WriteLine("\n\nDivided by 5: ");
			for (int i = 1; i < 100; i++)
			{
				if (i % 5 == 0)
					Console.WriteLine("Blue");
			}

			Console.WriteLine("\n\nDivided by 3 & 5: ");
			for (int i = 1; i < 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
					Console.WriteLine("RedBlue");
			}
			Console.WriteLine("\n");
		}
    }
}
