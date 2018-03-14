using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicationofthreenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of three numbers");
            Console.WriteLine("Enter the first number");
            string N1 = Console.ReadLine();
            int newN1 = Convert.ToInt32(N1);

            Console.WriteLine("Enter the second number");
            string N2 = Console.ReadLine();
            int newN2 = Convert.ToInt32(N2);

            Console.WriteLine("Enter the third number");
            string N3 = Console.ReadLine();
            int newN3 = Convert.ToInt32(N3);

            int Multiplication = newN1 * newN2 * newN3;


            Console.WriteLine("The Multiplication of three numbers is " + Multiplication);
            Console.ReadLine();
        }
    }
}
