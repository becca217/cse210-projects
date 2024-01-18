using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        void promptUserName(string name)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
        }
        
        int promptUserNumber(int number)
        {
            Console.Write("What is your favorite number?");
            Console.WriteLine("Your favorite number is: ");
        }

        int squareNumber(int number)
        {

        }

        int displayResults(string name, int squared)
        {
            Console.WriteLine($"Your name is: {name}.");
            Console.WriteLine($"The number squared is: {squared}.");
        }

    }
}