using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork.CollectionAssignment
{
    //2.Sort Arraylist of String in reverse order of its natural sorting.
    class ReverseArraylist
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Thu");
            al.Add("Tue");
            al.Add("Wen");
            al.Add("Mon");
            al.Add("Fir");
            Console.WriteLine("Before Arraylist........."); 
            foreach (object i in al)
                Console.Write(i+" ");
            Console.WriteLine();

            Console.WriteLine("Sorting..........");
            al.Sort();

            foreach (object i in al)
                Console.Write(i + " ");

            al.Reverse();
            Console.WriteLine();

            Console.WriteLine("Reserve...........");

            foreach (object i in al)
                Console.Write(i+" ");

        }
    }
}
