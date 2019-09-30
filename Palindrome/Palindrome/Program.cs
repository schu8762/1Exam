using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)

        {
            int index;
            string phrasereversed = "";


            Console.WriteLine("Enter in your favorite word or phrase!");
            string phrase = Console.ReadLine().ToLower();
            index = phrase.Length - 1;

            while (index >= 0)
            {
                phrasereversed += phrase[index];

                index--;
            };

            Console.WriteLine(phrasereversed);

            if (phrase == phrasereversed)
            {
                Console.WriteLine($"The user's phrase, {phrase} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The user's phrase, {phrase} is NOT a palindrome.");
            }

            Console.WriteLine("Enter any key to exit...");
            Console.ReadKey();
        }
    }
}
