using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class OddNo
    {
        static void Main(string[] args)
        {
			int i = 521;
			while (i >= 229)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}

				i--;
			}
		}
    }
}
