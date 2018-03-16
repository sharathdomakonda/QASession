using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TriangleFormation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To verify whether the given angles can form a  triangle");

            Console.WriteLine("Enter the angles of a triangle");

            int angle1 = Convert.ToInt32(Console.ReadLine());
            int angle2 = Convert.ToInt32(Console.ReadLine());
            int angle3 = Convert.ToInt32(Console.ReadLine());

            if (angle1+angle2+angle3==180)

            {
                Console.WriteLine("The given angles form a triangle");
            }

            else
            {
                Console.WriteLine("The given angles do not form a triangle");
            }

            Console.ReadLine();
        }


    }
}
