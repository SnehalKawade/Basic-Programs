using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //12.Write a program to find highest frequency character in a string.
    class HightestFreqString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            int[] freq = new int[str.Length];
            char maxchar = str[0];
            int i, j,max;

            char[] str1= str.ToCharArray(); //converting given string into character array

            //count each word in given string and store in array freq
            for(i=0;i<str1.Length;i++)
            {
                freq[i] = 1;
                for(j=i+1;j<str1.Length;j++)
                {
                    if(str1[i]==str1[j] && str1[i]!=' ' && str1[i]!='0')
                    {
                        freq[i]++;
                        str1[j] = '0'; //set str1[j] to 0 to avoid printing visited character
                    }
                }
            }

            max = freq[0]; //determin maximum occurring characters

            for(i=0;i<freq.Length;i++)
            {
                //if max is less than frequency of a character
                if (max<freq[i]) // then, store frequency in max & corresponding character in maxchar 
                {
                    max = freq[i];
                    maxchar = str1[i];
                }
            }
            Console.WriteLine("Highest Frequency of Character: "+maxchar);
        }
    }
}
