using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
        class SealedDemo
        {
            private protected int X; //accessible in subclass cuurently assembly
            protected internal int Y; //accessible in current assembly, and in subclass of other assembly.
            public virtual void Play()
            {
                Console.WriteLine("Play in ground");
            }
            internal virtual void Study()
            {
                Console.WriteLine("In library");
            }
            static internal void M1()
            {
                Console.WriteLine("In static");
            }
        /*  static virtual internal void M3() //can't override static method.override associated with object and static is object independant.
          {
              Console.WriteLine("In Static");
          }          

          sealed internal void Study()//can't write sealed keyword because it is not override.
          {
              Console.WriteLine("In Book");
          }
          sealed static internal void M1()// can't write sealed keyword beause it is not override. static cannot be overriden.
          {
              Console.WriteLine("In static");
          }*/
        private protected void M7()
            {
                Console.WriteLine("private protected method");
            }
    }

}
