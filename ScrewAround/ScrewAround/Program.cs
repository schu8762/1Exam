using System;

namespace ScrewAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gambling = new Random();
            Random gambling2 = new Random();

            int generateNumber1 = gambling.Next(1,11);
            int generateNumber2 = gambling2.Next(1, 11);
            int favoriteNumber;
            int worstActual;

            Console.WriteLine("Input your favorite number");
            string favNumber = Console.ReadLine();

            while (int.TryParse(favNumber, out favoriteNumber) == false)
            {
                Console.WriteLine($"you entered {favNumber}, you must enter an actual number");
                Console.WriteLine("Input your favorite number");
                favNumber = Console.ReadLine();
            }

            Console.WriteLine("Input your least favorite number");
            string worstNumber = Console.ReadLine();

            while (int.TryParse(worstNumber, out worstActual) == false)
            {
                Console.WriteLine($"you entered {worstNumber}, you must enter an actual number");
                Console.WriteLine("Input your least favorite number");
                worstNumber = Console.ReadLine();
            }

            double correctAns = favoriteNumber * worstActual;

            Console.WriteLine($"what is your favorite number {favoriteNumber} multiplied by your least favorite Number {worstActual}?");
            double userMult = Convert.ToDouble(Console.ReadLine());

            while (userMult != correctAns)
            {
                Console.WriteLine("Incorrect answer mane, try again");
                Console.WriteLine($"what is your favorite number {favoriteNumber} multiplied by your least favorite Number {worstActual}?");
                userMult = Convert.ToDouble(Console.ReadLine());
            };

            Console.WriteLine("nice you got it!");

            Console.WriteLine($"guess {generateNumber1} and {generateNumber2}");


            Console.WriteLine("guess a number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            while (number1 != generateNumber1)
            {
                if (number1 > generateNumber1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("you are too high try again");
                    number1 = Convert.ToInt32(Console.ReadLine());
                }
                else if (number1 < generateNumber1)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("you are too low try again");
                    number1 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("wooo hooo on to the next!");
                }
            }


            Console.WriteLine("guess another number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number2 != generateNumber2)
            {
                if (number2 > generateNumber2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("you are too high try again");
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
                else if (number2 < generateNumber2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("you are too low try again");
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("wooo hooo on to the next! \n blahhh");
                }
            }





            Console.WriteLine($"enter any key to leave");



            Console.ReadKey();
        }
    }
}
