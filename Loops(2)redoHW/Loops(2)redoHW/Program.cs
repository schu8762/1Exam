using System;

namespace Loops_2_redoHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Random rand2 = new Random();

            int generatedNumber = rand.Next(1, 51);
            int generatedNumber2 = rand.Next(1, 51);

            int sum = generatedNumber + generatedNumber2;
            int ans = 0;
                       
            do
            {
                Console.WriteLine($"what is the sum of {generatedNumber} + {generatedNumber2} ?");
                ans = Convert.ToInt32(Console.ReadLine());
            } while (ans != sum);
        }
    }
}
