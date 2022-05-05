using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
	//WAP to draw the following pattern using . Note: Input is an odd number: 
							/*		12345
									ABCD
									123
									AB
									1
									AB
									123
									ABCD
									12345
							*/
	class TQ13
	{
        static void Main(string[] args)
        {
			for (int i = 5; i > 1; i--)
			{
				char k = 'A';
				for (int j = 1; j <= i; j++)
				{
					if (i % 2 != 0)
					{
						Console.Write(j);
					}
					else
					{
						Console.Write(k);
						k++;
					}
				}
                Console.WriteLine();
			}
			for (int i = 1; i <= 5; i++)
			{
				char k = 'A';
				for (int j = 1; j <= i; j++)
				{
					if (i % 2 != 0)
					{
						Console.Write(j);
					}
					else
					{
						Console.Write(k);
						k++;
					}
				}
                Console.WriteLine();
			}

		}
	}
}
