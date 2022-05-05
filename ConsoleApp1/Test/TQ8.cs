using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class TQ8
	{
		//WAP to print following pattern. 
	  //          1
		//		2 2 2
		//	  3 3 3 3 3
		//	4 4 4 4 4 4 4

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i = i + 1)
			{
				for(int space=1;space<=(5-i);space++)
				{
					Console.Write(" ");
				}
				for(int j=1;j<=2*i-1;j++)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}
        }
    }
}
