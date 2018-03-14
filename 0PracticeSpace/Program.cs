using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0PracticeSpace
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PROGRAM TO store the elements of an array");
            Console.WriteLine("ENTER SIZE OF ARRAY");
            string A1= Console.ReadLine();
            int A2 = Convert.ToInt32(A1);

            int[] A3= new int [A2];



            int i;
            int j;
            int B2 = 0;
            

            for (i=0;i<A2; i++)
            {
                Console.WriteLine("ENTER ELEMENT NUMBER " +i );
                string B1 = Console.ReadLine();
                B2 = Convert.ToInt32(B1);
                A3[i] = B2;
                
            }
            Console.Write("The elements of array are ");

            for (j=0;j<A2; j++)
            {
                
               Console.Write(A3[j]+" ");
            }
           
            Console.ReadLine();

        }
    }
}
