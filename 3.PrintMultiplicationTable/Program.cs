using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrintMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the Multiplication table of a number");
            Console.WriteLine("Enter the number whose multiplication table is to be printed");
            String Number = Console.ReadLine();
            int N1 = Convert.ToInt32(Number);
            int i;

            for (i = 0; i <= 10; i++)
            {
                int Multiplicationtable = N1 * i;
                Console.WriteLine( N1+" * "+ i +" = " +Multiplicationtable);
                
            }
            Console.ReadLine();



        }
    }
}
