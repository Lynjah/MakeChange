using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Purchase Amount: ");
             double purchasePrice;
             purchasePrice = double.Parse(Console.ReadLine());
             Console.WriteLine(purchasePrice);

             Console.Write("Payment Amount: ");
             double paymentAmount = double.Parse(Console.ReadLine());

             double changeDue = paymentAmount - purchasePrice;
             Console.WriteLine($"Change Due: ${changeDue}");
            changeDue += 0.00000001;

             //How many 20's
             int twenties = (int)(changeDue / 20);
             Console.WriteLine($"Twenties: {twenties}");
             changeDue -= twenties * 20;
             //Console.WriteLine($"New change due: ${changeDue}");

             //How many 10's
             int tens = (int)(changeDue / 10);
             Console.WriteLine($"Tens: {tens}");
             changeDue -= tens * 10;
             //Console.WriteLine($"New change due: ${changeDue}");

             //How many 5's
             int fives = (int)(changeDue / 5);
             Console.WriteLine($"Fives: {fives}");
             changeDue = changeDue % 5;
             //Console.WriteLine($"New change due: ${changeDue}");

             //How many 1's
             int ones = (int)(changeDue / 1);
             Console.WriteLine($"Ones: {ones}");
             changeDue %= 1;
             //Console.WriteLine($"New change due: ${changeDue}");

             //How many Quarters
             int quarters = (int)(changeDue / 0.25);
             Console.WriteLine($"Quarters: {quarters}");
             changeDue %= 0.25;
             //Console.WriteLine($"New change due: ${changeDue}");

            //How many Dimes
            int dimes = (int)(changeDue / 0.10);
            Console.WriteLine($"Dimes: {dimes}");
            changeDue %= 0.10;
            //Console.WriteLine($"New change due: ${changeDue}");

            //How many Nickels
            int nickels = (int)(changeDue / 0.05);
            Console.WriteLine($"Nicks: {nickels}");
            changeDue %= 0.05;
            //Console.WriteLine($"New change due: ${changeDue}");

            //How many pennies
            int pennies = (int)(changeDue / 0.01);
            Console.WriteLine($"Pennies: {pennies}");
            changeDue %= 0.01;
            //Console.WriteLine($"New change due: ${changeDue}");
        }
    }
}
