using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int userSelection;
        List<string> entries = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Please select one number of the options above: ");
            string selection = Console.ReadLine();
    
            if (!int.TryParse(selection, out userSelection))
             {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
    
            if (userSelection == 1)
            {
                Write write1 = new Write();
                write1.DisplayWrite();
                Console.Write("< ");
                string newEntry = Console.ReadLine();
                entries.Add(newEntry);
            }
            else if (userSelection == 2)
            {                    
                foreach (var entry in entries)
                {
                    Console.WriteLine ($"Date: 2/20/2024 - Entry: {entry}");
                }
            }
            else if (userSelection == 3)
            {
                Console.WriteLine("You selected option 3.");
            }                
            else if (userSelection == 4)
            {
                Console.WriteLine("You selected option 4.");
            }  
            else if (userSelection == 5)                
            {
                Console.WriteLine("Thank you for taking the time to write today!");
                break;
            }
            // Is the else even needed?
            else
            {
            Console.WriteLine("Please select a valid number from the list (1-5).");
            }
        }     
    }
}