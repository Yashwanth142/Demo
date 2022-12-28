using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class LargestOf3Num
    {
        public static void LargestNum() 
        {
            Console.WriteLine("Enter the first number :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b & a>c)
            {
                Console.WriteLine("The Largest number is " + a);
            }
            else if(b>c & b>a)
            {
                Console.WriteLine("The Largest number is " + b);
            }
            else
            {
                Console.WriteLine("The Largest number is " + c);
            }
        }
    }
}