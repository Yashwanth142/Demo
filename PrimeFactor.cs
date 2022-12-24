using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class PrimeFactor
    {
        public static void Primefactors()
        {
            Console.WriteLine("Enter a number :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime factor of " + n + " are : ");
            for(int i=2;i<n;i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
