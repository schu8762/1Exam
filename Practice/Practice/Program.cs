using System;

namespace DaysIntheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthdays = 0;
            Console.WriteLine("What month are we in?");
            string monthname = Console.ReadLine();
            //monthname = monthname.ToLower();


            if (monthname == "January" || monthname == "March" || monthname == "May" || monthname == "July" || monthname == "August" || monthname == "October" || monthname == "December")
            {
                monthdays = 31;
            }
            else if (monthname == "February")
            {
                Console.WriteLine("Is it a leap year? y/n");
                string leap = Console.ReadLine();

                if (leap == "yes")
                {
                    monthdays = 29;
                }
                if (leap == "no")
                {
                    monthdays = 28;
                }
            else if (monthname == "April" || monthname == "June" || monthname == "September" || monthname == "November")
                {
                    monthdays = 30;
                }
            }
            Console.WriteLine($"there are {monthdays} days in {monthname}");
            Console.ReadKey();
                    }
    }
}
