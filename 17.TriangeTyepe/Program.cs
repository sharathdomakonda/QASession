using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.TriangeTyepe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To verify the type of a triangle");

            Console.WriteLine("Enter the lengths of a triangle");

            int length1 = Convert.ToInt32(Console.ReadLine());
            int length2= Convert.ToInt32(Console.ReadLine());
            int length3 = Convert.ToInt32(Console.ReadLine());

            if(length1==length2 && length2==length3)
            {
                Console.WriteLine("The triangle is an Equilateral triangle");
            }
            else if(length1 != length2 && length2 != length3 &&length1!=length2)
            {
                Console.WriteLine("The triangle is an Scalene triangle");

            }
            else
            {
                Console.WriteLine("The triangle is an Isosceles triangle");
            }
            Console.ReadLine();
        }
    }
}
