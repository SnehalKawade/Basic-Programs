using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.StringAss
{
    class StringSort
    {
        static void Main(string[] args)
        {
            string[] name = { "om", "ajay", "tiya", "priya" };
            foreach (string value in name)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Array.Sort(name);//sorting
            
            Console.WriteLine("\nSorted....");
            foreach (string value in name)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
