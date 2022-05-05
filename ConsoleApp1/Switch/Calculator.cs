using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Switch
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a choice");
            int ch = Convert.ToInt32(Console.ReadLine());

			switch (ch)
			{
				case 1:
					int result = n1 + n2;
					Console.WriteLine("Addition is= " + result);
					break;

				case 2:
					result = n1 - n2;
					Console.WriteLine("Subtraction is= " + result);
					break;

				case 3:
					result = n1 * n2;
					Console.WriteLine("Multiplication is= " + result);
					break;

				case 4:
					result = n1 / n2;
					Console.WriteLine("Division is= " + result);
					break;

				default:
					Console.WriteLine("Invalid choice");
					break;
			}


		}
	}
}
