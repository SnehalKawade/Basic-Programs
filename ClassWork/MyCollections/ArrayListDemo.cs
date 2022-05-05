using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassWork.MyCollections
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Welcome");
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);
            al.Add(01);
            al.Add("Snehal");
            al.Add("Kawade");
            al.Add(9175758844);
            al.Add("snehal@gmail.com");
            al.Add("Solapur");
            al.Add("sonu");

            al.Insert(3, "Vitthal");
            al.Remove("sonu");
            //al.RemoveAt(8);
            //al.Reverse();
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
           /* Console.WriteLine("***********");
            foreach(object i in al)
                Console.WriteLine(i);*/
           
                


        }
    }
}
