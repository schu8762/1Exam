using System;

namespace Rando
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int generatedNumber = randomNumber.Next(1, 101);
            Console.WriteLine(generatedNumber);

            int guess = -1;


            while (guess != generatedNumber)
            {

                Console.WriteLine("Guess a number between 1 and 100");
                string guessedNumber = (Console.ReadLine());

                while (int.TryParse(guessedNumber, out guess) == false)
                {
                    Console.WriteLine("Invalid input, try again!");
                    Console.WriteLine("Guess a number between 1 and 100");
                    guessedNumber = (Console.ReadLine());
                }

                if (generatedNumber == guess)
                {
                    Console.WriteLine("Nice, you got it!");
                }
                else
                {
                    if (generatedNumber > guess)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You are too low");
                    }
                    else if (generatedNumber < guess)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("you are too high");
                    }
                }

            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
