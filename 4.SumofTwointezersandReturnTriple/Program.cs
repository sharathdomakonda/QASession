using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SumofTwointezersandReturnTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sum of Two Intezers");

            Console.WriteLine("Enter the First Number");
            String Num1 = Console.ReadLine();
            int N1 = Convert.ToInt32(Num1);

            Console.WriteLine("Enter the Second Number");
            String Num2 = Console.ReadLine();
            int N2 = Convert.ToInt32(Num2);

            int N3 = N1 + N2;

            if (N1 != N2)
            {
                Console.WriteLine("The addition of two intezers is " + N3);
            }

            else
            {
                Console.WriteLine("As the entered values are equal the triple of addition of two intezers is " + 3 * N3);
            }
            Console.ReadLine();
        }
    }
}
