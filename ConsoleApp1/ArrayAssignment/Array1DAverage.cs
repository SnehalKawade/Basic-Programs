using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    class Array1DAverage
    {
        //2.WAP to accept the dimension of the 1D array and create and accept data in that array.
          //  Calculate the average value of array elements.
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 20, 30, 25, 35, -16, 60, -100 };
            //calculate sum of all array elements
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum = sum + numbers[i];
            //calculate average value
            double average = sum / numbers.Length;
            Console.WriteLine("Average value of the array elements is : " + average);
        }
    }
}
