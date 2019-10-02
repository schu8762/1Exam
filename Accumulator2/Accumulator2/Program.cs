using System;

namespace Accumulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double mult = 1;

            for (int counter = 1; counter < 101; counter++)
            {
               sum += counter;
              // mult *= counter; 
               //Console.WriteLine(sum);
            }
            for (int counter = 1; counter < 101; counter++)
            {
                //sum += counter;
                mult *= counter; 
            }
            Console.WriteLine(sum);
            Console.WriteLine(mult.ToString("n2"));
            Console.ReadKey();
        }
    }
}
