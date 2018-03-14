using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ReverseOrderofInputIntezer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display reverse order of input");

            Console.WriteLine("Enter character 1");
            string character1 = Console.ReadLine();

            Console.WriteLine("Enter character 2");
            string character2 = Console.ReadLine();

            Console.WriteLine("Enter character 3");
            string character3 = Console.ReadLine();

            Console.WriteLine("The reverse order of the input is " + character3+","+ character2 + "," +character1);
            Console.ReadLine();
        }
    }
}
