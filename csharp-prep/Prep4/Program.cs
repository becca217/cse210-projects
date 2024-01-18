using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int entry = -1; 
        while (entry != 0)
        {
            Console.Write("Enter a number: ");
            entry = int.Parse(Console.ReadLine());
            numbers.Add(entry);
        }
        
        // Find the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        // Find the average
        int amount = numbers.Count; 
        int average = sum/amount;
         Console.WriteLine($"The average is: {average}");       
        
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}