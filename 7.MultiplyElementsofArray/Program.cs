using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MultiplyElementsofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of Elements of two Arrays");
            int[] Array1 = { 1, 3, -5, 4 };
            int[] Array2 = { 1, 4, -5, -2 };
            Console.WriteLine("The Multiplication values of two elements in Arrays are " 
                + Array1[0] * Array2[0]
                + " ," + Array1[1] * Array2[1]
                + " ," + Array1[2] * Array2[2]
                + " ," + Array1[3] * Array2[3]   
                );
            Console.ReadLine();
        }
    }
}
