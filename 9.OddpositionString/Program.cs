using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.OddpositionString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the Odd position values of a String");
            String a1="CAMPSYSTEMS";
            int i;
            string a2 = "";

            for(i=0;i<a1.Length;i++)
            {
                if (i % 2 == 0)

                    a2 = a2+a1[i].ToString();

                                         


            }

            Console.WriteLine("The string from the odd positions of the input string are " +a2);
            Console.ReadLine();

        }
    }
}
