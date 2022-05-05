using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class PalindromeOrNot
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter the number");
			int num = Convert.ToInt32(Console.ReadLine());
			
			int rev = 0;
			int n1 = num;
			while (num > 0)
			{
				int r = num % 10;
				rev = rev * 10 + r;
				num = num / 10;
			}
			Console.WriteLine(rev);
			num = n1;
			if (num == rev)
			{
				Console.WriteLine("Palindrome");
			}
			else
			{
				Console.WriteLine("Not Palindrome");
			}

		}
	}
}
