using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int randomMagicNumber = randomNumber.Next(1,100);

        int userGuess = -1;

        while (userGuess != randomMagicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < randomMagicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else if (userGuess > randomMagicNumber)
            {
                Console.WriteLine("Lower."); 
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }

    }
}