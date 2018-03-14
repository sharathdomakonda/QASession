using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1CalculateAvgofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of elements of an array");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            int i;
            int sum=0 ;

          
            for(i=0;i<arraySize;i++)
            {
                Console.WriteLine("Enter the Number " + i);
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
                sum = sum + array[i];

            }

            float average = (float)sum / arraySize;
            Console.WriteLine("The average of elements of an array is " + average);
            Console.ReadLine();
        }
    }
}
