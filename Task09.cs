using System;

class task9
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine() ?? "";

        string reversed = "";
        string lowerWord = word.ToLowerInvariant();

        for (int i = lowerWord.Length - 1; i >= 0; i--)
        {
            reversed += lowerWord[i];
        }

        if (lowerWord == reversed)
        {
            Console.WriteLine("The word is a palindrome.");
        }
        else
        {
            Console.WriteLine("The word is not a palindrome.");
        }
    }
}