using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HarmonicValue
    {
        public static void HarmonicNumber() 
        {
            Console.WriteLine("Enter the Harmonic Value :");
            int h=Convert.ToInt32(Console.ReadLine());

            double n = 0.0;
            for(double i=1;i<=h;i++)
            {
                n = n + (1 / i);
            }
            Console.WriteLine("The " + h + " Harmonic number is " + n);
        }
    }
}
