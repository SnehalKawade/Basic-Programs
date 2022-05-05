using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
    class Inherit
    {
        public void Sum()
        {
            Console.WriteLine("Welcome to Inheritance");
        }
    }
    class InheritanceDemo:Inherit
    {
        static void Main(string[] args)
        {
            Inherit i1 = new Inherit();
            i1.Sum();      
        }
    }
}
