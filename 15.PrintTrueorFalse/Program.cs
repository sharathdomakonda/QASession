using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrintTrueorFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print True or Fasle based on the input numbers");

            Console.WriteLine("Enter the first number ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            bool result;

            if (number1 % 2 == 0 && number2 % 2 == 0)

            {
                result = true;
            }

            else if (number1 % 2 != 0 && number2 % 2 != 0)
            {
                result = true;
            }
           else
            {
                result = false;
            }

            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}
