using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Would you like to open your journal? Yes or No");
        string journal = Console.ReadLine().ToLower();
        while (journal != "yes"){
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display a previous entry");
            Console.WriteLine("3. Save all entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Type 'end' to end the program");
            Console.WriteLine("What is your choice?");
            string answer = Console.ReadLine();
        }
    }
}