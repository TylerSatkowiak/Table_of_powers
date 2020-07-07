using System;
using System.Runtime.ExceptionServices;
namespace Table_of_powers
{
    class Program
    {
        static void Main()
        {
            long number = 0;
            //Ask the user for an input and compare that input to the numbers in array
            Console.WriteLine("Please enter an integer and I will grab the square and cube of that number:");
            string entry = Console.ReadLine();
            number = long.Parse(entry);

            //Take user input and assure it is postive, if it is, send into Printout Method
            if (number <= 0)
            {
                Console.WriteLine("You entered an invalid input, please only enter positive values.");
            }
            else Printout(number);

            //Ask the user if they want to run the program again
            Console.WriteLine("Would you like to restart? (Y/N)");
            string q = Console.ReadLine();
            if (q == "Y" || q == "y")
            {
                Console.Clear();
                Main();
            }
            else Console.WriteLine("Thanks for playing, Ta Ta now ;)");
            
        }
        static void Printout(long number)
        {
            //Format Columns to the right
            Console.WriteLine(String.Format("{0,15} {1,15} {2,15}","Number","Squared","Cubed"));
            Console.WriteLine(String.Format("{0,15} {1,15} {2,15}","======","======","======"));

            //For each number up to the value input, print the number, then the square/cube, print out to the right side as strings
            for (long i = 0; i < number;)
            {
                i++;
                long square = i * i;
                long cube = i * i * i;
                string first = i.ToString("N0");
                string second = square.ToString("N0");
                string third = cube.ToString("N0");
                Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", first, second, third));
            }
        }
    }
}
