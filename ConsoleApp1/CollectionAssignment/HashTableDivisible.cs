using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork.CollectionAssignment
{
    class HashTableDivisible
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"One");
            ht.Add(2,"Two");
            ht.Add(3,"Three");
            ht.Add(4,"Four");
            ht.Add(5,"Five");
            ht.Add(6,"Six");
            ht.Add(7,"Seven");
            ht.Add(8,"Eight");
            ht.Add(9,"Nine");
            ht.Add(10,"Ten");

            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine(e.Key + "->" + e.Value);
            }
            
        }
    }
}
