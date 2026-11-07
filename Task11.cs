using System;
using System.Text;

class Task11
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine() ?? "";

        StringBuilder result = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            result.Append(text[i]);
        }

        Console.WriteLine(result.ToString());
    }
}