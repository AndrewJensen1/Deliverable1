using System;
using System.Globalization;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in first number");

            String firstnumber = Console.ReadLine(); 

            Console.WriteLine("Please enter in second number");

            String secondnumber = Console.ReadLine();

            Console.WriteLine("Please enter in third number");

            String thirdnumber = Console.ReadLine();

            double firstnumberconverted = Convert.ToDouble(firstnumber);

            double secondnumberconverted = Convert.ToDouble(secondnumber);

            double thirdnumberconverted = Convert.ToDouble(thirdnumber);

            double sum = firstnumberconverted + secondnumberconverted + thirdnumberconverted;

            double average = sum / 3;

            Console.WriteLine("Total: " + sum);

            Console.WriteLine("Average: " + average);

            Console.WriteLine("The Largest Number is: " + Math.Max(firstnumberconverted, Math.Max(secondnumberconverted, thirdnumberconverted)));

            Console.WriteLine("The Smallest Number is: " + Math.Min(firstnumberconverted, Math.Min(secondnumberconverted, thirdnumberconverted)));
             
            Console.WriteLine("US Currency Total: " + sum.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine("Swedish Currency Total: " + sum.ToString("C", new CultureInfo("sv-SE")));

            Console.WriteLine("Japanese Currency Total: " + sum.ToString("C", new CultureInfo("ja-JP")));

            Console.WriteLine("Thai Currency Total: " + sum.ToString("C", new CultureInfo("th-TH")));

        }
    }
}
