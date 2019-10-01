using System;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int counter = 1; counter < 101; counter++)
            {
                sum =+ counter;
                Console.WriteLine(sum);
            }
        }
    }
}
