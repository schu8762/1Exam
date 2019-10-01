using System;

namespace DaysIntheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthdays = 0;

            Console.WriteLine("What month are we in?");
            string monthname = Console.ReadLine().ToLower();

            if (monthname == "january" || monthname == "march" || monthname == "may" || monthname == "july" || monthname == "august" || monthname == "october" || monthname == "december")
            {
                monthdays = 31;
            }
            else if (monthname == "february")
            {
                Console.WriteLine("Is it a leap year? yes/no");
                string leap = Console.ReadLine().ToLower();

                if (leap == "yes")
                {
                    monthdays = 29;
                }
                if (leap == "no")
                {
                    monthdays = 28;
                }
            }
            else if (monthname == "april" || monthname == "june" || monthname == "september" || monthname == "november")
            {
                monthdays = 30;
            }
            


            Console.WriteLine($"There are {monthdays} days in {monthname}");
            Console.ReadKey();

        }
    }
}