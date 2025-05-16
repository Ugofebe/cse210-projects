using System;
// using System.Security.Cryptography.X509Certificates;

class Program
{
    static Journal _journal = new Journal(); //This is more like instantiating for a class I created in another cs file for use in this file

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nJournal App");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            // Here instead of the if i made use of one i learn whicch is the switch
            switch (input)
            {
                case "1":
                    _journal.WriteNewEntry();
                    break;
                case "2":
                    _journal.DisplayJournal();
                    break;
                case "3":
                    _journal.SaveJournal();
                    break;
                case "4":
                    _journal.LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}