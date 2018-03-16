using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To find whether an year is leap year or not");
            Console.WriteLine("Enter the year");

            int year=Convert.ToInt32(Console.ReadLine());

            if ((year % 100 == 0 && year % 400 == 0) || year % 4 == 0)
            {
                Console.WriteLine("The year is a leap year");
            }


            else 
            {
                Console.WriteLine("The year is not a leap year");
            }

            

            Console.ReadLine();
        }
    }
}
