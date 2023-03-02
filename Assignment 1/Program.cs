using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            double x = 32;
            double tempAns;
            double y = 0.5556;

            //Display text
            Console.WriteLine("Assignmnet 1 Part 2");
            Console.WriteLine("Name: Rutvi Mistry");
            Console.WriteLine("Email: rmistry9104@conestogac.on.ca");
            Console.WriteLine("I have some programming experience");

            //Get input
            Console.Write("\nPlease enter a tempreature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            //Calculation
            tempAns = fahrenheit - x;
            celsius = tempAns * y;

            celsius = Math.Round(celsius, 2);

            //Show output
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsius} degrees Celsius");

            Console.ReadKey();

        }
    }
}
