using System;
namespace Table_of_powers
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            //Ask the user for an input and compare that input to the numbers in array
            Console.WriteLine("Please enter an integer and I will grab the square and cube of that number:");
            string entry = Console.ReadLine();
            number = int.Parse(entry);

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
        static void Printout(int number)
        {
            Console.WriteLine($"Number\t\t\t Squared \t \t Cubed");
            Console.WriteLine($"======\t\t\t ====== \t \t ======");
            //For each number up to the value input, print the number, then the square/cube (max out at 1290^3)
            for (int i = 0; i < number;)
            {
                i++;
                int square = i * i;
                int cube = i * i * i;
                if (i >= 1000)
                {
                    Console.WriteLine($"{i} \t  \t \t {square} \t \t {cube}");
                }
                if(i >= 1291)
                {
                    Console.WriteLine("This number is too large");
                    Main();
                }
                else Console.WriteLine(String.Format($"{i} \t  \t \t {square}\t \t {cube}"));
            }
        }
    }
}
