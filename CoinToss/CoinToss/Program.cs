using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int toss = rand.Next(1, 3);
            string toss2;
            string answer;

            if (toss == 1)
            {
                toss2 = "tails";
            }
            else
            {
                toss2 = "heads";
            }

            Console.WriteLine($"{toss}");

            do
            {
                Console.WriteLine("Heads or tails???");
                answer = Console.ReadLine().ToLower();
                
            } while (answer != toss2);

            Console.WriteLine("congrats, you got it!");

            Console.ReadKey();
        }
    }
}
