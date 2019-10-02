using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string sentence = "sorry youre stupid";

            Console.WriteLine("Enter your favorite number!");
            string favNumber = Console.ReadLine();

            while (Int32.TryParse(favNumber, out number) == false)
            {
                Console.WriteLine("Invalid input, please enter your favorite number!");
                favNumber = Console.ReadLine();
            }
              
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine($"{number} Fizz Buzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine($"{number} Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine($"{number} Buzz");
            }          
            else
            {
                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    Console.Write(sentence[i]);
                }
            }




            Console.ReadKey();
        }
    }
}
