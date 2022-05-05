using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //Find occurrences of each char element from the char array.
    class CountCharArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            while (str.Length > 0)
            {
                Console.Write(str[0] + "=");
                int c = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        c++;
                    }
                }
                Console.WriteLine(c);
                str = str.Replace(str[0].ToString(), string.Empty);
            }

            Console.WriteLine();

        }
    }
}
