using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SwapofTwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap of Two numbers");

            Console.WriteLine("Enter first number to swap");
            String Numberone = Console.ReadLine();
            int Swapone = Convert.ToInt32(Numberone);

            Console.WriteLine("Enter second number to swap");
            String Numbertwo = Console.ReadLine();
            int SwapTwo = Convert.ToInt32(Numbertwo);

            int swappedone = SwapTwo;
            int swappedtwo = Swapone;

            Console.WriteLine("The Swap of the first number is " + swappedone);
            Console.WriteLine("The Swap of the second number is " + swappedtwo);

            Console.ReadLine();
                    }
    }
}
