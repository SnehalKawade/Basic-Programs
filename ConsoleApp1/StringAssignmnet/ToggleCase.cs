using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    class ToggleCase
    {
        static void Main(string[] args)
        {
            int c;
            String str;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    Console.Write((char)(str[i] + 32));
                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    Console.Write((char)(str[i] - 32));
                }
            }
        }
    }
}
