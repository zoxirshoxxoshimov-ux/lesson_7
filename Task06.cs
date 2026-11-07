using System;

class Task6
{
    static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine() ?? "0");

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        int sum = 0;

        Console.Write("Even numbers: ");

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Sum: " + sum);
    }
}