using System;

namespace savings_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double weeklySavings = 0;
            double interestRate = 0;
            double totalSavings = 0; //The accumulating variable that will use to keep track of the total amount save
            int yearsSaving = 0;
            int year = 1;   //Keeping track of which year we're in
            int numMonths = 1; // Keeping track of which month we are in

            Console.WriteLine("How much money would you like to save in a week?!");
            weeklySavings = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What interest rate would you be receiving per month?");
            interestRate = Convert.ToDouble(Console.ReadLine())/100;

            Console.WriteLine("How many years do you want to save for?");
            yearsSaving = Convert.ToInt32(Console.ReadLine());

            for (int month = 1; month <= yearsSaving * 12; month++)
            {
                totalSavings += weeklySavings * 4;
                totalSavings += totalSavings * interestRate;

                string monthName = month.ToString("N0");

                if (numMonths == 1)
                {
                    monthName = "January";
                }
                else if (numMonths == 2)
                {
                    monthName = "February";
                }
                else if (numMonths == 3)
                {
                    monthName = "March";
                }
                else if (numMonths == 4)
                {
                    monthName = "April";
                }
                else if (numMonths == 5)
                {
                    monthName = "May";
                }
                else if (numMonths == 6)
                {
                    monthName = "June";
                }
                else if (numMonths == 7)
                {
                    monthName = "July";
                }
                else if (numMonths == 8)
                {
                    monthName = "August";
                }
                else if (numMonths == 9)
                {
                    monthName = "September";
                }
                else if (numMonths == 10)
                {
                    monthName = "October";
                }
                else if (numMonths == 11)
                {
                    monthName = "November";
                }
                else
                {
                    monthName = "December";
                }

                Console.WriteLine($"{monthName}, year {year}: Money saved so far is {totalSavings.ToString("C2")}");

                numMonths++;

                if (month % 12 == 0)
                {
                    year++;
                    numMonths = 1;
                }

               

            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
