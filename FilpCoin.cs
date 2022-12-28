using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FilpCoin
    {
        public static void CalculatePercentage()
        {
            int tailCount = 0;
            int headCount= 0;
            double headPercentage = 0.0;
            double tailPercentage = 0.0;

            Console.WriteLine("Please enter the value for number filps");
            int filp = Convert.ToInt32(Console.ReadLine());

            if(filp>0)
            {
                for(int i=0;i<filp;i++)
                {
                    Random obj= new Random();
                    int number = obj.Next(2);

                    Console.WriteLine(number);

                    if (number == 0)
                    {
                        tailCount++;
                    }
                    else
                    {
                        headCount++;
                    }
                }

                Console.WriteLine("The TailCount is " + tailCount);
                Console.WriteLine("The HeadCount is " + headCount);

                headPercentage = (headCount * 100) / filp;
                tailPercentage = (tailCount * 100) / filp;

                Console.WriteLine("The TailPercentage is " + tailPercentage+"%");
                Console.WriteLine("The HeadPercentage is " + headPercentage+"%");
            }
            else
            {
                Console.WriteLine("Please enter the correct number");
            }
        }
    }
}
