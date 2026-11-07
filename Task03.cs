using System;
using System.Globalization;

class Task3
{
    static void Main()
    {
        Console.WriteLine(ConvertToText(125));
        Console.WriteLine(ConvertToText(12.5));

        DateTime date = new DateTime(2026, 11, 5);

        Console.WriteLine(ConvertToText(date));
    }

    static string ConvertToText(int number)
    {
        return number.ToString();
    }

    static string ConvertToText(double number)
    {
        return number.ToString(CultureInfo.InvariantCulture);
    }

    static string ConvertToText(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }
}