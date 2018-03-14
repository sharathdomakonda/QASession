using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrintOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the Odd numbers from 1 to 99");
            Console.WriteLine("Odd numbers between 1 and 99 are");

            int i;
           

            for(i=1;i<=100;i++)
            {
                if (i%2!=0)
                {
                    
                    Console.WriteLine(i);
                }
               
            }
            Console.ReadLine();
        }
    }
}
