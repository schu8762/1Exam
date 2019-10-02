using System;

namespace DaysofMonth2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 0;
            Console.WriteLine("What day of the month is it?");
            string month = Console.ReadLine().ToLower();

            if (month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december")
            {
                days = 31;
            }
            else if (month == "february")
            {
                Console.WriteLine("Is it a leap year? yes/no");
                string leap = Console.ReadLine().ToLower();
                
               if (leap == "yes")
                {
                    days = 29;
                }
               else if (leap == "no")
                {
                     days = 28;
                }

            }
            else 
            {
                days = 30;
            }

            Console.WriteLine($"There are {days} days in {month}");
            Console.ReadKey();
        }
    }
}
