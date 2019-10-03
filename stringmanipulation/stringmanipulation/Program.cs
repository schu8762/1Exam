using System;

namespace stringmanipulation
{
    class Program
    {
        static string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.Write(sentence);

            Console.WriteLine("What word in this sentence do you like the most?");
            string word = Console.ReadLine();

            if (sentence.Contains(word)) //using contains to find the word in the sentence
            {

                Console.WriteLine("What word would you like to change it to?");
                string changeWord = Console.ReadLine();
                string newSentence = sentence.Replace(word, changeWord); //creating new sentence using the Replace function to replace the word
                Console.WriteLine(newSentence);
            }
            else
            {
                for (int i = word.Length - 1; i >= 0; i--) // spitting out a word backwards.
                {
                    Console.Write(word[i]);
                }

            }




            Console.ReadKey();
        }
    }
}
