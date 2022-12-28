using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Swap2num
    {
        public static void SwapNum()
        {
            Console.WriteLine("Enter the first number :");
            int a=  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swap the two numbers  a: " + a + " b : " + b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swap the two numbers a : " + a + " b : " + b);
        }
    }
}
