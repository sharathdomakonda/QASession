using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ArraycontainsOddnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if array contains odd number ");
            int[] array;
            array = new int[5] { 2, 4, 7, 8, 6 };


            for (int i = 0; i<5; i++)
            {
                if (array[i] % 2 != 0)

                    Console.WriteLine("True");
                
            }

            Console.ReadLine();
        }
    }
}
