using System;

namespace Loops_3_redoHW
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 12600;
            int years = 0;
            const double incr = 1.05;

            for (years = 0; years < 8; years++)
            {
                tuition *= incr;
                Console.WriteLine($"Tuition in year {years} is {tuition.ToString("c2")}");
            }


            Console.ReadKey();

        }
    }
}
