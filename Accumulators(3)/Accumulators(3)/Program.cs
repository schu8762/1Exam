using System;

namespace Accumulators_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double mult = 1;


            for (int counter = 1; counter < 101; counter++)
            {
                sum += counter;
                mult *= counter;

            }

            Console.WriteLine($"The sum is {sum}, and the multiplication is {mult}");

            Console.ReadKey();
        }
    }
}
