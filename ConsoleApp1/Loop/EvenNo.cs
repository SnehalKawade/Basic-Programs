using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class EvenNo
    {
        static void Main(string[] args)
        {
			int i;

			for (i = 121; i <= 229; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}

			}
		}
    }
}
