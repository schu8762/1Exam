using System;

namespace HW1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightHW = .25;
            double weightPart = .1;
            double weightQuizzes = .1;
            double weightMT = .25;
            double weightFinal = .3;


            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            double studentID = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what did you receive in HW?");
            double homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what did you receive in participation?");
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what did you receive in quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what did you receive in midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what did you receive in final?");
            double final = Convert.ToDouble(Console.ReadLine());

            double hwTermgrade = weightHW * homework;
            double partTermgrade = weightPart * participation;
            double partQuizzes = weightQuizzes * quizzes;
            double mtTermgrade = weightMT * midterm;
            double finalTermgrade = weightFinal * final;

            double finalGrade = hwTermgrade + partTermgrade + partQuizzes + mtTermgrade + finalTermgrade;

            Console.WriteLine($"{firstName} {lastName} ({studentID}), your final grade in MIS is {final.ToString("n4")}");





            Console.ReadKey();
        }
    }
}
