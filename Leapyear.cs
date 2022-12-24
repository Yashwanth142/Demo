using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Leapyear
    {
        public static void LeapYear()
        {
            Console.WriteLine("Enter a year :");
            int y = Convert.ToInt32(Console.ReadLine());
            
            if ((y % 4) == 0 & (y % 100) == 0 & (y % 400) == 0)
            {
                Console.WriteLine("The " + y + " year is leap year");
            }
            else
            {
                Console.WriteLine("The " + y + " is not a leap year");
            }
        }
    }
}
