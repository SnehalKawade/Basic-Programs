using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            
            Console.WriteLine("Enter a element");
            for(int i=0;i<size;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse Array: ");
            for (int i = size-1 ; i >= 0; i--)
            {
                
                Console.WriteLine($"a[{i}]={a[i]}");
                
            }
            
           
        }
    }
}
