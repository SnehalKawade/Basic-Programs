using System;
using System.Collections.Generic;
using System.Text;
using P1;

namespace HomeWork.Loop
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            char c;
            for (c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }

            AA a1 = new AA();
            a1.M1();
        }
    }
}
