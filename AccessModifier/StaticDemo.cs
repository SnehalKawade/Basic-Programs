using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class SCdemo
    {
        
        static int b;
        public SCdemo()
        {
       
            Console.WriteLine("in default constructor");
        }

        static SCdemo()
        {
           
            Console.WriteLine("in static constructor");
            b= 1234;
            Console.WriteLine(b);
               
        }
    }
    class StaticDemo
    {
        static void Main(string[] args)
        {
            SCdemo obj = new SCdemo();
                       
        }
    }
}
