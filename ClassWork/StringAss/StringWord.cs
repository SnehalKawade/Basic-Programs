using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.StringAss
{
    class StringWord
    {
        static int MAX_CHAR = 256;

        static bool isPresent(string s, string q)
        {

            int[] freq = new int[MAX_CHAR];

            for (int i = 0; i < s.Length; i++)
                freq[s[i]]++;

            for (int i = 0; i < q.Length; i++)
            {
                freq[q[i]]--;

                if (freq[q[i]] < 0)
                    return false;
            }

            return true;
        }

      
        static public void Main()
        {
            string s = "Snehal";
            string q = "neha";

            if (isPresent(s, q))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
       
    }
}
