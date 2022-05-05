using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.StringAss
{
    class StartTrimString
    {
        static void Main(string[] args)
        {
            // Trim Whitespaces
            string str1 = "  Welcome programming  ";

            Console.WriteLine("Before Trim: {0}",str1);
            Console.WriteLine("After Trim: {0}",str1.TrimStart());

            Console.ReadLine();
        }
    }
}
