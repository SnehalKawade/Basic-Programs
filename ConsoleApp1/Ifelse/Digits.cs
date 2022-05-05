using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.IfElse
{
    class Digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number/charater");
            char ch = Convert.ToChar(Console.Read());
			if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
			{
				Console.WriteLine("Alphabets");
			}
			else if (ch >= '1' && ch <= '9')
			{
				Console.WriteLine("Digits");
			}
			else
			{
				Console.WriteLine("Special symbols");
			}
		}
    }
}
