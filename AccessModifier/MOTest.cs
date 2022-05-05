using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Parent
    {
        public virtual void Study()
        {
            Console.WriteLine("study by reading books");
        }
    }
        class Child : Parent
        {
            public override void Study()
            {
                Console.WriteLine("learning from online videos");
            }
        }
   
        class MOTest
        {
            static void Main(string[] args)
            {
                Parent p1 = new Child();
                p1.Study();
                Console.WriteLine("************");
                Parent p2 = new Parent();
                p2.Study();

            }
        }
}
