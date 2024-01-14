using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You have a {letter}.");
        

        if (percentage >= 70)
        {
            Console.WriteLine("Congrats! You are passing the class!");
        }
        else
        {
            Console.WriteLine("You are not currently passing the class, but you still have time! Work hard!");
        }
    }
}