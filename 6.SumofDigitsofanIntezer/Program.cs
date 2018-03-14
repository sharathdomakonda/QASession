using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumofDigitsofanIntezer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of digits of an intezer");
                       int[] intezer;
            intezer = new int[3] {1,2,3};
            Console.WriteLine("The sum of the entered intezer is " + (intezer[0] + intezer[1] + intezer[2]));
            Console.ReadLine();
            
        }
    }
}
