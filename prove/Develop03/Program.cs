using System;

public class Program
{
    public static void Main(string[] args)
    {
        var scripture = new Scripture(
            new ScriptureReference("John 3:16"),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        );

        Console.Clear();
        Console.WriteLine(scripture.GetFullText());

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.HideRandomWords(3))
            {
                Console.WriteLine("All words are already hidden.");
                break;
            }

            Console.Clear();
            Console.WriteLine(scripture.GetFullText());
        }

        Console.WriteLine("Exiting...");
    }
}
