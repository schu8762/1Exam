using System;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)

        {
            int counter;
            int sum = 0;
            double mult = 1;

            for (counter = 1; counter < 101; counter++)
            {
                sum += counter;
                mult *= counter;

            }
            Console.WriteLine($" {sum.ToString("n0")} and { mult.ToString("N0")}");

            Console.ReadKey();
        }
    }
}
