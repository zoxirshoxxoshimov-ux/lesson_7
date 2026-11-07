using System;

class Task4
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Sum of digits: " + SumOfDigits(number));
    }

    static int SumOfDigits(int number)
    {
        long positiveNumber = Math.Abs((long)number);
        int sum = 0;

        while (positiveNumber > 0)
        {
            int digit = (int)(positiveNumber % 10);

            sum += digit;
            positiveNumber /= 10;
        }

        return sum;
    }
}