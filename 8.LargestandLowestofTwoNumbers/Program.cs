using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.LargestandLowestofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show Largest and Lowest of Two numbers");

            Console.WriteLine("Enter first number");
            String Numberone = Console.ReadLine();
            int N1 = Convert.ToInt32(Numberone);

            Console.WriteLine("Enter second number");
            String Numbertwo = Console.ReadLine();
            int N2 = Convert.ToInt32(Numbertwo);

            Console.WriteLine("Enter Third number");
            String Numberthree = Console.ReadLine();
            int N3 = Convert.ToInt32(Numberthree);

               int greater;
            int Lowest;

            if (N1 > N2)
            {
                greater = N1;
                Lowest = N2;
            }
            else
            {
                greater = N2;
                Lowest = N1;
            }

            if (greater>N3)
            {
                Console.WriteLine("The Largest of three numbers is " + greater);

            }

            else
            {
                Console.WriteLine("The Largest of three numbers is " + N3);
            }

            if (Lowest<N3)
            {
                Console.WriteLine("The Lowest of three numbers is " + Lowest);

            }

            else
            {
                Console.WriteLine("The Lowest of three numbers is " + N3);
            }
            Console.ReadLine();
        }
    }
}
