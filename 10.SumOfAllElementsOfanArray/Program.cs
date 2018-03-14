using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumOfAllElementsOfanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO PRINT SUM OF ARRAY ELEMENTS ENTERED BY USER");
            Console.WriteLine("ENTER SIZE OF ARRAY");
            string sizeOfArray = Console.ReadLine();
            int arraySize = Convert.ToInt32(sizeOfArray);

            int[] arrayMemory = new int[arraySize];



            int i;
            int sum = 0;
            string newelementsOfArray;
            int elementsOfArray;


            for (i = 0; i < arraySize; i++)
            {
                Console.WriteLine("ENTER ELEMENT NUMBER " + i);
                newelementsOfArray = Console.ReadLine();
                elementsOfArray = Convert.ToInt32(newelementsOfArray);
                sum = sum + elementsOfArray;

            }
            Console.WriteLine("The sum of Array elements is " + sum);
            Console.ReadLine();
        }

        }
    }




