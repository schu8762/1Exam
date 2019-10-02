using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double salesTax = .085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            string item = Console.ReadLine();

            Console.WriteLine($"How many {item}s would you like to buy");
            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"What is the price for each {item} ?");
            double price = Convert.ToDouble(Console.ReadLine());

            double subtotal = price * quantity;
            double salesTaxTotal = subtotal * salesTax;
            double totalBill = subtotal + salesTaxTotal;

            Console.WriteLine($"Your subtotal for your bill is {subtotal.ToString("c2")}. \n Your sales tax for your bill is {salesTaxTotal.ToString("c2")}. \n Your total for your bill is {totalBill.ToString("c2")}.");






            Console.ReadKey();
        }
    }
}
