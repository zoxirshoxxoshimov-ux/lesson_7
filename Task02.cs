using System;

class Task2
{
    static void Main()
    {
        Console.WriteLine("Maximum: " + GetMax(12, 8));
        Console.WriteLine("Maximum: " + GetMax(4, 19, 11));
        Console.WriteLine("Maximum: " + GetMax(5.7, 8.2));
    }

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static int GetMax(int a, int b, int c)
    {
        int max = GetMax(a, b);

        if (c > max)
        {
            max = c;
        }

        return max;
    }

    static double GetMax(double a, double b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}