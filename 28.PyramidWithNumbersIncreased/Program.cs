using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.PyramidWithNumbersIncreased
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pyramid Triangle");
            Console.WriteLine("Enter the number");
            int height = Convert.ToInt32(Console.ReadLine());
            int space = height - 1;

            for(int i=0;i<height;i++)
            {
                for (int j = 0; j < space; j++)
                { 

                    Console.Write(" ");
                }

                for(int k=0;k<= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
                Console.WriteLine("");
                space--;
            }

            Console.ReadLine();
        }
    }
}
