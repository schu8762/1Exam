using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double weeklysavings = 0;
            double interest = 0.0;
            double totalAmt = 0;
            int savingyears = 0;
            int numyears = 1;
            int nummonths = 1;



            Console.WriteLine("How much money would you like to save in a week?");
            weeklysavings = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What interest rate do you get per month? e.g. 4.5");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("How many years would you like to save for?");
            savingyears = Convert.ToInt32(Console.ReadLine());

            for (int month = 1; month <= savingyears * 12; month++)
            {
                totalAmt += weeklysavings * 4;
                totalAmt += weeklysavings * interest;

                string monthname = month.ToString("N0");

                if (month == 1)
                {
                    monthname = "January";
                }
                else if (month == 2)
                {
                    monthname = "February";
                }
                else if (month == 3)
                {
                    monthname = "March";
                }
                else if (month == 4)
                {
                    monthname = "April";
                }
                else if (month == 5)
                {
                    monthname = "May";
                }
                else if (month == 6)
                {
                    monthname = "June";
                }
                else if (month == 7)
                {
                    monthname = "July";
                }
                else if (month == 8)
                {
                    monthname = "August";
                }
                else if (month == 9)
                {
                    monthname = "September";
                }
                else if (month == 10)
                {
                    monthname = "October";
                }
                else if (month == 11)
                {
                    monthname = "November";
                }
                else
                {
                    monthname = "December";
                }


                Console.WriteLine($"{monthname} @ year {numyears.ToString("N0")} : {totalAmt.ToString("C2")}");


                nummonths++;

                if (month % 12 == 0)
                {
                    numyears++;
                    nummonths = 1;
                }

            }


            Console.ReadKey();

        }

        
    }
}
