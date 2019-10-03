using System;

namespace screwaround2
{
    class Program
    {
        static string sentence = "This class is pretty dang awesome";
        static void Main(string[] args)
        {
            Console.WriteLine(sentence);
            Console.WriteLine("what is your favorite word in the above sentence?");
            string word = Console.ReadLine();

            if (sentence.Contains(word))
            {
                Console.WriteLine("what do you want to change it to?");
                string newWord = Console.ReadLine();
                string newSentence = sentence.Replace(word, newWord);
                Console.WriteLine(newSentence);
            }
            else
            
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    Console.Write(word[i]);
                }

            

            Console.ReadLine();
        }
    }
}
