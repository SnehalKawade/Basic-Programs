using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter ur age");
            int age = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter ur salary");
            // float s = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter ur gender");
            char g = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.WriteLine("Enter ur mobile no");
            long m = Convert.ToInt64(Console.ReadLine());
            
        }
    }
}
