using System;

class Task7
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine() ?? "";

        int letters = 0;
        int digits = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                letters++;
            }
            else if (char.IsDigit(text[i]))
            {
                digits++;
            }
        }

        Console.WriteLine("Total characters: " + text.Length);
        Console.WriteLine("Letters: " + letters);
        Console.WriteLine("Digits: " + digits);
    }
}