using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                System.Console.WriteLine(IterativeSubtract(8, i));
            }
            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
 
        }

        public static int IterativeSubtract(int numerator, int denominator)
        {
            int times = 0;
            
            while (numerator >= denominator)
            {
                numerator = numerator - denominator;
                times++;
            }
            return times;
        }
}
}
