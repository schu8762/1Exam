using System;

namespace Loops_1_redoHW
{
    class Program
    {
        static void Main(string[] args)
        {
            const double minuteCals = 3.9;
            int minutes = 1;

            Console.WriteLine("How many calories do you wish to burn?");
            double calories = Convert.ToDouble(Console.ReadLine());

            double burnedCals = 0;

            while (calories % burnedCals != 0 && calories != burnedCals && calories > burnedCals)
            {
                burnedCals = minutes * minuteCals;
                Console.WriteLine($"In {minutes} minute(s) you have burned {burnedCals}");
                minutes++;

                if (calories == burnedCals)
                {
                    Console.WriteLine($"it took you {minutes} minutes");
                }
            }



            Console.ReadKey();
        }
    }
}
