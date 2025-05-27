using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a scripture (can be changed to any scripture)
        Reference reference = new Reference("John", 3, 16);
        string originalText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, originalText);

        // Main program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue, 'quit' to exit, or 'reset' to start over:");
            

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (scripture.IsCompletelyHidden())
                break;
            // My additional requirement 
            if (input.ToLower() == "reset")
            {
                scripture = new Scripture(reference, originalText); 
                continue;
            }

            scripture.HideRandomWords(3);

        
        }
    }
}