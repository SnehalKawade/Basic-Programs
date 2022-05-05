using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class BreakStat
    {
        static void Main(string[] args)
        {
			int i;
			for (i = 1; i <= 10; i++)
			{
				if (i == 5)
				{
					break; ;
				}
				Console.WriteLine(i);
			}
		}
    }
}
