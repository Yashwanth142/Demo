using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class QuotientandRemainder
    {
        public static void QuotientAndRemainder()
        {
            System.Console.WriteLine("Enter the dividend :");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor :");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int qu = dividend / divisor;

            int rem = dividend % divisor;

            Console.WriteLine("The Quotient is : " + qu + " The Remainder is : " + rem);
        }
    }
}
