using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program for calcualting Area of Circle
namespace _1.DemoProgramAreaofaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculate area of a circle");
            double pi = 3.14;
            Console.WriteLine("Please enter the radius value");
            string a = Console.ReadLine();
            int r = Convert.ToInt32(a);
            double area = pi * r * r;
            Console.WriteLine("Area of a circle"+area);
            Console.ReadLine();
        }
    }
}
