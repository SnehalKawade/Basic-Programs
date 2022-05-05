using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class MockPgm
    {
        static void Main(string[] args)
        {

            int n = 85689;
            bool isIncrase= true;
            bool isDecrase= true;
            int next = n % 10;
            n = n / 10;
            while(n>0)
            {
                int prev = n % 10;
                if(prev>next)
                {
                    isIncrase = false;
                }
                if(prev<next)
                {
                    isDecrase = false;
                }
                n = n / 10;
                next = prev;
            }
            if(isIncrase)
            {
                Console.WriteLine("Increase number");
            }
            else if(isDecrase)
            {
                Console.WriteLine("Decrase number");
            }
            else
            {
                Console.WriteLine("Bouncy number");
            }
        }

    }
}
