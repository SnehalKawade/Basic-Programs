using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
   public class InheritanceDemo
    {
            public InheritanceDemo()
            {
                Console.WriteLine("Parent Constructor.");
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
    }
        public class ChildClass : InheritanceDemo
        {
            public ChildClass()
            {
                Console.WriteLine("Child Constructor.");
            }
            public static void Main()
            {
                ChildClass child = new ChildClass();
                child.print();
            }
        }
    
}
