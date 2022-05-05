using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork.CollectionAssignment
{
    /*1.Assume you have Arraylist al = new ArrayList();
         al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
      Write a code to remove duplicate elements from above list.
      Final Arraylist should contain (Sun, Mon, Sat); */

    class ArraylistDuplicates
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            /*
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }*/

            foreach (object i in al)
                Console.WriteLine(i);

            //Remove duplicate from arraylist
            for (int i=0; i<al.Count;i++)
            {
                for(int j = i+1;j<al.Count;j++)
                {
                    if (al[i].ToString() == al[j].ToString())
                    {
                        al.Remove(al[j]);
                       
                    }          
                }
            }
            
            Console.WriteLine("*************************************");
            foreach (object i in al)
                Console.WriteLine(i);

        }
    }
}
