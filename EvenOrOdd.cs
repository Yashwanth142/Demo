using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class EvenOrOdd
    {
        public static void CheckEvenorOdd()
        {
            Console.WriteLine("Enter a number :");
            int num=Convert.ToInt32(Console.ReadLine());

            if(num %2 == 0) 
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
