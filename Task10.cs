using System;

class Task9
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine() ?? "";

        string[] words = sentence.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        Console.WriteLine("Word count: " + words.Length);
    }
}