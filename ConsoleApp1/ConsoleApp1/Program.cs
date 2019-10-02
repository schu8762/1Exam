using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double credits = 3;
            string letterAcc;
            string letterMkt;
            string letterEcon;
            string letterMis;
            double accCred;
            double mktCred;
            double econCred;
            double misCred;

            Console.WriteLine("Enter your grade in Accounting");
            double acc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your grade in mkt");
            double mkt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your grade in econ");
            double econ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your grade in mis");
            double mis = Convert.ToDouble(Console.ReadLine());

            //Accounting Grade
            if (acc >= 90)
            {
                letterAcc = "A";
                accCred = 4;
            }
            else if(acc >= 80)
            {
                letterAcc = "B";
                accCred = 3;
            }
            else if(acc >= 70)
            {
                letterAcc = "C";
                accCred = 2;
            }
            else if(acc >= 60)
            {
                letterAcc = "D";
                accCred = 1;
            }
            else
            {
                letterAcc = "F";
                accCred = 0;
            }

            //Marketing Grade
            if (mkt >= 90)
            {
                letterMkt = "A";
                mktCred = 4;
            }
            else if (mkt >= 80)
            {
                letterMkt = "B";
                mktCred = 3;
            }
            else if (mkt >= 70)
            {
                letterMkt = "C";
                mktCred = 2;
            }
            else if (mkt >= 60)
            {
                letterMkt = "D";
                mktCred = 1;
            }
            else
            {
                letterMkt = "F";
                mktCred = 0;
            }

            //Econ Grade
            if (econ >= 90)
            {
                letterEcon = "A";
                econCred = 4;
            }
            else if (econ >= 80)
            {
                letterEcon = "B";
                econCred = 3;
            }
            else if (econ >= 70)
            {
                letterEcon = "C";
                econCred = 2;
            }
            else if (econ >= 60)
            {
                letterEcon = "D";
                econCred = 1;
            }
            else
            {
                letterEcon = "F";
                econCred = 0;
            }

            //MIS Grade
            if (mis >= 90)
            {
                letterMis = "A";
                misCred = 4;
            }
            else if (mis >= 80)
            {
                letterMis = "B";
                misCred = 3;
            }
            else if (mis >= 70)
            {
                letterMis = "C";
                misCred = 2;
            }
            else if (mis >= 60)
            {
                letterMis = "D";
                misCred = 1;
            }
            else
            {
                letterMis = "F";
                misCred = 0;
            }

            double Accounting = credits * accCred;
            double Marketing = credits * mktCred;
            double Economics = credits * econCred;
            double MIS = credits * misCred;

            double GPAsum = Accounting + Marketing + Economics + MIS;
            double GPA = GPAsum / 12;


            Console.WriteLine($"You received a {letterAcc} in Accounting, a {letterMkt} in Marketing, a {letterEcon} in Econ, and a {letterMis} in MIS. \n \bYour GPA is {GPA.ToString("n2")}");




            Console.ReadKey();
        }
    }
}
