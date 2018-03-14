using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number triangle");
            Console.WriteLine("Ente the height ");
            int height=Convert.ToInt32(Console.ReadLine());
            int width;

            for (int i = height; i > 0; i--)
            {
                for (width = i; width > 0; width--)
                { 
                    Console.Write(height);
            }
                Console.WriteLine("");
        }
            Console.ReadLine();
    }

    }
}
