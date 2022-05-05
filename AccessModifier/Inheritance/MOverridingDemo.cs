using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
    class parent
    {
        public void Study1()
        {
            Console.WriteLine("I Am Parent Method");
        }

    }

    class child : parent
    {
        public void Study1()
        {
            Console.WriteLine("I Am Child Method");
        }
    }

    class MOverridingDemo
    {
        static void Main(string[] args)
        {
            child p = new child();
            p.Study1();
        }
    }
}
