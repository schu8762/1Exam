using System;

namespace Palindrome_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string pali = "";
            string newWord = "";
            int index; //variable to track how long the user's input is

            Console.WriteLine("Input a word or a phrase!");
            pali = Console.ReadLine().ToLower();
            index = pali.Length - 1; //measures how long the user's input is

            while (index >= 0)
            {
                newWord += pali[index];
                index--;
            }
            if (newWord == pali)
            {
                Console.WriteLine($"The word {newWord} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The word {pali} reversed is {newWord} is not a palindrome");
            }


            Console.ReadKey();
        }
    }
}
